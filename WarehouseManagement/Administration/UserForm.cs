using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Company.WM.BLL.Administration;
using Janus.Windows.GridEX;

namespace WarehouseManagement
{
    public partial class UserForm : BaseForm
    {
       public User user;
       public bool isAdd;
       public bool isChange;
       public bool isView;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.UpdateUser)))
                    {
                        btnUpdate.Enabled = false;
                    }
                    txtUserName.Text = user.UserName;
                    txtFullName.Text = user.FullName;
                    txtDiaChi.Text = user.DiaChi;
                    txtSoDienThoai.Text = user.SoDienThoai;
                    txtEmail.Text = user.Email;
                    if (Convert.ToBoolean(user.isAdmin))
                    {
                        chkIsAdmin.CheckState = CheckState.Checked;
                    }
                    grbAdd.Enabled = true;

                    user.LoadRoleList();
                    GROUPS g = new GROUPS();
                    GROUPSCollection collection = g.SelectCollectionAll();
                    for (int i = 0; i < user.RoleList.Count; ++i)
                    {
                        foreach (GROUPS row in collection)
                        {
                            if (row.MA_NHOM.ToString() == user.RoleList[i].ToString())
                            {
                                row.Check = true;
                                break;
                            }
                        }
                    }
                    dgList.DataSource = collection;
                    if (user.ID > 0)
                    {
                        if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.UpdateUser)))
                        {
                            btnUpdate.Enabled = false;
                        }
                    }
                    else
                    {
                        if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.CreateUser)))
                        {
                            btnUpdate.Enabled = false;
                        }
                    }
                    if (user.isAdmin)
                    {
                        txtUserName.ReadOnly = false;
                    }
                }
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
                if (user==null)
                {
                    user = new User();
                }
                if (!ValidateForm(false))
                    return;
                user.UserName = txtUserName.Text.Trim();
                user.FullName = txtFullName.Text.Trim();
                user.isAdmin = Convert.ToBoolean(chkIsAdmin.Checked);
                user.DiaChi = txtDiaChi.Text;
                user.SoDienThoai = txtSoDienThoai.Text;
                user.Email = txtEmail.Text;
                if (user.ID == 0)
                {
                    if (user.CheckUserName(txtUserName.Text.Trim()))
                    {
                        ShowMessage("Tên người dùng đã có .Bạn hãy nhập tên khác ", false, false);
                        return;
                    }
                    if (txtPasswordNew.Text.Trim().Length > 0)
                    {
                        if (txtPasswordNew.Text.Trim().ToUpper() != txtRePassword.Text.Trim().ToUpper())
                        {
                            ShowMessage("Nhập mật khẩu không giống nhau", false, false);
                            return;
                        }
                    }
                    user.Password = EncryptPassword(txtPasswordNew.Text.Trim());
                }
                else
                {
                    if (txtPasswordNew.Text.Trim().Length > 0)
                    {
                        if (txtPasswordNew.Text.Trim().ToUpper() != txtRePassword.Text.Trim().ToUpper())
                        {
                            ShowMessage("Nhập mật khẩu không giống nhau", false, false);
                            return;
                        }
                    }
                    user.Password = EncryptPassword(txtPasswordNew.Text.Trim());
                }
                user.RoleList.Clear();
                if (!user.isAdmin)
                {
                    foreach (GridEXRow row in dgList.GetCheckedRows())
                    {
                        GROUPS group = (GROUPS)row.DataRow;
                        user.RoleList.Add(group.MA_NHOM);
                    }
                }
                user.InsertUpdateFull();
                ShowMessage("Cập nhật thông tin thành công", false, false);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                //ShowMessage("Có lỗi trong quá trình xử lý thông tin \r\n" + ex.Message, false, true);
            }
        }
        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtFullName, errorProvider, "Tên người dùng ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDiaChi, errorProvider, "Địa chỉ ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtSoDienThoai, errorProvider, "Số điện thoại ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtUserName, errorProvider, "Tên đăng nhập ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtEmail, errorProvider, "Email ", isOnlyWarning);
            if (grbAdd.Enabled)
            {
                isValid &= ValidateControl.ValidateNull(txtPasswordNew, errorProvider, "Mật khẩu ", isOnlyWarning);
                isValid &= ValidateControl.ValidateNull(txtRePassword, errorProvider, "Mật khẩu nhập lại ", isOnlyWarning);
            }
            return isValid;
        }
        private void SaveNodeXmlAppSettings()
        {
            ConfigConecionForm.SaveNodeXmlAppSettings("NGAYSAOLUU", DateTime.Today.ToString("dd/MM/yyyy"));
        }
        public string EncryptPassword(string password)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes = encoding.GetBytes(password);

            // compute SHA-1 hash.
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytePassword = sha1.ComputeHash(hashBytes);
            string cryptPassword = Convert.ToBase64String(bytePassword);
            return cryptPassword;
        }

        private void dgListGroup_LoadingRow(object sender, RowLoadEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
