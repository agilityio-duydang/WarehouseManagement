using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Company.WM.BLL;

namespace WarehouseManagement
{
    public partial class PaymentTypeForm : BaseForm
    {
        public PaymentType paymentType;
        public PaymentTypeForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtLoaiChi, errorProvider, "Loại chi", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                paymentType.Ten = textInfo.ToTitleCase(txtLoaiChi.Text.Trim().ToLower());
                paymentType.MoTa = textInfo.ToTitleCase(txtMoTa.Text.Trim().ToLower());
                paymentType.InsertUpdate();
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

        private void PaymentTypeForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (paymentType != null)
                {
                    txtLoaiChi.Text = paymentType.Ten;
                    txtMoTa.Text = paymentType.MoTa;
                }
                else
                {
                    paymentType = new PaymentType();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
