﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using Janus.Windows.GridEX;

namespace WarehouseManagement.WareHouse
{
    public partial class WareHouseManagementForm : BaseForm
    {
        public string where;
        public WareHouseManagementForm()
        {
            InitializeComponent();
        }

        private void WareHouseManagement_Load(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(WareHouses.Delete)))
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
                if (!String.IsNullOrEmpty(txtMaKho.Text))
                {
                    where += " AND MaKho LIKE N'%" + txtMaKho.Text + "%'";
                }
                if (!String.IsNullOrEmpty(txtTenKho.Text))
                {
                    where += " AND TenKho LIKE N'%" + txtTenKho.Text + "%'";
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
                try
                {
                    dgList.Refetch();
                    dgList.DataSource = Kho.SelectCollectionDynamic(GetSearchWhere(), null);
                    dgList.Refresh();
                }
                catch (Exception ex)
                {
                    Logger.LocalLogger.Instance().WriteMessage(ex);
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
                    if (ShowMessage("Bạn có chắc chắn muốn xóa kho này không?", true, false) == "Yes")
                    {
                        Kho Kho = Kho.Load(id);
                        PhieuNhapKho PhieuNhapKho = PhieuNhapKho.SelectCollectionDynamic("MaKho = N'" + Kho.MaKho + "'", "").FirstOrDefault();
                        if (PhieuNhapKho == null)
                        {
                            Kho.Delete();
                            ShowMessage("Xóa thành công. ", false, false);
                        }
                        else
                        {
                            ShowMessage("Xóa không thành công. Một hoặc nhiều phiếu nhập kho đã chứa thông tin của kho này!", false, false);
                        }
                    }
                    else
                        ShowMessage("Xóa không thành công. ", false, false);
                }
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Xóa không thành công. Một hoặc nhiều phiếu nhập kho đã chứa thông tin của kho này!", false, false);
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
                    Kho Kho = Kho.Load(id);
                    WareHouseForm f = new WareHouseForm();
                    f.Kho = Kho;
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
                sfNPL.FileName = "Danh sách kho_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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
