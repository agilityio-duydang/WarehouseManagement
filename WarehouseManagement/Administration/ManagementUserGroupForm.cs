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
    public partial class ManagementUserGroupForm : BaseForm
    {
        GROUPSCollection collection = new GROUPSCollection();
        GROUPS group = new GROUPS();
        public ManagementUserGroupForm()
        {
            InitializeComponent();
        }

        private void ManagementUserGroupForm_Load(object sender, EventArgs e)
        {
            try
            {
                collection = group.SelectCollectionAll();
                dgList.DataSource = collection;
                if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.CreateGroup)))
                {
                    cmdAdd.Enabled = Janus.Windows.UI.InheritableBoolean.False;
                }
                if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.DeleteGroup)))
                {
                    dgList.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
                GROUPS groupEdit = (GROUPS)e.Row.DataRow;
                UserGroupForm f = new UserGroupForm();
                f.group = groupEdit;
                f.ShowDialog(this);
                collection = group.SelectCollectionAll();
                dgList.DataSource = collection;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void cmdMain_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            try
            {
                if (e.Command.Key == "cmdAdd")
                {
                    UserGroupForm f = new UserGroupForm();
                    f.ShowDialog(this);
                    collection = group.SelectCollectionAll();
                    dgList.Refresh();
                    dgList.DataSource = collection;
                    dgList.Refetch();
                }
                else
                {
                    ManagementUserRoleForm f = new ManagementUserRoleForm();
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_DeletingRecord(object sender, Janus.Windows.GridEX.RowActionCancelEventArgs e)
        {
            try
            {
                if (ShowMessage("Bạn có muốn xóa nhóm người dùng này không ?", true, false) == "Yes")
                {
                    GROUPS g = (GROUPS)e.Row.DataRow;
                    g.LoadUserList();
                    if (g.CheckUserInGroup())
                    {
                        if (ShowMessage("Có người dùng nằm trong nhóm này. Bạn có muốn xóa không ?", true, false) == "Yes")
                        {
                            g.Delete();
                        }
                        else
                            e.Cancel = true;
                    }
                    else
                        g.Delete();
                }
                else
                    e.Cancel = true;
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
                if (ShowMessage("Bạn có muốn xóa nhóm người dùng này không ?", true, false) == "Yes")
                {
                    GridEXSelectedItemCollection items = dgList.SelectedItems;
                    foreach (GridEXSelectedItem i in items)
                    {
                        if (i.RowType == RowType.Record)
                        {
                            GROUPS g = (GROUPS)i.GetRow().DataRow;
                            g.LoadUserList();
                            if (g.CheckUserInGroup())
                            {
                                if (ShowMessage("Có người dùng nằm trong nhóm này. Bạn có muốn xóa không ?", true, false) == "Yes")
                                {
                                    g.Delete();
                                }
                            }
                            else
                                g.Delete();
                        }
                    }
                    ManagementUserGroupForm_Load(null, null);
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
    }
}
