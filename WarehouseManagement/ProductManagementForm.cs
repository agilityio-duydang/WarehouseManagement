using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using System.Globalization;
using Company.WM.BLL;

namespace WarehouseManagement
{
    public partial class ProductManagementForm : BaseForm
    {
        public string where;
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            LoadCategoty();
            btnSearch_Click(null, null);
        }

        private void LoadCategoty()
        {
            try
            {
                cbbCategory.DataSource = NhomHangHoa.SelectAll().Tables[0];
                cbbCategory.DisplayMember = "TenNhom";
                cbbCategory.ValueMember = "Id";
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
                if (!String.IsNullOrEmpty(txtMaHangHoa.Text))
                {
                    where += " AND MaHangHoa LIKE N'%" + txtMaHangHoa.Text + "%'";
                }
                if (!String.IsNullOrEmpty(txtTenHangHoa.Text))
                {
                    where += " AND TenHangHoa LIKE N'%" + txtTenHangHoa.Text + "%'";
                }
                if (cbbCategory.SelectedValue != null)
                {
                    where += " AND NhomHangHoaId = '" + cbbCategory.SelectedValue + "'";
                }
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
                dgList.Refetch();
                dgList.DataSource = HangHoa.SelectDynamic(GetSearchWhere(), null).Tables[0];
                dgList.Refresh();
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
                    if (ShowMessage("Bạn có chắc chắn muốn xóa hàng hoá này không?", true, false) == "Yes")
                    {
                        HangHoa HangHoa = HangHoa.Load(id);
                        HangHoa.Delete();
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

        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    HangHoa HangHoa = HangHoa.Load(id);
                    ProductForm f = new ProductForm();
                    f.hanghoa = HangHoa;
                    f.ShowDialog(this);
                }
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        public string ToTrimmedString(decimal num)
        {
            string str = num.ToString();
            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (str.Contains(decimalSeparator))
            {
                str = str.TrimEnd('0');
                if (str.EndsWith(decimalSeparator))
                {
                    str = str.Remove(str.Length - 1, 1);
                }
            }
            return str;
        }

        public string RemoveFromEnd(string str, int characterCount)
        {
            return str.Remove(str.Length - characterCount, characterCount);
        }

        private void dgList_LoadingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal DonGiaNhap = (decimal)e.Row.Cells["DonGiaNhap"].Value;
                    decimal DonGiaBan = (decimal)e.Row.Cells["DonGiaBan"].Value;
                    long NhomHangHoaId = (long)e.Row.Cells["NhomHangHoaId"].Value;
                    e.Row.Cells["DonGiaNhap"].Text = DonGiaNhap.ToString("#,##0");
                    e.Row.Cells["DonGiaBan"].Text = DonGiaBan.ToString("#,##0");
                    e.Row.Cells["NhomHangHoaId"].Text = NhomHangHoa.Load(NhomHangHoaId).TenNhom;
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
                sfNPL.FileName = "Danh sách hàng hoá_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            ReadExcelForm f = new ReadExcelForm();
            f.ShowDialog(this);
            btnSearch_Click(null, null);
        }
    }
}
