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
    public partial class UserGroupForm : BaseForm
    {
        public GROUPS group = new GROUPS();
        public UserGroupForm()
        {
            InitializeComponent();
        }

        private void UserGroupForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtHoTen.Text = group.MO_TA;
                txtTenNhom.Text = group.TEN_NHOM;
                User user = new User();
                List<User> collection = User.SelectCollectionAll();
                group.LoadUserList();
                for (int i = 0; i < group.UserList.Count; ++i)
                {
                    foreach (User row in collection)
                    {
                        if (row.ID.ToString() == group.UserList[i].ToString())
                        {
                            row.Check = true;
                            break;
                        }
                    }
                }
                dgList.DataSource = collection;
                if (group.MA_NHOM > 0)
                {
                    if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.UpdateGroup)))
                    {
                        btnUpdate.Visible = false;
                    }
                }
                else
                {
                    if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.CreateGroup)))
                    {
                        btnUpdate.Visible = false;
                    }
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
                if (e.Row.Cells["CheckData"].Value.ToString() == "True")
                {
                    e.Row.CheckState = RowCheckState.Checked;
                }
                else
                    e.Row.CheckState = RowCheckState.Unchecked;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtTenNhom, errorProvider, "Tên nhóm ", isOnlyWarning);
            return isValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                if (group.CheckGroupName(txtTenNhom.Text.Trim()))
                {
                    ShowMessage("Tên nhóm người dùng đã có . Bạn hãy nhập tên khác ", false, false);
                    return;
                }
                group.TEN_NHOM = txtTenNhom.Text.Trim();
                group.MO_TA = txtHoTen.Text.Trim();
                group.UserList.Clear();
                foreach (GridEXRow row in dgList.GetCheckedRows())
                {
                    User user = (User)row.DataRow;
                    group.UserList.Add(user.ID);
                }
                group.InsertUpdateFull();
                this.Close();
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
