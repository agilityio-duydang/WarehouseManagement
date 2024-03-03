using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class ConfigSystemForm : BaseForm
    {
        public ConfigSystemForm()
        {
            InitializeComponent();
        }

        private void ConfigSystemForm_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalSettings.Refreskey();
                txtTenCongTy.Text = GlobalSettings.COMPANYNAME;
                txtDiaChi.Text = GlobalSettings.ADDRESS;
                txtSoDienThoai.Text = GlobalSettings.PHONENUMBER;
                txtLoaiPhieu.Text = GlobalSettings.LOAIPHIEU;
                txtHoaDon.Text = GlobalSettings.HOADON;
                txtTenThue.Text = GlobalSettings.TENTHUE;
                txtTenNhanVien.Text = GlobalSettings.TENNHANVIEN;
                txtEmail.Text = GlobalSettings.EMAIL;
                chkPirnt.Checked = GlobalSettings.PREVIEW;
                txtNote1.Text = GlobalSettings.NOTE1;
                txtNote2.Text = GlobalSettings.NOTE2;
                txtNote3.Text = GlobalSettings.NOTE3;
                txtNote4.Text = GlobalSettings.NOTE4;
                txtNote5.Text = GlobalSettings.NOTE5;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtTenCongTy, errorProvider, "Tên nhà hàng", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDiaChi, errorProvider, "Địa chỉ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtSoDienThoai, errorProvider, "Số điện thoại", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtLoaiPhieu, errorProvider, "Phiếu tạm tính", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtHoaDon, errorProvider, "Phiếu thanh toán", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtTenNhanVien, errorProvider, "Tên nhân viên", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtTenThue, errorProvider, "Tên thuế", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtEmail, errorProvider, "Email", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;

                ConfigConecionForm.SaveNodeXmlAppSettings("COMPANYNAME", txtTenCongTy.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("ADDRESS", txtDiaChi.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("PHONENUMBER", txtSoDienThoai.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("LOAIPHIEU", txtLoaiPhieu.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("HOADON", txtHoaDon.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("TENNHANVIEN", txtTenNhanVien.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("TENTHUE", txtTenThue.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("EMAIL", txtEmail.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("PREVIEW", chkPirnt.Checked);
                ConfigConecionForm.SaveNodeXmlAppSettings("NOTE1", txtNote1.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("NOTE2", txtNote2.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("NOTE3", txtNote3.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("NOTE4", txtNote4.Text.Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("NOTE5", txtNote5.Text.Trim());
                ShowMessage("Lưu thông tin thành công", false, false);
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
    }
}
