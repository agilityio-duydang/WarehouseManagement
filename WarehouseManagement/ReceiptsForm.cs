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
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class ReceiptsForm : BaseForm
    {
        public PhieuThu PhieuThu;
        public User User;
        public ReceiptsForm()
        {
            InitializeComponent();
        }

        private void ReceiptsForm_Load(object sender, EventArgs e)
        {
            LoadCategoty();
            if (PhieuThu != null)
            {
                txtThoiGian.Value = PhieuThu.ThoiGian;
                txtMaPhieu.Text = PhieuThu.MaPhieu;
                txtNguoiThu.Text = PhieuThu.NguoiThu;
                cbbLoaiThu.SelectedValue = PhieuThu.LoaiThuId;
                txtGhiChu.Text = PhieuThu.GhiChu;
                txtGiaTri.Text = PhieuThu.GiaTri.ToString();
                btnSave.Enabled = false;
                btnSaveAndNew.Enabled = false;
            }
            else
            {
                PhieuThu = new PhieuThu();
                txtMaPhieu.Text = GetMaPhieu();
            }
        }

        private string GetMaPhieu()
        {
            try
            {
                string MaPhieu = string.Empty;
                List<PhieuThu> PhieuThuCollection = PhieuThu.SelectCollectionAll();
                if (PhieuThuCollection.Count == 0)
                {
                    MaPhieu = "PT0000000001";
                }
                else
                {
                    var LastPhieuThu = PhieuThuCollection.Last();
                    var NumberPhieu = Convert.ToInt32(LastPhieuThu.MaPhieu.Substring(2, 10));
                    if (NumberPhieu >= 0 && NumberPhieu < 9)
                    {
                        MaPhieu = "PT000000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 9 && NumberPhieu < 99)
                    {
                        MaPhieu = "PT00000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 99 && NumberPhieu < 999)
                    {
                        MaPhieu = "PT0000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 999 && NumberPhieu < 9999)
                    {
                        MaPhieu = "PT000000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 9999 && NumberPhieu < 99999)
                    {
                        MaPhieu = "PT00000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 99999 && NumberPhieu < 999999)
                    {
                        MaPhieu = "PT0000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 999999 && NumberPhieu < 9999999)
                    {
                        MaPhieu = "PT000" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 9999999 && NumberPhieu < 99999999)
                    {
                        MaPhieu = "PT00" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 99999999 && NumberPhieu < 999999999)
                    {
                        MaPhieu = "PT0" + (NumberPhieu + 1);
                    }
                    else if (NumberPhieu >= 999999999 && NumberPhieu < 9999999999)
                    {
                        MaPhieu = "PT" + (NumberPhieu + 1);
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
                cbbLoaiThu.DataSource = LoaiThu.SelectAll().Tables[0];
                cbbLoaiThu.DisplayMember = "Ten";
                cbbLoaiThu.ValueMember = "Id";
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
                PhieuThu.ThoiGian = txtThoiGian.Value;
                PhieuThu.MaPhieu = txtMaPhieu.Text;
                PhieuThu.NguoiThu = textInfo.ToTitleCase(txtNguoiThu.Text.Trim().ToLower());
                PhieuThu.LoaiThuId = Convert.ToInt64(cbbLoaiThu.SelectedValue);
                PhieuThu.GhiChu = textInfo.ToTitleCase(txtGhiChu.Text.Trim().ToLower());
                PhieuThu.GiaTri = Convert.ToDecimal(txtGiaTri.Text.Replace(" ₫", ""));
                PhieuThu.NhanVienId = User.ID;
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
            isValid &= ValidateControl.ValidateChoose(cbbLoaiThu, errorProvider, "Loại thu", isOnlyWarning);
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
                PhieuThu.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                Helpers Helpers = new Helpers();
                Helpers.SendEmmailReceipts(PhieuThu);
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
                PhieuThu.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                PhieuThu = new PhieuThu();
                txtNguoiThu.Text = String.Empty;
                txtGhiChu.Text = String.Empty;
                txtGiaTri.Text = String.Empty;
                Helpers Helpers = new Helpers();
                Helpers.SendEmmailReceipts(PhieuThu);
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
