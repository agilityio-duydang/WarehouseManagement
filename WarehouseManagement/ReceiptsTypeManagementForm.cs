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
    public partial class ReceiptsTypeManagementForm : BaseForm
    {
        public string where;
        public ReceiptsTypeManagementForm()
        {
            InitializeComponent();
        }

        private void ReceiptsTypeManagementForm_Load(object sender, EventArgs e)
        {
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(ReceiptsTypes.Delete)))
            {
                btnDelete.Enabled = false;
            }
            btnSearch_Click(null, null);
        }

        private string GetSearchWhere()
        {
            try
            {
                where = " 1 = 1";
                if (!String.IsNullOrEmpty(txtTen.Text))
                {
                    where += " AND Ten LIKE N'%" + txtTen.Text + "%'";
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
                dgList.DataSource = LoaiThu.SelectCollectionDynamic(GetSearchWhere(), null);
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
                    if (ShowMessage("Bạn có chắc chắn muốn xóa loại thu này không?", true, false) == "Yes")
                    {
                        List<PhieuThu> PhieuThuCollection = PhieuThu.SelectCollectionAll();
                        LoaiThu LoaiThu = LoaiThu.Load(id);
                        if (!PhieuThuCollection.Any(x => x.LoaiThuId == LoaiThu.Id))
                        {
                            LoaiThu.Delete();
                            ShowMessage("Xóa thành công. ", false, false);
                        }
                        else
                        {
                            ShowMessage("Xóa không thành công. Một hoặc phiếu thu nhập chứa loại chi này !", false, false);
                        }
                    }
                    else
                        ShowMessage("Xóa không thành công. Một hoặc phiếu thu đã nhập loại chi này !", false, false);
                }
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Xóa không thành công. Một hoặc phiếu chi đã nhập loại chi này !", false, false);
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
                sfNPL.FileName = "Danh sách loại thu" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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

        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    LoaiThu LoaiThu = LoaiThu.Load(id);
                    ReceiptsTypeForm f = new ReceiptsTypeForm();
                    f.LoaiThu = LoaiThu;
                    f.ShowDialog(this);
                }
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
