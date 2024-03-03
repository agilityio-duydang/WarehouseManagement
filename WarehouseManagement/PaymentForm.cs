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
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class PaymentForm : BaseForm
    {
        public Payment Payment;
        public User User;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadCategoty();
            if (Payment != null)
            {
                txtThoiGian.Value = Payment.ThoiGian;
                txtMaPhieu.Text = Payment.MaPhieu;
                txtNguoiNhan.Text = Payment.NguoiNhan;
                cbbLoaiChi.SelectedValue = Payment.PaymentTypeId;
                txtGhiChu.Text = Payment.GhiChu;
                txtGiaTri.Text = Payment.GiaTri.ToString();
                btnSave.Enabled = false;
                btnSaveAndNew.Enabled = false;
            }
            else
            {
                Payment = new Payment();
                txtMaPhieu.Text = GetMaPhieu();
            }
        }

        private string GetMaPhieu()
        {
            try
            {
                string MaPhieu = string.Empty;
                List<Payment> PaymentCollection = Payment.SelectCollectionAll();
                if (PaymentCollection.Count == 0)
                {
                    MaPhieu = "PC0000000001";
                }
                else
                {
                    var LastPayment = PaymentCollection.Last();
                    var NumberPhieu = Convert.ToInt32(LastPayment.MaPhieu.Substring(2, 10));
                    if (NumberPhieu >= 0 && NumberPhieu < 9)
                    {
                        MaPhieu = "PC000000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 9 && NumberPhieu < 99)
                    {
                        MaPhieu = "PC00000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 99 && NumberPhieu < 999)
                    {
                        MaPhieu = "PC0000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 999 && NumberPhieu < 9999)
                    {
                        MaPhieu = "PC000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 9999 && NumberPhieu < 99999)
                    {
                        MaPhieu = "PC00000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 99999 && NumberPhieu < 999999)
                    {
                        MaPhieu = "PC0000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 999999 && NumberPhieu < 9999999)
                    {
                        MaPhieu = "PC000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 9999999 && NumberPhieu < 99999999)
                    {
                        MaPhieu = "PC00" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 99999999 && NumberPhieu < 999999999)
                    {
                        MaPhieu = "PC0" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 999999999 && NumberPhieu < 9999999999)
                    {
                        MaPhieu = "PC" + (NumberPhieu + 1);
                    }
                }
                return MaPhieu;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void LoadCategoty()
        {
            try
            {
                cbbLoaiChi.DataSource = PaymentType.SelectAll().Tables[0];
                cbbLoaiChi.DisplayMember = "Ten";
                cbbLoaiChi.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void GetData()
        {
            try
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                Payment.ThoiGian = txtThoiGian.Value;
                Payment.MaPhieu = txtMaPhieu.Text;
                Payment.NguoiNhan = textInfo.ToTitleCase(txtNguoiNhan.Text.Trim().ToLower());
                Payment.PaymentTypeId = Convert.ToInt64(cbbLoaiChi.SelectedValue);
                Payment.GhiChu = textInfo.ToTitleCase(txtGhiChu.Text.Trim().ToLower());
                Payment.GiaTri = Convert.ToDecimal(txtGiaTri.Text.Replace(" ₫", ""));
                Payment.NhanVienId = User.ID;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateDate(txtThoiGian, errorProvider, "Thời gian", isOnlyWarning);
            isValid &= ValidateControl.ValidateChoose(cbbLoaiChi, errorProvider, "Loại chi", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtGiaTri, errorProvider, "Giá trị", isOnlyWarning);
            return isValid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;

                GetData();
                Payment.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                Helpers Helpers = new Helpers();
                Helpers.SendEmmailPayment(Payment);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;

                GetData();
                Payment.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                Payment = new Payment();
                txtNguoiNhan.Text = String.Empty;
                txtGhiChu.Text = String.Empty;
                txtGiaTri.Text = String.Empty;
                Helpers Helpers = new Helpers();
                Helpers.SendEmmailPayment(Payment);
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
