using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using WarehouseManagement;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class Login : BaseForm
    {
        public bool IsLogin = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GlobalSettings.Refreskey();
            txtUserName.Text = "Administrator";
            txtPassword.Text = "300588";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                MainForm.EcsQuanTri = ECSPrincipal.ValidateLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (MainForm.EcsQuanTri != null)
                {
                    //
                    User user = User.Load(((SiteIdentity)MainForm.EcsQuanTri.Identity).user.ID);
                    user.DataBase = GlobalSettings.DATABASE_NAME;
                    user.Update();

                    user = User.Load(((SiteIdentity)MainForm.EcsQuanTri.Identity).user.ID);
                    user.HostName = System.Environment.MachineName;
                    user.IP = GlobalSettings.GetLocalIPAddress();
                    user.DataBase = GlobalSettings.DATABASE_NAME;
                    user.Update();
                    MainForm.isLoginSuccess = true;
                    this.Close();
                }
                else
                {
                    ShowMessage("Sai tên đăng nhập hoặc mật khẩu", false, true);
                    //MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ", "Thông báo hệ thống", MessageBoxButtons.OK);
                    MainForm.isLoginSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtUserName, errorProvider, "Tên đăng nhập ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtPassword, errorProvider, "Mật khẩu ", isOnlyWarning);
            return isValid;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnLogin_Click(null,null);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!MainForm.isLoginSuccess)
            {
                Application.Exit();
            }
        }

        private void linkConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigConecionForm f = new ConfigConecionForm();
            f.ShowDialog(this);
        }
    }
}
