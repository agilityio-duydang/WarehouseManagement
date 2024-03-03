﻿using System;
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
    public partial class ProductForm : BaseForm
    {
        public HangHoa hanghoa;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void LoadCategoty()
        {
            try
            {
                cbbCategory.DataSource = NhomHangHoa.SelectAll().Tables[0];
                cbbCategory.DisplayMember = "TenNhom";
                cbbCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategoty();
                if (hanghoa == null)
                {
                    hanghoa = new HangHoa();
                    txtMaHangHoa.Text = GetMaHangHoa();
                }
                else
                {
                    SetData();
                }
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
                hanghoa.MaHangHoa = txtMaHangHoa.Text.Trim();
                hanghoa.TenHangHoa = textInfo.ToTitleCase((txtTenHangHoa.Text.Trim().ToLower()));
                hanghoa.NhomHangHoaId = Convert.ToInt32(cbbCategory.SelectedValue);
                hanghoa.DonGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text.Replace(" ₫", ""));
                hanghoa.DonGiaBan = Convert.ToDecimal(txtDonGiaBan.Text.Replace(" ₫", ""));
                hanghoa.DonViTinh = textInfo.ToTitleCase(txtDonViTinh.Text.Trim().ToLower());
                hanghoa.GhiChu = txtGhiChu.Text.ToString().Trim();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void SetData()
        {
            try
            {
                txtMaHangHoa.Text = hanghoa.MaHangHoa;
                txtTenHangHoa.Text = hanghoa.TenHangHoa;
                cbbCategory.SelectedValue = hanghoa.NhomHangHoaId;
                txtDonGiaNhap.Text = hanghoa.DonGiaNhap.ToString();
                txtDonGiaBan.Text = hanghoa.DonGiaBan.ToString();
                txtDonViTinh.Text = hanghoa.DonViTinh;
                txtGhiChu.Text = hanghoa.GhiChu.ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtMaHangHoa, errorProvider, "Mã hàng hoá", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtTenHangHoa, errorProvider, "Tên hàng hoá", isOnlyWarning);
            isValid &= ValidateControl.ValidateChoose(cbbCategory, errorProvider, "Nhóm hàng hoá", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDonGiaNhap, errorProvider, "Đơn giá nhập", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDonGiaBan, errorProvider, "Đơn giá bán", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDonViTinh, errorProvider, "Đơn vị tính", isOnlyWarning);
            return isValid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                GetData();
                hanghoa.InsertUpdate();
                XuatNhapTon XuatNhapTon = new XuatNhapTon();
                XuatNhapTon.MaHangHoa = hanghoa.MaHangHoa;
                XuatNhapTon.TenHangHoa = hanghoa.TenHangHoa;
                XuatNhapTon.NhomHangHoaId = hanghoa.NhomHangHoaId;
                XuatNhapTon.DonGiaBan = hanghoa.DonGiaBan;
                XuatNhapTon.DonGiaNhap = hanghoa.DonGiaNhap;
                XuatNhapTon.DonViTinh = hanghoa.DonViTinh;
                XuatNhapTon.GhiChu = hanghoa.GhiChu;
                XuatNhapTon.InsertUpdate();
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

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                GetData();
                hanghoa.InsertUpdate();
                XuatNhapTon XuatNhapTon = new XuatNhapTon();
                XuatNhapTon.MaHangHoa = hanghoa.MaHangHoa;
                XuatNhapTon.TenHangHoa = hanghoa.TenHangHoa;
                XuatNhapTon.NhomHangHoaId = hanghoa.NhomHangHoaId;
                XuatNhapTon.DonGiaBan = hanghoa.DonGiaBan;
                XuatNhapTon.DonGiaNhap = hanghoa.DonGiaNhap;
                XuatNhapTon.DonViTinh = hanghoa.DonViTinh;
                XuatNhapTon.GhiChu = hanghoa.GhiChu;
                XuatNhapTon.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                hanghoa = new HangHoa();
                txtMaHangHoa.Text = GetMaHangHoa();
                txtTenHangHoa.Text = String.Empty;
                txtDonGiaNhap.Text = String.Empty;
                txtDonGiaBan.Text = String.Empty;
                txtDonViTinh.Text = String.Empty;
                txtGhiChu.Text = String.Empty;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private string GetMaHangHoa()
        {
            try
            {
                string MaHangHoa = string.Empty;
                List<HangHoa> HangHoaCollection = HangHoa.SelectCollectionDynamic("1=1", "MaHangHoa ASC");
                if (HangHoaCollection.Count == 0)
                {
                    MaHangHoa = "SP000001";
                }
                else
                {
                    var LastHangHoa = HangHoaCollection.Last();
                    var NumberHangHoa = Convert.ToInt32(LastHangHoa.MaHangHoa.Substring(2, 6));
                    if (NumberHangHoa >= 0 && NumberHangHoa < 9)
                    {
                        MaHangHoa = "SP00000" + (NumberHangHoa + 1);
                    }
                    else if (NumberHangHoa >= 9 && NumberHangHoa < 99)
                    {
                        MaHangHoa = "SP0000" + (NumberHangHoa + 1);
                    }
                    else if (NumberHangHoa >= 99 && NumberHangHoa < 999)
                    {
                        MaHangHoa = "SP000" + (NumberHangHoa + 1);
                    }
                    else if (NumberHangHoa >= 999 && NumberHangHoa < 9999)
                    {
                        MaHangHoa = "SP00" + (NumberHangHoa + 1);
                    }
                    else if (NumberHangHoa >= 9999 && NumberHangHoa < 99999)
                    {
                        MaHangHoa = "SP0" + (NumberHangHoa + 1);
                    }
                    else if (NumberHangHoa >= 99999 && NumberHangHoa < 999999)
                    {
                        MaHangHoa = "SP" + (NumberHangHoa + 1);
                    }
                }
                return MaHangHoa;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }
    }
}