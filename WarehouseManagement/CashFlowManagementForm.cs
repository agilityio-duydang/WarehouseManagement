using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using System.Reflection;
using System.Globalization;
using Company.WM.BLL;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class CashFlowManagementForm : BaseForm
    {
        public string where;
        public CashFlowManagementForm()
        {
            InitializeComponent();
        }

        private void CashFlowManagementForm_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
            LoadCustomer();
            LoadNhanVien();
        }

        private void LoadCustomer()
        {
            try
            {
                cbbKhachHang.DataSource = KhachHang.SelectAll().Tables[0];
                cbbKhachHang.DisplayMember = "TenKhachHang";
                cbbKhachHang.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadNhanVien()
        {
            try
            {
                cbbNhanVien.DataSource = User.SelectAll().Tables[0];
                cbbNhanVien.DisplayMember = "FullName";
                cbbNhanVien.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private string GetSearchWhere()
        {
            try
            {
                where = " 1 = 1";
                if (cbbKhachHang.SelectedValue != null)
                {
                    where += " AND KhachHangId = '" + cbbKhachHang.SelectedValue + "'";
                }
                if (cbbNhanVien.SelectedValue != null)
                {
                    where += " AND NhanVienId = '" + cbbNhanVien.SelectedValue + "'";
                }
                where += " AND ThoiGianThanhToan BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dateDenNgay.Value.ToString("yyyy-MM-dd 23:59:59") + "'";

                return where;
            }
            catch (Exception ex)
            {
                return null;
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private string GetSearchWherePayment()
        {
            try
            {
                where = " 1 = 1";
                where += " AND ThoiGian BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dateDenNgay.Value.ToString("yyyy-MM-dd 23:59:59") + "'";

                return where;
            }
            catch (Exception ex)
            {
                return null;
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DataTableHoaDon = HoaDon.SelectDynamic(GetSearchWhere(), null).Tables[0];

                List<HoaDon> HoaDonCollection = new List<HoaDon>();
                HoaDonCollection = ConvertDataTable<HoaDon>(DataTableHoaDon);

                decimal tongThu = 0;
                foreach (var item in HoaDonCollection)
                {
                    tongThu += item.TongTien;
                }

                DataTable DataTableReceipts = PhieuThu.SelectDynamic(GetSearchWherePayment(), null).Tables[0];
                List<PhieuThu> PhieuThuCollection = new List<PhieuThu>();
                PhieuThuCollection = ConvertDataTable<PhieuThu>(DataTableReceipts);

                decimal tongPhieuThu = 0;
                foreach (var item in PhieuThuCollection)
                {
                    tongPhieuThu += item.GiaTri;
                }

                tongThu += tongPhieuThu;

                DataTable DataTablePayment = Payment.SelectDynamic(GetSearchWherePayment(), null).Tables[0];
                List<Payment> PaymentCollection = new List<Payment>();
                PaymentCollection = ConvertDataTable<Payment>(DataTablePayment);

                decimal tongChi = 0;
                foreach (var item in PaymentCollection)
                {
                    tongChi += item.GiaTri;
                }

                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                string TongThu = decimal.Parse(tongThu.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                lblTongThu.Text = TongThu;

                string TongChi = decimal.Parse(tongChi.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                lblTongChi.Text = TongChi;

                string TonQuy = decimal.Parse((tongThu - tongChi).ToString()).ToString("#,###", cultureInfo.NumberFormat);
                lblTonQuy.Text = TonQuy;

                dgList.Refetch();
                dgList.DataSource = DataTableHoaDon;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal TongTien = (decimal)e.Row.Cells["TongTien"].Value;
                    long KhachHangId = (long)e.Row.Cells["KhachHangId"].Value;
                    long NhanVienId = (long)e.Row.Cells["NhanVienId"].Value;
                    e.Row.Cells["TongTien"].Text = TongTien.ToString("#,##0");
                    e.Row.Cells["KhachHangId"].Text = KhachHang.Load(KhachHangId).TenKhachHang;
                    e.Row.Cells["NhanVienId"].Text = User.Load(NhanVienId).FullName;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    HoaDon HoaDon = HoaDon.Load(id);
                    HoaDon.HangHoaCollection = HoaDon_HangHoa.SelectCollectionBy_HoaDonId(HoaDon.Id);
                    InvoicesForm f = new InvoicesForm();
                    f.HoaDon = HoaDon;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgList.CurrentRow.RowType == RowType.Record)
                {
                    int id = System.Convert.ToInt32(dgList.CurrentRow.Cells["Id"].Value.ToString());
                    if (ShowMessage("Bạn có chắc chắn muốn xóa hoá đơn này không?", true, false) == "Yes")
                    {
                        HoaDon HoaDon = HoaDon.Load(id);
                        HoaDon.HangHoaCollection = HoaDon_HangHoa.SelectCollectionBy_HoaDonId(HoaDon.Id);
                        HoaDon.DeleteFull();
                        ShowMessage("Xóa thành công. ", false, false);
                    }
                    else
                        ShowMessage("Xóa không thành công. ", false, false);
                }
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnSendEmailReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowMessage("Bạn có chắc chắn muốn gửi Email báo cáo này không?", true, false) == "Yes")
                {
                    Helpers help = new Helpers();
                    help.SendEmmailReportTotal(dateTuNgay.Value, dateDenNgay.Value);
                    ShowMessage("Gửi báo cáo thành công. ", false, false);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách hoá đơn_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
                sfNPL.Filter = "Excel files| *.xls";
                if (ShowMessage("Bạn có muốn xuất thông tin này ra File Excel không? ", true, false) == "Yes")
                {
                    if (sfNPL.ShowDialog(this) == DialogResult.OK && sfNPL.FileName != "")
                    {

                        Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter();
                        gridEXExporter1.GridEX = dgList;
                        try
                        {
                            System.IO.Stream str = sfNPL.OpenFile();
                            gridEXExporter1.Export(str);
                            str.Close();
                            if (ShowMessage("Bạn có muốn mở File này không?", true, false) == "Yes")
                            {
                                System.Diagnostics.Process.Start(sfNPL.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.LocalLogger.Instance().WriteMessage(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
