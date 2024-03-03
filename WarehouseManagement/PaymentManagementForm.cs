using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using Janus.Windows.GridEX;
using Company.WM.BLL;

namespace WarehouseManagement
{
    public partial class PaymentManagementForm : BaseForm
    {
        public string where;
        public PaymentManagementForm()
        {
            InitializeComponent();
        }

        private void PaymentManagementForm_Load(object sender, EventArgs e)
        {
            LoadCategoty();
            btnSearch_Click(null,null);
        }

        private void LoadCategoty()
        {
            try
            {
                cbbLoaiChi.DataSource = PaymentType.SelectAll().Tables[0];
                cbbLoaiChi.DisplayMember = "Ten";
                cbbLoaiChi.ValueMember = "Id";
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
                if (cbbLoaiChi.SelectedValue != null)
                {
                    where += " AND PaymentTypeId = '" + cbbLoaiChi.SelectedValue + "'";
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
                    if (ShowMessage("Bạn có chắc chắn muốn xóa phiếu chi này không?", true, false) == "Yes")
                    {
                        Payment Payment = Payment.Load(id);
                        Payment.Delete();
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
                DataTable DataTablePayment = Payment.SelectDynamic(GetSearchWhere(), null).Tables[0];

                List<Payment> PaymentCollection = new List<Payment>();
                PaymentCollection = ConvertDataTable<Payment>(DataTablePayment);

                decimal tongChi = 0;
                foreach (var item in PaymentCollection)
                {
                    tongChi += item.GiaTri;
                }

                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                string TongChi = decimal.Parse(tongChi.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                lblTongChi.Text = TongChi;

                dgList.Refetch();
                dgList.DataSource = DataTablePayment;
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
                    Payment Payment = Payment.Load(id);
                    PaymentForm f = new PaymentForm();
                    f.Payment = Payment;
                    f.ShowDialog(this);
                    btnSearch_Click(null,null);
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
                    long PaymentTypeId = (long)e.Row.Cells["PaymentTypeId"].Value;
                    e.Row.Cells["GiaTri"].Text = GiaTri.ToString("#,##0");
                    e.Row.Cells["PaymentTypeId"].Text = PaymentType.Load(PaymentTypeId).Ten;
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
                    Helpers help = new Helpers();
                    help.SendEmmailPaymentTotal(dateTuNgay.Value, dateDenNgay.Value);
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
                sfNPL.FileName = "Danh sách phiếu chi_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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
