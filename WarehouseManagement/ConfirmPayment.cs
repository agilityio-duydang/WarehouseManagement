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
using Janus.Windows.GridEX;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class ConfirmPayment : BaseForm
    {
        public BanHang BanHang;
        public User user;
        public int ThueGTGT;
        public ConfirmPayment()
        {
            InitializeComponent();
        }

        private void ConfirmPayment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomer();
                cbbGiamGia.SelectedIndex = 0;
                if (BanHang != null)
                {
                    SetProducts();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void SetProducts()
        {
            try
            {
                dgList.Refresh();
                dgList.DataSource = BanHang.HangHoaCollection;
                dgList.Refetch();
                if (BanHang.HangHoaCollection.Count > 0)
                {
                    decimal ToTalMoney = 0;
                    decimal taxMoney = 0;
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    foreach (var item in BanHang.HangHoaCollection)
                    {
                        ToTalMoney += item.ThanhTienBan;
                    }
                    lblTongTien.Text = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    if (ThueGTGT > 0)
                    {
                        taxMoney = ToTalMoney * ThueGTGT / 100;
                        ToTalMoney = ToTalMoney + taxMoney;
                    }
                    string TongTien = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    string TaxMoney = taxMoney == 0 ? "0" : decimal.Parse(taxMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    txtKhachCanTra.Text = TongTien;
                    txtKhachThanhToan.Text = TongTien;
                    txtTienThue.Text = TaxMoney;
                    cbbKhachHang.SelectedValue = BanHang.KhachHangId;
                }
                else
                {
                    lblTongTien.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadCustomer()
        {
            try
            {
                cbbKhachHang.DataSource = KhachHang.SelectAll().Tables[0];
                cbbKhachHang.DisplayMember = "TenKhachHang";
                cbbKhachHang.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (BanHang != null)
                {
                    if (BanHang.HangHoaCollection.Count() > 0)
                    {
                        K80PrintTemplates f = new K80PrintTemplates();
                        f.BanHang = BanHang;
                        f.GiamGia = Convert.ToInt32(txtPercent.Text);
                        f.TriGiaGiam = Convert.ToDecimal(txtTriGia.Text.Replace(" ₫", ""));
                        f.TienThue = Convert.ToDecimal(txtTienThue.Text.Replace(" ₫", ""));
                        f.TongThanhToan = Convert.ToDecimal(txtKhachCanTra.Text);
                        f.ThueGTGT = ThueGTGT;
                        f.BindReport();
                        if (GlobalSettings.PREVIEW)
                        {
                            f.ShowPreviewDialog();
                        }
                        else
                        {
                            f.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (BanHang.HangHoaCollection.Count() > 0)
                {
                    if (ShowMessage("Bạn có chắc chắn muốn thanh toán hoá đơn này không?", true, false) == "Yes")
                    {
                        HoaDon HoaDon = new HoaDon();
                        HoaDon.MaHoaDon = GetMaHoaDon();
                        HoaDon.BanHangId = BanHang.Id;
                        HoaDon.KhachHangId = BanHang.KhachHangId;
                        HoaDon.NhanVienId = BanHang.NhanVienId;
                        HoaDon.GhiChu = BanHang.GhiChu;
                        HoaDon.ThoiGianTao = BanHang.ThoiGianTao == DateTime.MinValue ? DateTime.Now : BanHang.ThoiGianTao;
                        HoaDon.ThoiGianThanhToan = DateTime.Now;
                        HoaDon.TongTienHang = Convert.ToDecimal(lblTongTien.Text);
                        HoaDon.ThueSuat = ThueGTGT;
                        HoaDon.GiamGia = Convert.ToInt32(txtPercent.Text);
                        HoaDon.TriGiaGiam = Convert.ToDecimal(txtTriGia.Text.Replace(" ₫", ""));
                        HoaDon.TienThue = Convert.ToDecimal(txtTienThue.Text.Replace(" ₫", ""));
                        HoaDon.TongTien = Convert.ToDecimal(txtKhachCanTra.Text);
                        int i = 1;
                        HoaDon.HangHoaCollection = new List<HoaDon_HangHoa>();
                        foreach (var item in BanHang.HangHoaCollection)
                        {
                            HoaDon_HangHoa hanghoa = new HoaDon_HangHoa();
                            hanghoa.STT = i;
                            hanghoa.MaHangHoa = item.MaHangHoa;
                            hanghoa.TenHangHoa = item.TenHangHoa;
                            hanghoa.NhomHangHoaId = item.NhomHangHoaId;
                            hanghoa.SoLuong = item.SoLuong;
                            hanghoa.DonGiaBan = item.DonGiaBan;
                            hanghoa.DonGiaNhap = item.DonGiaNhap;
                            hanghoa.DonViTinh = item.DonViTinh;
                            hanghoa.ThanhTienBan = item.ThanhTienBan;
                            hanghoa.ThanhTienNhap = item.ThanhTienNhap;
                            i++;
                            HoaDon.HangHoaCollection.Add(hanghoa);
                        }
                        HoaDon.InsertUpdateFull();
                        UpdateInventory();
                        if (Convert.ToDecimal(lblTienThua.Text) < 0)
                        {
                            CongNoKhachHang CongNoKhachHang = new CongNoKhachHang();
                            CongNoKhachHang.ThoiGian = HoaDon.ThoiGianThanhToan;
                            CongNoKhachHang.KhachHangId = HoaDon.KhachHangId;
                            CongNoKhachHang.NhanVienId = HoaDon.NhanVienId;
                            CongNoKhachHang.TongTien = HoaDon.TongTienHang;
                            CongNoKhachHang.HoaDonId = HoaDon.Id;
                            CongNoKhachHang.ThueSuat = HoaDon.ThueSuat;
                            CongNoKhachHang.TongDaThanhToan = Convert.ToDecimal(txtKhachThanhToan.Text.Replace(" ₫", ""));
                            CongNoKhachHang.TongConNo = Convert.ToDecimal(lblTienThua.Text);
                            CongNoKhachHang.GhiChu = HoaDon.GhiChu;
                            CongNoKhachHang.InsertUpdate();
                        }
                        BanHang.DeleteFull();
                        BanHang = new BanHang();
                        BanHang.ThoiGianTao = DateTime.Now;
                        BanHang.NhanVienId = user.ID;
                        BanHang.KhachHangId = KhachHang.SelectCollectionAll().FirstOrDefault().Id;
                        BanHang.HangHoaCollection = new List<BanHang_HangHoa>();
                        SetProducts();
                        ShowMessage("Thanh toán thành công. ", false, false);
                        Helpers helper = new Helpers();
                        helper.SendEmmail(HoaDon);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private string GetMaHoaDon()
        {
            try
            {
                string MaHoaDon = string.Empty;
                List<HoaDon> HoaDonCollection = HoaDon.SelectCollectionAll();
                if (HoaDonCollection.Count == 0)
                {
                    MaHoaDon = "HD0000000001";
                }
                else
                {
                    var LastHoaDon = HoaDonCollection.Last();
                    var NumberHoaDon = Convert.ToInt32(LastHoaDon.MaHoaDon.Substring(2, 10));
                    if (NumberHoaDon >= 0 && NumberHoaDon < 9)
                    {
                        MaHoaDon = "HD000000000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 9 && NumberHoaDon < 99)
                    {
                        MaHoaDon = "HD00000000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 99 && NumberHoaDon < 999)
                    {
                        MaHoaDon = "HD0000000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 999 && NumberHoaDon < 9999)
                    {
                        MaHoaDon = "HD000000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 9999 && NumberHoaDon < 99999)
                    {
                        MaHoaDon = "HD00000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 99999 && NumberHoaDon < 999999)
                    {
                        MaHoaDon = "HD0000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 999999 && NumberHoaDon < 9999999)
                    {
                        MaHoaDon = "HD000" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 9999999 && NumberHoaDon < 99999999)
                    {
                        MaHoaDon = "HD00" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 99999999 && NumberHoaDon < 999999999)
                    {
                        MaHoaDon = "HD0" + (NumberHoaDon + 1);
                    }
                    else if (NumberHoaDon >= 999999999 && NumberHoaDon < 9999999999)
                    {
                        MaHoaDon = "HD" + (NumberHoaDon + 1);
                    }
                }
                return MaHoaDon;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void UpdateInventory()
        {
            try
            {
                foreach (var item in BanHang.HangHoaCollection)
                {
                    XuatNhapTon xuatNhapTon = new XuatNhapTon();
                    xuatNhapTon = XuatNhapTon.SelectCollectionDynamic("MaHangHoa = N'" + item.MaHangHoa + "'", "").FirstOrDefault();
                    if (!string.IsNullOrEmpty(xuatNhapTon.MaHangHoa))
                    {
                        xuatNhapTon.LuongBan += item.SoLuong;
                        xuatNhapTon.LuongTon = xuatNhapTon.LuongNhap - xuatNhapTon.LuongBan;
                        xuatNhapTon.ThanhTienBan = xuatNhapTon.LuongBan * xuatNhapTon.DonGiaBan;
                        xuatNhapTon.ThanhTienTon = xuatNhapTon.LuongTon * xuatNhapTon.DonGiaNhap;
                        xuatNhapTon.InsertUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void CaculatorInvoice()
        {
            try
            {
                decimal ToTalMoney = 0;
                decimal totalPercent = 0;
                decimal discountMoney = 0;
                decimal taxMoney = 0;
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                if (BanHang.HangHoaCollection.Count > 0)
                {
                    foreach (var item in BanHang.HangHoaCollection)
                    {
                        ToTalMoney += item.ThanhTienBan;
                    }
                }

                if (ThueGTGT > 0)
                {
                    taxMoney = ToTalMoney * ThueGTGT / 100;
                    ToTalMoney = ToTalMoney + taxMoney;
                }

                if (cbbGiamGia.SelectedValue.ToString() == "0")
                {
                    var percent = Convert.ToInt32(txtPercent.Text);
                    if (percent != 0)
                    {
                        totalPercent = ToTalMoney * percent / 100;
                        ToTalMoney = ToTalMoney - totalPercent;
                    }
                    string TotalPercent = totalPercent == 0 ? "0" : decimal.Parse(totalPercent.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    txtTriGia.Text = TotalPercent;
                }
                else
                {
                    discountMoney = Convert.ToDecimal(txtTriGia.Text.Replace(" ₫", ""));
                    if (discountMoney != 0)
                    {
                        ToTalMoney = ToTalMoney - discountMoney;
                    }
                    string DiscountMoney = discountMoney == 0 ? "0" : decimal.Parse(discountMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    txtTriGia.Text = DiscountMoney;
                }
                string TongTien = ToTalMoney == 0 ? "0" : decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                txtKhachCanTra.Text = TongTien;
                txtKhachThanhToan.Text = TongTien;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void cbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbGiamGia.SelectedValue.ToString() == "0")
                {
                    txtPercent.Enabled = true;
                    txtTriGia.ReadOnly = true;
                }
                else
                {
                    txtPercent.Enabled = false;
                    txtTriGia.ReadOnly = false;
                }
                CaculatorInvoice();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtTriGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculatorInvoice();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtTienThue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculatorInvoice();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtKhachThanhToan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                decimal castMoney = Convert.ToDecimal(txtKhachThanhToan.Text.Replace(" ₫", ""));
                decimal returnMoney = castMoney - Convert.ToDecimal(txtKhachCanTra.Text);
                string ReturnMoney = returnMoney == 0 ? "0" : decimal.Parse(returnMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                if (returnMoney >= 0)
                {
                    lblDeptOrReturn.Text = "Tiền thừa trả khách  : ";
                }
                else
                {
                    lblDeptOrReturn.Text = "Tính vào công nợ  : ";
                }
                lblTienThua.Text = ReturnMoney;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal SoLuong = (decimal)e.Row.Cells["SoLuong"].Value;
                    decimal DonGiaBan = (decimal)e.Row.Cells["DonGiaBan"].Value;
                    decimal ThanhTienBan = (decimal)e.Row.Cells["ThanhTienBan"].Value;
                    e.Row.Cells["SoLuong"].Text = ToTrimmedString(SoLuong);
                    e.Row.Cells["DonGiaBan"].Text = DonGiaBan.ToString("#,##0");
                    e.Row.Cells["ThanhTienBan"].Text = ThanhTienBan.ToString("#,##0");
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        public string ToTrimmedString(decimal num)
        {
            try
            {
                string str = num.ToString();
                string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                if (str.Contains(decimalSeparator))
                {
                    str = str.TrimEnd('0');
                    if (str.EndsWith(decimalSeparator))
                    {
                        str = str.Remove(str.Length - 1, 1);
                    }
                }
                return str;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
            return null;
        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbGiamGia.SelectedValue.ToString() == "0")
                {
                    var percent = Convert.ToInt32(txtPercent.Text);
                    if (percent >= 100)
                    {
                        txtPercent.Text = "100";
                    }
                }
                CaculatorInvoice();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
