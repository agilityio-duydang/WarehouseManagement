using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;

namespace WarehouseManagement
{
    public partial class CategoryForm : BaseForm
    {
        public NhomHangHoa nhomHangHoa;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtTenNhom, errorProvider, "Nhóm hàng hoá", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                nhomHangHoa.TenNhom = txtTenNhom.Text.Trim().ToUpper();
                nhomHangHoa.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (nhomHangHoa != null)
                {
                    txtTenNhom.Text = nhomHangHoa.TenNhom;
                }
                else
                {
                    nhomHangHoa = new NhomHangHoa();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
