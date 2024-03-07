using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using Company.WM.BLL.Administration;
using Janus.Windows.GridEX;
using System.Globalization;

namespace WarehouseManagement
{
    public partial class PurchaseForm : BaseForm
    {
        public PhieuNhapKho PhieuNhapKho;
        public PhieuNhapKho_HangHoa PhieuNhapKhoHangHoa;
        public HangHoa HangHoa;
        public User user;
        public bool isAdd = true;
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void cbbMaHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                long id = Convert.ToInt64(cbbMaHangHoa.SelectedValue);
                HangHoa hanghoa = HangHoa.Load(id);
                HangHoa = hanghoa;
                if (hanghoa != null)
                {
                    txtTenHangHoa.Text = hanghoa.TenHangHoa;
                    txtDonViTinh.Text = hanghoa.DonViTinh;
                    txtSoLuong.Text = "1";
                    txtDonGia.Text = hanghoa.DonGiaNhap.ToString();
                    txtThanhTien.Text = hanghoa.DonGiaNhap.ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void SetPhieuNhapKho()
        {
            try
            {
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                txtMaPhieu.Text = PhieuNhapKho.MaPhieu;
                txtThoiGianTao.Text = PhieuNhapKho.ThoiGian.ToString("dd-MM-yyyy HH:mm");
                txtTenNhanVien.Text = User.Load(PhieuNhapKho.NhanVienId).FullName;
                cbbMaKho.Text = PhieuNhapKho.MaKho;
                txtTenKho.Text = PhieuNhapKho.TenKho;
                cbbNhaCungCap.SelectedValue = PhieuNhapKho.NhaCungCapId;
                txtTriGia.Text = PhieuNhapKho.GiamGia.ToString();
                txtChiPhiNhapHang.Text = PhieuNhapKho.ChiPhiNhap.ToString();
                txtTongTien.Text = decimal.Parse(PhieuNhapKho.TongTien.ToString()).ToString("#,###", cultureInfo.NumberFormat); //PhieuNhapKho.TongTien.ToString();
                txtThanhToan.Text = decimal.Parse(PhieuNhapKho.TongDaThanhToan.ToString()).ToString("#,###", cultureInfo.NumberFormat); //PhieuNhapKho.TongDaThanhToan.ToString();
                txtTienNo.Text = decimal.Parse(PhieuNhapKho.TongConNo.ToString()).ToString("#,###", cultureInfo.NumberFormat); //PhieuNhapKho.TongConNo.ToString();
                txtGhiChu.Text = PhieuNhapKho.GhiChu;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private string GetMaPhieuNhapKho()
        {
            try
            {
                string MaPhieuNhapKho = string.Empty;
                List<PhieuNhapKho> PhieuNhapKhoCollection = PhieuNhapKho.SelectCollectionAll();
                if (PhieuNhapKhoCollection.Count == 0)
                {
                    MaPhieuNhapKho = "PNK0000000001";
                }
                else
                {
                    var LastMaPhieuNhapKho = PhieuNhapKhoCollection.Last();
                    var NumberMaPhieuNhapKho = Convert.ToInt32(LastMaPhieuNhapKho.MaPhieu.Substring(3, 10));
                    if (NumberMaPhieuNhapKho >= 0 && NumberMaPhieuNhapKho < 9)
                    {
                        MaPhieuNhapKho = "PNK000000000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 9 && NumberMaPhieuNhapKho < 99)
                    {
                        MaPhieuNhapKho = "PNK00000000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 99 && NumberMaPhieuNhapKho < 999)
                    {
                        MaPhieuNhapKho = "PNK0000000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 999 && NumberMaPhieuNhapKho < 9999)
                    {
                        MaPhieuNhapKho = "PNK000000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 9999 && NumberMaPhieuNhapKho < 99999)
                    {
                        MaPhieuNhapKho = "PNK00000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 99999 && NumberMaPhieuNhapKho < 999999)
                    {
                        MaPhieuNhapKho = "PNK0000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 999999 && NumberMaPhieuNhapKho < 9999999)
                    {
                        MaPhieuNhapKho = "PNK000" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 9999999 && NumberMaPhieuNhapKho < 99999999)
                    {
                        MaPhieuNhapKho = "PNK00" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 99999999 && NumberMaPhieuNhapKho < 999999999)
                    {
                        MaPhieuNhapKho = "PNK0" + (NumberMaPhieuNhapKho + 1);
                    }
                    else if (NumberMaPhieuNhapKho >= 999999999 && NumberMaPhieuNhapKho < 9999999999)
                    {
                        MaPhieuNhapKho = "PNK" + (NumberMaPhieuNhapKho + 1);
                    }
                }
                return MaPhieuNhapKho;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void GetPhieuNhapKho()
        {
            try
            {
                PhieuNhapKho.MaPhieu = txtMaPhieu.Text;
                PhieuNhapKho.NhanVienId = user.ID;
                PhieuNhapKho.MaKho = cbbMaKho.Text.ToString();
                PhieuNhapKho.TenKho = txtTenKho.Text.ToString().Trim();
                PhieuNhapKho.NhaCungCapId = Convert.ToInt64(cbbNhaCungCap.SelectedValue);
                PhieuNhapKho.TongTien = Convert.ToDecimal(txtTongTien.Text);
                PhieuNhapKho.ChiPhiNhap = Convert.ToDecimal(txtChiPhiNhapHang.Text.Replace(" ₫", ""));
                PhieuNhapKho.GiamGia = Convert.ToDecimal(txtTriGia.Text.Replace(" ₫", ""));
                PhieuNhapKho.TongDaThanhToan = Convert.ToDecimal(txtThanhToan.Text.Replace(" ₫", ""));
                PhieuNhapKho.TongConNo = Convert.ToDecimal(txtTienNo.Text.Replace(" ₫", ""));
                PhieuNhapKho.GhiChu = txtGhiChu.Text;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadSupplier()
        {
            try
            {
                cbbNhaCungCap.DataSource = NhaCungCap.SelectAll().Tables[0];
                cbbNhaCungCap.DisplayMember = "TenNhaCungCap";
                cbbNhaCungCap.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadWareHouse()
        {
            try
            {
                cbbMaKho.DataSource = Kho.SelectAll().Tables[0];
                cbbMaKho.DisplayMember = "MaKho";
                cbbMaKho.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadProducts()
        {
            try
            {
                cbbMaHangHoa.DataSource = HangHoa.SelectAll().Tables[0];
                cbbMaHangHoa.DisplayMember = "TenHangHoa";
                cbbMaHangHoa.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
                LoadSupplier();
                LoadWareHouse();
                cbbGiamGia.SelectedIndex = 0;
                if (PhieuNhapKho != null)
                {
                    PhieuNhapKho.HangHoaCollection = PhieuNhapKho_HangHoa.SelectCollectionBy_PhieuNhapKhoId(PhieuNhapKho.Id);
                    txtTriGia.TextChanged -= new System.EventHandler(this.txtTriGia_TextChanged);
                    txtChiPhiNhapHang.TextChanged -= new System.EventHandler(this.txtChiPhiNhapHang_TextChanged);
                    SetPhieuNhapKho();
                    BindProducts();
                    txtTriGia.TextChanged += new System.EventHandler(this.txtTriGia_TextChanged);
                    txtChiPhiNhapHang.TextChanged += new System.EventHandler(this.txtChiPhiNhapHang_TextChanged);
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    PhieuNhapKho = new PhieuNhapKho();
                    PhieuNhapKho.HangHoaCollection = new List<PhieuNhapKho_HangHoa>();
                    PhieuNhapKho.ThoiGian = DateTime.Now;
                    PhieuNhapKho.NhanVienId = user.ID;
                    PhieuNhapKho.MaPhieu = GetMaPhieuNhapKho();
                    HangHoa = new HangHoa();
                    SetPhieuNhapKho();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void cbbMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                long id = Convert.ToInt64(cbbMaKho.SelectedValue);
                Kho Kho = Kho.Load(id);
                if (Kho != null)
                {
                    txtTenKho.Text = Kho.TenKho;
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
            isValid &= ValidateControl.ValidateChoose(cbbMaHangHoa, errorProvider, "Mã hàng hoá", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtTenHangHoa, errorProvider, "Tên hàng hoá", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtSoLuong, errorProvider, "Số lượng", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDonGia, errorProvider, "Đơn giá", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDonViTinh, errorProvider, "Đơn vị tính", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtThanhTien, errorProvider, "Thành tiền", isOnlyWarning);
            return isValid;
        }

        private void GetProduct()
        {
            try
            {
                if (PhieuNhapKhoHangHoa == null)
                    PhieuNhapKhoHangHoa = new PhieuNhapKho_HangHoa();
                PhieuNhapKhoHangHoa.MaHangHoa = HangHoa.MaHangHoa;
                PhieuNhapKhoHangHoa.TenHangHoa = txtTenHangHoa.Text.ToString().Trim();
                PhieuNhapKhoHangHoa.DonViTinh = txtDonViTinh.Text.ToString().Trim();
                PhieuNhapKhoHangHoa.NhomHangHoaId = HangHoa.NhomHangHoaId;
                PhieuNhapKhoHangHoa.SoLuong = Convert.ToDecimal(txtSoLuong.Text);
                PhieuNhapKhoHangHoa.DonGia = Convert.ToDecimal(txtDonGia.Text.Replace(" ₫", ""));
                PhieuNhapKhoHangHoa.ThanhTien = Convert.ToDecimal(txtThanhTien.Text.Replace(" ₫", ""));
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void BindProducts()
        {
            try
            {
                dgList.Refetch();
                dgList.DataSource = PhieuNhapKho.HangHoaCollection;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                GetProduct();
                if (PhieuNhapKho.HangHoaCollection.Count() == 0)
                {
                    PhieuNhapKho.HangHoaCollection.Add(PhieuNhapKhoHangHoa);
                }
                else
                {
                    foreach (PhieuNhapKho_HangHoa item in PhieuNhapKho.HangHoaCollection)
                    {
                        if (PhieuNhapKhoHangHoa.MaHangHoa == item.MaHangHoa)
                        {
                            item.TenHangHoa = PhieuNhapKhoHangHoa.TenHangHoa;
                            item.DonViTinh = PhieuNhapKhoHangHoa.DonViTinh;
                            item.SoLuong = PhieuNhapKhoHangHoa.SoLuong;
                            item.DonGia = PhieuNhapKhoHangHoa.DonGia;
                            item.ThanhTien = item.SoLuong * item.DonGia;
                            isAdd = false;
                        }
                    }

                    if (isAdd)
                        PhieuNhapKho.HangHoaCollection.Add(PhieuNhapKhoHangHoa);
                }
                BindProducts();
                PhieuNhapKhoHangHoa = new PhieuNhapKho_HangHoa();
                txtTenHangHoa.Text = String.Empty;
                txtDonViTinh.Text = String.Empty;
                txtSoLuong.Text = String.Empty;
                txtDonGia.Text = String.Empty;
                txtThanhTien.Text = String.Empty;
                cbbMaHangHoa.SelectedValue = String.Empty;
                isAdd = true;
                CaculatorInvoice();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateFormPNK(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateChoose(cbbMaKho, errorProvider, "Kho", isOnlyWarning);
            isValid &= ValidateControl.ValidateChoose(cbbNhaCungCap, errorProvider, "Nhà cung cấp", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFormPNK(false))
                    return;
                GetPhieuNhapKho();
                if (PhieuNhapKho.HangHoaCollection.Count() > 0)
                {
                    PhieuNhapKho.InsertUpdateFull();
                    ShowMessage("Lưu thông tin thành công", false, false);
                    PhieuNhapKho.HangHoaCollection = PhieuNhapKho_HangHoa.SelectCollectionBy_PhieuNhapKhoId(PhieuNhapKho.Id);
                    SetPhieuNhapKho();
                    BindProducts();
                    if (Convert.ToDecimal(txtTienNo.Text) < 0)
                    {
                        CongNoNhaCungCap CongNoNhaCungCap = new CongNoNhaCungCap();
                        CongNoNhaCungCap.ThoiGian = PhieuNhapKho.ThoiGian;
                        CongNoNhaCungCap.PhieuNhapKhoId = PhieuNhapKho.Id;
                        CongNoNhaCungCap.NhaCungCapId = PhieuNhapKho.NhaCungCapId;
                        CongNoNhaCungCap.NhanVienId = PhieuNhapKho.NhanVienId;
                        CongNoNhaCungCap.TongTien = PhieuNhapKho.TongTien;
                        CongNoNhaCungCap.ChiPhiNhap = PhieuNhapKho.ChiPhiNhap;
                        CongNoNhaCungCap.TongDaThanhToan = PhieuNhapKho.TongDaThanhToan;
                        CongNoNhaCungCap.TongConNo = PhieuNhapKho.TongConNo;
                        CongNoNhaCungCap.GiamGia = PhieuNhapKho.GiamGia;
                        CongNoNhaCungCap.GhiChu = PhieuNhapKho.GhiChu;
                        CongNoNhaCungCap.InsertUpdate();
                        UpdateInventory();
                    }
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    ShowMessage("Bạn chưa thêm hàng hoá vào phiếu nhập kho", false, false);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void UpdateInventory()
        {
            try
            {
                foreach (var item in PhieuNhapKho.HangHoaCollection)
                {
                    XuatNhapTon xuatNhapTon = new XuatNhapTon();
                    xuatNhapTon = XuatNhapTon.SelectCollectionDynamic("MaHangHoa = N'" + item.MaHangHoa + "'", "").FirstOrDefault();
                    if (!string.IsNullOrEmpty(xuatNhapTon.MaHangHoa))
                    {
                        xuatNhapTon.LuongNhap += item.SoLuong;
                        xuatNhapTon.LuongTon = xuatNhapTon.LuongNhap - xuatNhapTon.LuongBan;
                        xuatNhapTon.ThanhTienNhap = xuatNhapTon.LuongNhap * xuatNhapTon.DonGiaNhap;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GridEXSelectedItemCollection items = dgList.SelectedItems;
                List<PhieuNhapKho_HangHoa> ItemColl = new List<PhieuNhapKho_HangHoa>();
                if (dgList.GetRows().Length < 0) return;
                if (items.Count <= 0) return;
                if (ShowMessage("Bạn có chắc chắn muốn xóa hàng hoá này không?", true, false) == "Yes")
                {
                    foreach (GridEXSelectedItem i in items)
                    {
                        if (i.RowType == RowType.Record)
                        {
                            ItemColl.Add((PhieuNhapKho_HangHoa)i.GetRow().DataRow);
                        }

                    }
                    foreach (PhieuNhapKho_HangHoa item in ItemColl)
                    {
                        if (item.Id > 0)
                        {
                            item.Delete();
                        }
                        PhieuNhapKho.HangHoaCollection.Remove(item);
                    }
                    BindProducts();
                    CaculatorInvoice();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_LoadingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal SoLuong = (decimal)e.Row.Cells["SoLuong"].Value;
                    decimal DonGia = (decimal)e.Row.Cells["DonGia"].Value;
                    decimal ThanhTien = (decimal)e.Row.Cells["ThanhTien"].Value;

                    e.Row.Cells["SoLuong"].Text = SoLuong.ToString("#.##");
                    e.Row.Cells["DonGia"].Text = DonGia.ToString("#,##0");
                    e.Row.Cells["ThanhTien"].Text = ThanhTien.ToString("#,##0");
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            try
            {
                try
                {
                    if (e.Row.RowType == RowType.Record)
                    {
                        PhieuNhapKho_HangHoa hangHoa = new PhieuNhapKho_HangHoa();
                        hangHoa = (PhieuNhapKho_HangHoa)e.Row.DataRow;
                        cbbMaHangHoa.Text = hangHoa.TenHangHoa;
                        txtTenHangHoa.Text = hangHoa.TenHangHoa;
                        txtDonViTinh.Text = hangHoa.DonViTinh;
                        txtSoLuong.Text = hangHoa.SoLuong.ToString();
                        txtDonGia.Text = hangHoa.DonGia.ToString();
                        txtThanhTien.Text = hangHoa.ThanhTien.ToString();
                        isAdd = false;
                    }
                }
                catch (Exception ex)
                {
                    Logger.LocalLogger.Instance().WriteMessage(ex);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal soluong = Convert.ToDecimal(txtSoLuong.Text);
                txtThanhTien.Text = (Convert.ToDecimal(txtDonGia.Text.Replace(" ₫", "")) * soluong).ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal dongia = Convert.ToDecimal(txtDonGia.Text.Replace(" ₫", ""));
                txtThanhTien.Text = (Convert.ToDecimal(txtSoLuong.Text) * dongia).ToString();
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
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                if (PhieuNhapKho.HangHoaCollection.Count > 0)
                {
                    foreach (var item in PhieuNhapKho.HangHoaCollection)
                    {
                        ToTalMoney += item.ThanhTien;
                    }
                }
                txtTongTien.Text = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                if (Convert.ToDecimal(txtChiPhiNhapHang.Text.Replace(" ₫", "")) > 0)
                {
                    ToTalMoney = ToTalMoney + Convert.ToDecimal(txtChiPhiNhapHang.Text.Replace(" ₫", ""));
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
                txtCanTra.Text = TongTien;
                txtThanhToan.Text = TongTien;
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

        private void txtChiPhiNhapHang_TextChanged(object sender, EventArgs e)
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

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                decimal castMoney = Convert.ToDecimal(txtThanhToan.Text.Replace(" ₫", ""));
                decimal returnMoney = castMoney - Convert.ToDecimal(txtCanTra.Text);
                string ReturnMoney = returnMoney == 0 ? "0" : decimal.Parse(returnMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                txtTienNo.Text = ReturnMoney;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách hàng hoá phiếu nhập kho_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
                sfNPL.Filter = "Excel files| *.xls";
                if (ShowMessage("Bạn có muốn xuất thông tin này ra File Excel không? ", true, false) == "Yes")
                {
                    if (sfNPL.ShowDialog(this) == DialogResult.OK && sfNPL.FileName != "")
                    {

                        Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter();
                        gridEXExporter1.GridEX = dgList;
                        try
                        {
                            System.IO.Stream str = sfNPL.OpenFile();
                            gridEXExporter1.Export(str);
                            str.Close();
                            if (ShowMessage("Bạn có muốn mở File này không?", true, false) == "Yes")
                            {
                                System.Diagnostics.Process.Start(sfNPL.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.LocalLogger.Instance().WriteMessage(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
