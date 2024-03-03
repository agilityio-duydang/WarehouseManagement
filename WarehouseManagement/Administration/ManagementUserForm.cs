using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Company.WM.BLL.Administration;

namespace WarehouseManagement.Administration
{
    public partial class ManagementUserForm : BaseForm
    {
        public ManagementUserForm()
        {
            InitializeComponent();
        }

        private void ManagementUserForm_Load(object sender, EventArgs e)
        {

            //if ((((SiteIdentity)MainForm.QuanTri.Identity).user.Role).ToString() == "True")
            //{
                this.Show();
                BindData();
            //}
            //else
            //{
            //    MessageBox.Show("Chức năng này chỉ dành cho tài khoản quản trị. ", "Thông báo hệ thống", MessageBoxButtons.OK);
            //}
        }
        private void BindData()
        {
            try
            {
                dgList.Refetch();
                dgList.DataSource = User.SelectCollectionAll();
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Có lỗi trong quá trình xử lý thông tin :\n " + ex.Message, "Thông báo hệ thống", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
               // ShowMessage("Có lỗi trong quá trình xử lý thông tin \r\n" + ex.Message, false, true);
            }
        }
        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["ID"].Value);
                    User user = User.Load(id);
                    UserForm f = new UserForm();
                    f.user = user;
                    f.ShowDialog(this);
                }
                BindData();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Có lỗi trong quá trình xử lý thông tin :\n " + ex.Message, "Thông báo hệ thống", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                //ShowMessage("Có lỗi trong quá trình xử lý thông tin \r\n" + ex.Message, false, true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GridEXSelectedItemCollection items = dgList.SelectedItems;
                List<User> ItemColl = new List<User>();
                if (dgList.GetRows().Length < 0) return;
                if (items.Count <= 0) return;
                if (ShowMessage("Bạn có muốn xóa User này không ?", true,false) == "Yes")
                {
                //if (MessageBox.Show("Bạn có muốn xóa User này không ?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                    foreach (GridEXSelectedItem i in items)
                    {
                        if (i.RowType == RowType.Record)
                        {
                            ItemColl.Add((User)i.GetRow().DataRow);
                        }

                    }
                    foreach (User item in ItemColl)
                    {
                        if (item.ID > 0)
                        {
                            //if (item.UserName==((SiteIdentity)MainForm.QuanTri.Identity).user.UserName)
                            //{
                            //    ShowMessage("Không thể xóa tài khoản đang đăng nhập hiện tại !", false, false);
                            //    //MessageBox.Show("Không thể xóa tài khoản đang đăng nhập hiện tại !", "Thông báo hệ thống", MessageBoxButtons.OK);
                            //    return;
                            //}
                            //else
                            //{
                            //    item.Delete();
                            //}                         
                        }
                    }

                }
                ShowMessage("Xóa thành công", false, false);
                //MessageBox.Show("Xóa thành công", "Thông báo hệ thống", MessageBoxButtons.OK);
                BindData();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Có lỗi trong quá trình xử lý thông tin :\n " + ex.Message, "Thông báo hệ thống", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                //ShowMessage("Có lỗi trong quá trình xử lý thông tin \r\n" + ex.Message, false, true);
            }
        }

        private void cmdMain_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            switch (e.Command.Key)
            {
                case "cmdAdd":
                    this.CreateUser();
                    break;
                case "cmdRole":
                    this.CreateRole();
                    break;
                default:
                    break;
            }
        }

        private void CreateRole()
        {
            ManagementUserRoleForm f = new ManagementUserRoleForm();
            f.ShowDialog(this);
        }

        private void CreateUser()
        {
            UserForm f = new UserForm();
            f.isAdd = true;
            f.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
