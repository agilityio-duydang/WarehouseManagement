using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using System.Globalization;
using Janus.Windows.GridEX;
using System.Reflection;

namespace WarehouseManagement
{
    public partial class ReceiptsManagementForm : BaseForm
    {
        public string where;
        public ReceiptsManagementForm()
        {
            InitializeComponent();
        }

        private void ReceiptsManagementForm_Load(object sender, EventArgs e)
        {
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Receiptes.Delete)))
            {
                btnDelete.Enabled = false;
            }
            LoadCategoty();
            btnSearch_Click(null, null);
        }

        private void LoadCategoty()
        {
            try
            {
                cbbLoaiThu.DataSource = LoaiThu.SelectAll().Tables[0];
                cbbLoaiThu.DisplayMember = "Ten";
                cbbLoaiThu.ValueMember = "Id";
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
                if (cbbLoaiThu.SelectedValue != null)
                {
                    where += " AND LoaiThuId = '" + cbbLoaiThu.SelectedValue + "'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgList.CurrentRow.RowType == RowType.Record)
                {
                    int id = System.Convert.ToInt32(dgList.CurrentRow.Cells["Id"].Value.ToString());
                    if (ShowMessage("Bạn có chắc chắn muốn xóa phiếu thu này không?", true, false) == "Yes")
                    {
                        PhieuThu PhieuThu = PhieuThu.Load(id);
                        PhieuThu.Delete();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DataTablePhieuThu = PhieuThu.SelectDynamic(GetSearchWhere(), null).Tables[0];

                List<PhieuThu> PhieuThuCollection = new List<PhieuThu>();
                PhieuThuCollection = ConvertDataTable<PhieuThu>(DataTablePhieuThu);

                decimal tongThu = 0;
                foreach (var item in PhieuThuCollection)
                {
                    tongThu += item.GiaTri;
                }

                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                string TongThu = decimal.Parse(tongThu.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                lbltongThu.Text = TongThu;

                dgList.Refetch();
                dgList.DataSource = DataTablePhieuThu;
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

        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    PhieuThu PhieuThu = PhieuThu.Load(id);
                    ReceiptsForm f = new ReceiptsForm();
                    f.PhieuThu = PhieuThu;
                    f.ShowDialog(this);
                    btnSearch_Click(null, null);
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
                    decimal GiaTri = (decimal)e.Row.Cells["GiaTri"].Value;
                    long LoaiThuId = (long)e.Row.Cells["LoaiThuId"].Value;
                    e.Row.Cells["GiaTri"].Text = GiaTri.ToString("#,##0");
                    e.Row.Cells["LoaiThuId"].Text = LoaiThu.Load(LoaiThuId).Ten;
                }
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
                    //Helpers help = new Helpers();
                    //help.SendEmmailPhieuThuTotal(dateTuNgay.Value, dateDenNgay.Value);
                    //ShowMessage("Gửi báo cáo thành công. ", false, false);
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
                sfNPL.FileName = "Danh sách phiếu thu_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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

        private void btnSendEmailReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ShowMessage("Bạn có chắc chắn muốn gửi Email báo cáo này không?", true, false) == "Yes")
                {
                    Helpers help = new Helpers();
                    help.SendEmmailReceiptsTotal(dateTuNgay.Value, dateDenNgay.Value);
                    ShowMessage("Gửi báo cáo thành công. ", false, false);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
