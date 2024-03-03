using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using WarehouseManagement;

namespace WarehouseManagement
{
    public partial class LoginRoleForm : BaseForm
    {
        public bool IsReady = false;
        public static bool IsSuccess = false;
        public LoginRoleForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = GetMD5Value(txtPassword.Text);
            bool isValid = txtUserName.Text.Equals("Administrator") && password == "7b337545e91f114e9f2fec99ea3c3400";
            if (isValid)
            {
                IsSuccess = true;
                this.Close();
            }
            else
            {
                IsSuccess = false;
                ShowMessage("Đăng nhập không thành công", false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            IsSuccess = false;
            this.Close();
        }
        public static string GetMD5Value(string data)
        {

            byte[] DataToHash = Encoding.ASCII.GetBytes(data);
            return BitConverter.ToString(((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(DataToHash)).Replace("-", "").ToLower();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
