using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using System.Globalization;

namespace WarehouseManagement
{
    public partial class ReceiptsTypeForm : BaseForm
    {
        public LoaiThu LoaiThu;
        public ReceiptsTypeForm()
        {
            InitializeComponent();
        }

        private void ReceiptsTypeForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (LoaiThu != null)
                {
                    txtLoaiThu.Text = LoaiThu.Ten;
                    txtMoTa.Text = LoaiThu.MoTa;
                }
                else
                {
                    LoaiThu = new LoaiThu();
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
            isValid &= ValidateControl.ValidateNull(txtLoaiThu, errorProvider, "Loại thu", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                if (LoaiThu.Id == 0)
                {
                    List<LoaiThu> LoaiThuCollection = LoaiThu.SelectCollectionAll();
                    if (LoaiThuCollection.Any(x => x.Ten.ToLower().Trim() == txtLoaiThu.Text.ToLower().Trim()))
                    {
                        errorProvider.SetError(txtLoaiThu, "Tên loại thu đã tồn tại");
                        txtLoaiThu.Focus();
                        txtLoaiThu.BackColor = System.Drawing.SystemColors.Info;
                        return;
                    }
                }
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                LoaiThu.Ten = textInfo.ToTitleCase(txtLoaiThu.Text.Trim().ToLower());
                LoaiThu.MoTa = textInfo.ToTitleCase(txtMoTa.Text.Trim().ToLower());
                LoaiThu.InsertUpdate();
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
    }
}
