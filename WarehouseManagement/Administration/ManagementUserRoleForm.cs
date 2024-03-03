using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL.Administration;
using Janus.Windows.GridEX;

namespace WarehouseManagement.Administration
{
    public partial class ManagementUserRoleForm : BaseForm
    {
        private GROUPS group = new GROUPS();
        private GROUPSCollection collectionGroup = new GROUPSCollection();
        private ROLECollection collectionRole = new ROLECollection();
        private ROLE role = new ROLE();
        private int ModuleCurrent = 0;
        private long GroupCurrent = 0;
        public ManagementUserRoleForm()
        {
            InitializeComponent();
        }

        private void ManagementUserRoleForm_Load(object sender, EventArgs e)
        {
            try
            {
                collectionGroup = group.SelectCollectionAll();
                dgListNhom.DataSource = collectionGroup;
                if (collectionGroup.Count > 0)
                {
                    GroupCurrent = collectionGroup[0].MA_NHOM;
                    lblNhomPhanQuyen.Text = "Phân quyền cho nhóm : " + collectionGroup[0].TEN_NHOM;
                }
                cbModule.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
            try
            {
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void BindDataRole()
        {
            try
            {
                string where = "";
                ModuleCurrent = Convert.ToInt32(cbModule.SelectedValue);
                if (ModuleCurrent > 0)
                {
                    where = "ID_MODULE=" + ModuleCurrent;
                    collectionRole = role.SelectCollectionDynamic(where, "");
                }
                else
                    collectionRole = role.SelectCollectionAll();
                GROUP_ROLE gr = new GROUP_ROLE();
                gr.GROUP_ID = GroupCurrent;

                GROUP_ROLECollection grCollection = gr.SelectCollectionBy_GROUP_IDAndModule(ModuleCurrent);
                foreach (GROUP_ROLE grEntity in grCollection)
                {
                    foreach (ROLE r in collectionRole)
                    {
                        if (r.ID == grEntity.ID_ROLE)
                        {
                            r.Check = true;
                            break;
                        }
                    }
                }
                dgListRole.DataSource = collectionRole;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void cbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (GroupCurrent > 0)
                {
                    BindDataRole();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListRole_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    if (e.Row.Cells["ID_MODULE"].Value.ToString() == "1")
                        e.Row.Cells["ID_MODULE"].Text = "Bán hàng";
                    else if (e.Row.Cells["ID_MODULE"].Value.ToString() == "2")
                        e.Row.Cells["ID_MODULE"].Text = "Nhóm hàng hoá";
                    else if (e.Row.Cells["ID_MODULE"].Value.ToString() == "3")
                        e.Row.Cells["ID_MODULE"].Text = "Hàng hoá";
                    else if (e.Row.Cells["ID_MODULE"].Value.ToString() == "4")
                        e.Row.Cells["ID_MODULE"].Text = "Xuất nhập tồn";
                    else if (e.Row.Cells["ID_MODULE"].Value.ToString() == "5")
                        e.Row.Cells["ID_MODULE"].Text = "Nhập kho";
                    else if (e.Row.Cells["ID_MODULE"].Value.ToString() == "6")
                        e.Row.Cells["ID_MODULE"].Text = "Quản trị hệ thống";
                    if (e.Row.Cells["Check"].Value.ToString() == "True")
                    {
                        e.Row.CheckState = RowCheckState.Checked;
                    }
                    else
                        e.Row.CheckState = RowCheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListNhom_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                GroupCurrent = Convert.ToInt64(e.Row.Cells["Ma_Nhom"].Value);
                lblNhomPhanQuyen.Text = "Phân quyền cho nhóm : " + e.Row.Cells["TEN_NHOM"].Text;
                BindDataRole();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GROUP_ROLECollection grCollection = new GROUP_ROLECollection();
                foreach (GridEXRow row in dgListRole.GetCheckedRows())
                {
                    if (row.RowType == RowType.Record)
                    {
                        ROLE r = (ROLE)row.DataRow;
                        GROUP_ROLE gr = new GROUP_ROLE();
                        gr.GROUP_ID = GroupCurrent;
                        gr.ID_ROLE = r.ID;
                        grCollection.Add(gr);
                    }
                }
                GROUP_ROLE grUpdate = new GROUP_ROLE();
                grUpdate.GROUP_ID = GroupCurrent;
                grUpdate.InsertUpdateFull(grCollection);
                ShowMessage("Lưu thành công", false, false);
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
    }
}
