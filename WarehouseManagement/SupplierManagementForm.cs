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
    public partial class SupplierManagementForm : BaseForm
    {
        public string where;
        public SupplierManagementForm()
        {
            InitializeComponent();
        }

        private void SupplierManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Suppliers.Delete)))
                {
                    btnDelete.Enabled = false;
                }
                btnSearch_Click(null, null);
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
                if (!String.IsNullOrEmpty(txtMa.Text))
                {
                    where += " AND MaNhaCungCap LIKE N'%" + txtMa.Text + "%'";
                }
                if (!String.IsNullOrEmpty(txtTen.Text))
                {
                    where += " AND TenNhaCungCap LIKE N'%" + txtTen.Text + "%'";
                }
                if (!String.IsNullOrEmpty(txtDiaChi.Text))
                {
                    where += " AND DiaChi LIKE N'%" + txtDiaChi.Text + "%'";
                }
                if (!String.IsNullOrEmpty(txtSoDienThoai.Text))
                {
                    where += " AND SoDienThoai LIKE N'%" + txtSoDienThoai.Text + "%'";
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
                dgList.DataSource = NhaCungCap.SelectDynamic(GetSearchWhere(), null).Tables[0];
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
                    if (ShowMessage("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", true, false) == "Yes")
                    {
                        NhaCungCap NhaCungCap = NhaCungCap.Load(id);
                        NhaCungCap.Delete();
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
                ShowMessage("Xóa không thành công. Một hoặc nhiều phiếu nhập kho hoặc phiếu chi hoặc công nợ đã chứa nhà cung cấp này!", false, false);
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
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    NhaCungCap NhaCungCap = NhaCungCap.Load(id);
                    SupplierForm f = new SupplierForm();
                    f.NhaCungCap = NhaCungCap;
                    f.ShowDialog(this);
                }
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnExportReceipts_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách nhà cung cấp_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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
