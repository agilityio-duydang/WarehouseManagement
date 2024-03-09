using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using Janus.Windows.GridEX;

namespace WarehouseManagement
{
    public partial class DebtManagementForm : BaseForm
    {
        public string where;
        public List<CongNoKhachHang> CongNoKhachHangCollection = new List<CongNoKhachHang>();
        public DebtManagementForm()
        {
            InitializeComponent();
        }

        private void DebtManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomer();
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
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

        private string GetSearchWhere()
        {
            try
            {
                where = " 1 = 1";
                if (cbbKhachHang.SelectedValue != null)
                {
                    where += " AND KhachHangId = '" + cbbKhachHang.SelectedValue + "'";
                }
                where += " AND ThoiGian BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dateDenNgay.Value.ToString("yyyy-MM-dd 23:59:59") + "'";
                return where;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CongNoKhachHangCollection = CongNoKhachHang.SelectCollectionDynamic(GetSearchWhere(), null);
                dgList.Refetch();
                dgList.DataSource = CongNoKhachHangCollection;
                dgList.Refresh();
                CaculatorData();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void CaculatorData()
        {
            try
            {
                decimal TotalTongTien = 0;
                decimal TotalTongThanhToan = 0;
                decimal TotalTongConNo = 0;
                foreach (CongNoKhachHang item in CongNoKhachHangCollection)
                {
                    TotalTongTien += item.TongTien;
                    TotalTongThanhToan += item.TongDaThanhToan;
                    TotalTongConNo += item.TongConNo;
                }
                txtTongTien.Text = TotalTongTien.ToString();
                txtTongThanhToan.Text = TotalTongThanhToan.ToString();
                txtTongConNo.Text = TotalTongConNo.ToString();
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

        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["HoaDonId"].Value);
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

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal TongTien = (decimal)e.Row.Cells["TongTien"].Value;
                    e.Row.Cells["TongTien"].Text = TongTien.ToString("#,##0");

                    decimal TongDaThanhToan = (decimal)e.Row.Cells["TongDaThanhToan"].Value;
                    e.Row.Cells["TongDaThanhToan"].Text = TongDaThanhToan.ToString("#,##0");

                    decimal TongConNo = (decimal)e.Row.Cells["TongConNo"].Value;
                    e.Row.Cells["TongConNo"].Text = TongConNo.ToString("#,##0");

                    long HoaDonId = Convert.ToInt64(e.Row.Cells["HoaDonId"].Value);
                    e.Row.Cells["HoaDonId"].Text = HoaDon.Load(HoaDonId).MaHoaDon;

                    long KhachHangId = Convert.ToInt64(e.Row.Cells["KhachHangId"].Value);
                    e.Row.Cells["KhachHangId"].Text = KhachHang.Load(KhachHangId).TenKhachHang;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách công nợ khách hàng_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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
