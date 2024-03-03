using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using System.Globalization;
using Company.WM.BLL;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class CashierForm : BaseForm
    {
        public string where;
        public BanHang BanHang;
        public BanHang_HangHoa BanHang_HangHoa;
        public User user;
        public CashierForm()
        {
            InitializeComponent();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
                LoadCategoty();
                LoadCustomer();
                if (BanHang == null)
                {
                    BanHang = BanHang.SelectCollectionAll().FirstOrDefault();
                    if (BanHang == null)
                    {
                        BanHang = new BanHang();
                        BanHang.ThoiGianTao = DateTime.Now;
                        BanHang.NhanVienId = user.ID;
                        BanHang.KhachHangId = KhachHang.SelectCollectionAll().FirstOrDefault().Id;
                        BanHang.HangHoaCollection = new List<BanHang_HangHoa>();
                    }
                    else
                    {
                        BanHang.HangHoaCollection = BanHang_HangHoa.SelectCollectionBy_BanHangId(BanHang.Id);
                    }
                }
                SetProducts();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private string GetSearchWhere()
        {
            try
            {
                where = " 1 = 1";
                if (!String.IsNullOrEmpty(txtTenHangHoa.Text))
                {
                    where += " AND TenHangHoa LIKE N'%" + txtTenHangHoa.Text + "%' OR MaHangHoa LIKE N'%" + txtTenHangHoa.Text + "%'";
                }
                if (cbbCategory.SelectedValue != null)
                {
                    where += " AND NhomHangHoaId = '" + cbbCategory.SelectedValue + "'";
                }
                return where;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgListProducts.Refetch();
                dgListProducts.DataSource = HangHoa.SelectDynamic(GetSearchWhere(), null).Tables[0];
                dgListProducts.Refresh();
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
                dgListProducts.Refetch();
                dgListProducts.DataSource = HangHoa.SelectAll().Tables[0];
                dgListProducts.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
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
                    foreach (var item in BanHang.HangHoaCollection)
                    {
                        ToTalMoney += item.ThanhTienBan;
                    }
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    string TongTien = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    lblTongTien.Text = TongTien;
                }
                else
                {
                    lblTongTien.Text = "0";
                }
                lblTenNhanVien.Text = User.Load(BanHang.NhanVienId).FullName.ToString();
                if (!string.IsNullOrEmpty(BanHang.KhachHangId.ToString()))
                {
                    cbbKhachHang.SelectedValue = BanHang.KhachHangId.ToString();
                }
                lblThoiGianTao.Text = BanHang.ThoiGianTao == DateTime.MinValue ? DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") : BanHang.ThoiGianTao.ToString("dd-MM-yyyy HH:mm:ss");
                txtGhiChu.Text = BanHang.GhiChu.ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateFormSales(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateChoose(cbbKhachHang, errorProvider, "Khách hàng ", isOnlyWarning);
            return isValid;
        }

        private void dgListProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFormSales(false))
                    return;
                if (dgListProducts.CurrentRow.RowType == RowType.Record)
                {
                    int id = System.Convert.ToInt32(dgListProducts.CurrentRow.Cells["Id"].Value.ToString());
                    HangHoa HangHoa = HangHoa.Load(id);
                    BanHang_HangHoa BanHang_HangHoa = new BanHang_HangHoa();
                    BanHang_HangHoa.MaHangHoa = HangHoa.MaHangHoa;
                    BanHang_HangHoa.TenHangHoa = HangHoa.TenHangHoa;
                    BanHang_HangHoa.SoLuong = 1;
                    BanHang_HangHoa.NhomHangHoaId = HangHoa.NhomHangHoaId;
                    BanHang_HangHoa.DonGiaNhap = HangHoa.DonGiaNhap;
                    BanHang_HangHoa.DonGiaBan = HangHoa.DonGiaBan;
                    BanHang_HangHoa.DonViTinh = HangHoa.DonViTinh;
                    BanHang_HangHoa.ThanhTienNhap = BanHang_HangHoa.DonGiaNhap * BanHang_HangHoa.SoLuong;
                    BanHang_HangHoa.ThanhTienBan = BanHang_HangHoa.DonGiaBan * BanHang_HangHoa.SoLuong;
                    bool isAddNew = true;
                    if (BanHang.HangHoaCollection.Count == 0)
                    {
                        BanHang.ThoiGianTao = DateTime.Now;
                    }
                    foreach (var item in BanHang.HangHoaCollection)
                    {
                        if (BanHang_HangHoa.MaHangHoa == item.MaHangHoa)
                        {
                            item.SoLuong += 1;
                            item.ThanhTienBan = item.SoLuong * item.DonGiaBan;
                            item.ThanhTienNhap = item.SoLuong * item.DonGiaNhap;
                            isAddNew = false;
                        }
                    }

                    if (isAddNew)
                    {
                        BanHang.HangHoaCollection.Add(BanHang_HangHoa);
                    }
                    BanHang.GhiChu = txtGhiChu.Text.ToString().Trim();
                    BanHang.InsertUpdateFull();
                    SetProducts();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListProducts_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            try
            {
                if (!ValidateFormSales(false))
                    return;
                if (e.Row.RowType == RowType.Record)
                {
                    if (BanHang != null)
                    {
                        long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                        HangHoa HangHoa = HangHoa.Load(id);
                        BanHang_HangHoa BanHang_HangHoa = new BanHang_HangHoa();
                        BanHang_HangHoa.MaHangHoa = HangHoa.MaHangHoa;
                        BanHang_HangHoa.TenHangHoa = HangHoa.TenHangHoa;
                        BanHang_HangHoa.SoLuong = 1;
                        BanHang_HangHoa.NhomHangHoaId = HangHoa.NhomHangHoaId;
                        BanHang_HangHoa.DonGiaNhap = HangHoa.DonGiaNhap;
                        BanHang_HangHoa.DonGiaBan = HangHoa.DonGiaBan;
                        BanHang_HangHoa.DonViTinh = HangHoa.DonViTinh;
                        BanHang_HangHoa.ThanhTienNhap = BanHang_HangHoa.DonGiaNhap * BanHang_HangHoa.SoLuong;
                        BanHang_HangHoa.ThanhTienBan = BanHang_HangHoa.DonGiaBan * BanHang_HangHoa.SoLuong;
                        bool isAddNew = true;
                        if (BanHang.HangHoaCollection.Count == 0)
                        {
                            BanHang.ThoiGianTao = DateTime.Now;
                        }
                        foreach (var item in BanHang.HangHoaCollection)
                        {
                            if (BanHang_HangHoa.MaHangHoa == item.MaHangHoa)
                            {
                                item.SoLuong += 1;
                                item.ThanhTienBan = item.SoLuong * item.DonGiaBan;
                                item.ThanhTienNhap = item.SoLuong * item.DonGiaNhap;
                                isAddNew = false;
                            }
                        }

                        if (isAddNew)
                        {
                            BanHang.HangHoaCollection.Add(BanHang_HangHoa);
                        }
                        BanHang.GhiChu = txtGhiChu.Text.ToString().Trim();
                        BanHang.InsertUpdateFull();
                        SetProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GridEXSelectedItemCollection items = dgList.SelectedItems;
                List<BanHang_HangHoa> ItemColl = new List<BanHang_HangHoa>();
                if (dgList.GetRows().Length < 0) return;
                if (items.Count <= 0) return;
                if (ShowMessage("Bạn có chắc chắn muốn xóa hàng hoá này không?", true, false) == "Yes")
                {
                    foreach (GridEXSelectedItem i in items)
                    {
                        if (i.RowType == RowType.Record)
                        {
                            ItemColl.Add((BanHang_HangHoa)i.GetRow().DataRow);
                        }

                    }
                    foreach (BanHang_HangHoa item in ItemColl)
                    {
                        if (item.Id > 0)
                            item.Delete();
                        BanHang.HangHoaCollection.Remove(item);
                    }
                    ShowMessage("Xóa thành công. ", false, false);
                    SetProducts();
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
                    ConfirmPayment f = new ConfirmPayment();
                    f.BanHang = BanHang;
                    f.user = user;
                    f.ThueGTGT = Convert.ToInt32(txtThueGTGT.Text);
                    f.ShowDialog(this);
                    BanHang = f.BanHang;
                }
                SetProducts();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void ProcessDebit()
        {
 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (BanHang != null)
                {
                    if (BanHang.HangHoaCollection.Count() > 0)
                    {
                        int ThueGTGT = 0;
                        if (!String.IsNullOrEmpty(txtThueGTGT.Text))
                        {
                            ThueGTGT = Convert.ToInt32(txtThueGTGT.Text);
                        }
                        K80PrintTemplates f = new K80PrintTemplates();
                        f.BanHang = BanHang;
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

        private void dgList_LoadingRow(object sender, RowLoadEventArgs e)
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

        public string RemoveFromEnd(string str, int characterCount)
        {
            try
            {
                return str.Remove(str.Length - characterCount, characterCount);

            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void dgListProducts_LoadingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal DonGiaBan = (decimal)e.Row.Cells["DonGiaBan"].Value;
                    e.Row.Cells["DonGiaBan"].Text = DonGiaBan.ToString("#,##0");
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
                if (e.Row.RowType == RowType.Record)
                {
                    if (BanHang_HangHoa != null)
                    {
                        long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                        BanHang_HangHoa = BanHang_HangHoa.Load(id);
                        txtSoLuong.Text = BanHang_HangHoa.SoLuong.ToString();
                        txtDonGia.Text = BanHang_HangHoa.DonGiaBan.ToString();
                    }
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
            isValid &= ValidateControl.ValidateNull(txtSoLuong, errorProvider, "Số lượng", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDonGia, errorProvider, "Đơn giá", isOnlyWarning);
            return isValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidateForm(false))
                    return;
                if (BanHang_HangHoa != null)
                {
                    BanHang_HangHoa.SoLuong = Convert.ToDecimal(txtSoLuong.Text);
                    BanHang_HangHoa.DonGiaBan = Convert.ToDecimal(txtDonGia.Text.Replace(" ₫", ""));
                    BanHang_HangHoa.ThanhTienBan = BanHang_HangHoa.SoLuong * BanHang_HangHoa.DonGiaBan;
                    BanHang_HangHoa.ThanhTienNhap = BanHang_HangHoa.SoLuong * BanHang_HangHoa.DonGiaNhap;
                    BanHang_HangHoa.Update();
                    BanHang.HangHoaCollection = BanHang_HangHoa.SelectCollectionBy_BanHangId(BanHang.Id);
                    SetProducts();
                    txtSoLuong.Text = String.Empty;
                    txtDonGia.Text = String.Empty;
                    BanHang_HangHoa = null;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtThueGTGT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal ToTalMoney = 0;
                foreach (var item in BanHang.HangHoaCollection)
                {
                    ToTalMoney += item.ThanhTienBan;
                }
                decimal Tax;
                if (!String.IsNullOrEmpty(txtThueGTGT.Text.Trim()))
                {
                    if (txtThueGTGT.Text.Trim() != "0")
                    {
                        Tax = ToTalMoney * Convert.ToInt32(txtThueGTGT.Text) / 100;
                        ToTalMoney = ToTalMoney + Tax;
                        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                        string TongTien = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                        lblTongTien.Text = TongTien;
                    }
                    else
                    {
                        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                        string TongTien = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                        lblTongTien.Text = TongTien;

                    }
                }
                else
                {
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    string TongTien = decimal.Parse(ToTalMoney.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    lblTongTien.Text = TongTien;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgList.CurrentRow.RowType == RowType.Record)
                {
                    int id = System.Convert.ToInt32(dgList.CurrentRow.Cells["Id"].Value.ToString());
                    BanHang_HangHoa = BanHang_HangHoa.Load(id);
                    txtSoLuong.Text = BanHang_HangHoa.SoLuong.ToString();
                    txtDonGia.Text = BanHang_HangHoa.DonGiaBan.ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListProducts_Click(object sender, EventArgs e)
        {

        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (BanHang.HangHoaCollection.Count() > 0)
                {
                    BanHang.KhachHangId = Convert.ToInt64(cbbKhachHang.SelectedValue);
                    BanHang.InsertUpdateFull();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BanHang.HangHoaCollection.Count() > 0)
                {
                    BanHang.GhiChu = txtGhiChu.Text;
                    BanHang.InsertUpdateFull();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
