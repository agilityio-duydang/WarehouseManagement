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

namespace WarehouseManagement
{
    public partial class ChangePassword : BaseForm
    {
        public User user;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtPasswordOld.Text.Length == 0)
                //{
                //    ShowMessage("Nhập mật khẩu cũ", false, false);
                //    //MessageBox.Show("Nhập mật khẩu cũ ", "Thông báo hệ thống", MessageBoxButtons.OK);
                //    return;
                //}
                if (!ValidateForm(false))
                    return;
                if (user.Password  != EncryptPassword(txtPasswordOld.Text.Trim()))
                {
                    ShowMessage("Mật khẩu cũ không đúng", false, false);
                    //MessageBox.Show("Mật khẩu cũ không đúng ", "Thông báo hệ thống", MessageBoxButtons.OK);
                    return;                    
                }
                //if (txtPasswordNew.Text.Length == 0)
                //{
                //    ShowMessage("Nhập mật khẩu mới", false, false);
                //    //MessageBox.Show("Nhập mật khẩu mới ", "Thông báo hệ thống", MessageBoxButtons.OK);
                //    return;
                //}
                if (txtPasswordNew.Text.Trim().Length > 0)
                {
                    if (txtPasswordNew.Text.Trim().ToUpper() != txtRePassword.Text.Trim().ToUpper())
                    {
                        ShowMessage("Nhập mật khẩu không giống nhau", false, false);
                        //MessageBox.Show("Nhập mật khẩu không giống nhau ", "Thông báo hệ thống", MessageBoxButtons.OK);
                        return;
                    }
                }
                user.Password = EncryptPassword(txtPasswordNew.Text.Trim());
                user.Update();
                ShowMessage("Thay đổi mật khẩu thành công", false, false);
                //MessageBox.Show("Thay đổi mật khẩu thành công ", "Thông báo hệ thống", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                //ShowMessage("Có lỗi trong quá trình xử lý thông tin \r\n" + ex.Message, false, true);
                //MessageBox.Show("Lỗi\n " + ex.Message, "Thông báo hệ thống", MessageBoxButtons.OK);
            }
        }
        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtPasswordOld, errorProvider, "Mật khẩu cũ ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtPasswordNew, errorProvider, "Mật khẩu mới ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtRePassword, errorProvider, "Mật khẩu mới nhập lại ", isOnlyWarning);
            return isValid;
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
