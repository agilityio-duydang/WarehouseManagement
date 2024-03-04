using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using Janus.Windows.GridEX;
using System.Globalization;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class CustomerForm : BaseForm
    {
        public KhachHang KhachHang;
        public List<HoaDon> HoaDonCollection = new List<HoaDon>();
        public List<CongNoKhachHang> CongNoKhachHangCollection = new List<CongNoKhachHang>();
        public List<PhieuThu> PhieuThuCollection = new List<PhieuThu>();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (KhachHang != null)
                {
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    SetCustomer();
                    HoaDonCollection = HoaDon.SelectCollectionBy_KhachHangId(KhachHang.Id);
                    decimal TongTien = 0;
                    foreach (HoaDon item in HoaDonCollection)
                    {
                        TongTien += item.TongTien;
                    }
                    lblToTal.Text = decimal.Parse(TongTien.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    CongNoKhachHangCollection = CongNoKhachHang.SelectCollectionBy_KhachHangId(KhachHang.Id);
                    decimal TongConNo = 0;
                    foreach (CongNoKhachHang item in CongNoKhachHangCollection)
                    {
                        TongConNo += item.TongConNo;
                    }
                    decimal TongThu = 0;
                    PhieuThuCollection = PhieuThu.SelectCollectionBy_KhachHangId(KhachHang.Id);
                    foreach (PhieuThu item in PhieuThuCollection)
                    {
                        TongThu += item.GiaTri;
                    }
                    txtTongConNo.Text = decimal.Parse(TongConNo.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    txtTongThu.Text = decimal.Parse(TongThu.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    LoadHistory();
                    LoadDebt();
                    LoadReceipts();
                }
                else
                {
                    KhachHang = new KhachHang();
                    txtMa.Text = GetMaKhachHang().ToString();
                    tabHistory.Enabled = false;
                    tabDebt.Enabled = false;
                    tabReceipts.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadReceipts()
        {
            try
            {
                dgListReceipts.Refetch();
                dgListReceipts.DataSource = PhieuThuCollection;
                dgListReceipts.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadHistory()
        {
            try
            {
                dgList.Refetch();
                dgList.DataSource = HoaDonCollection;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadDebt()
        {
            try
            {
                dgListDebt.Refetch();
                dgListDebt.DataSource = CongNoKhachHangCollection;
                dgListDebt.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void GetCustomer()
        {
            try
            {
                KhachHang.MaKhachHang = txtMa.Text.ToString();
                KhachHang.TenKhachHang = txtTen.Text.ToString().Trim();
                KhachHang.DiaChi = txtDiaChi.Text.ToString().Trim();
                KhachHang.SoDienThoai = txtSoDienThoai.Text.ToString().Trim();
                KhachHang.Email = txtEmail.Text.ToString().Trim();
                KhachHang.GhiChu = txtGhiChu.Text.ToString().Trim();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private string GetMaKhachHang()
        {
            try
            {
                string MaKhachHang = string.Empty;
                List<KhachHang> KhachHangCollection = KhachHang.SelectCollectionAll();
                if (KhachHangCollection.Count == 0)
                {
                    MaKhachHang = "KH0000000001";
                }
                else
                {
                    var LastKhachHang = KhachHangCollection.Last();
                    var NumberKhachHang = Convert.ToInt32(LastKhachHang.MaKhachHang.Substring(2, 10));
                    if (NumberKhachHang >= 0 && NumberKhachHang < 9)
                    {
                        MaKhachHang = "KH000000000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 9 && NumberKhachHang < 99)
                    {
                        MaKhachHang = "KH00000000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 99 && NumberKhachHang < 999)
                    {
                        MaKhachHang = "KH0000000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 999 && NumberKhachHang < 9999)
                    {
                        MaKhachHang = "KH000000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 9999 && NumberKhachHang < 99999)
                    {
                        MaKhachHang = "KH00000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 99999 && NumberKhachHang < 999999)
                    {
                        MaKhachHang = "KH0000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 999999 && NumberKhachHang < 9999999)
                    {
                        MaKhachHang = "KH000" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 9999999 && NumberKhachHang < 99999999)
                    {
                        MaKhachHang = "KH00" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 99999999 && NumberKhachHang < 999999999)
                    {
                        MaKhachHang = "KH0" + (NumberKhachHang + 1);
                    }
                    else if (NumberKhachHang >= 999999999 && NumberKhachHang < 9999999999)
                    {
                        MaKhachHang = "KH" + (NumberKhachHang + 1);
                    }
                }
                return MaKhachHang;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void SetCustomer()
        {
            try
            {
                txtMa.Text = KhachHang.MaKhachHang.ToString();
                txtTen.Text = KhachHang.TenKhachHang.ToString();
                txtDiaChi.Text = KhachHang.DiaChi.ToString();
                txtEmail.Text = KhachHang.Email.ToString();
                txtSoDienThoai.Text = KhachHang.SoDienThoai.ToString();
                txtGhiChu.Text = KhachHang.GhiChu.ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtTen, errorProvider, "Tên khách hàng", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                GetCustomer();
                KhachHang.InsertUpdate();
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

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal TongTien = (decimal)e.Row.Cells["TongTien"].Value;
                    e.Row.Cells["TongTien"].Text = TongTien.ToString("#,##0");

                    long NhanVienId = Convert.ToInt64(e.Row.Cells["NhanVienId"].Value);
                    e.Row.Cells["NhanVienId"].Text = User.Load(NhanVienId).FullName;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListDebt_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal TongTien = (decimal)e.Row.Cells["TongTien"].Value;
                    e.Row.Cells["TongTien"].Text = TongTien.ToString("#,##0");

                    decimal TongDaThanhToan = (decimal)e.Row.Cells["TongDaThanhToan"].Value;
                    e.Row.Cells["TongDaThanhToan"].Text = TongDaThanhToan.ToString("#,##0");

                    decimal TongConNo = (decimal)e.Row.Cells["TongConNo"].Value;
                    e.Row.Cells["TongConNo"].Text = TongConNo.ToString("#,##0");

                    long HoaDonId = Convert.ToInt64(e.Row.Cells["HoaDonId"].Value);
                    e.Row.Cells["HoaDonId"].Text = HoaDon.Load(HoaDonId).MaHoaDon;
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
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    HoaDon HoaDon = HoaDon.Load(id);
                    HoaDon.HangHoaCollection = HoaDon_HangHoa.SelectCollectionBy_HoaDonId(HoaDon.Id);
                    InvoicesForm f = new InvoicesForm();
                    f.HoaDon = HoaDon;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListDebt_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    CongNoKhachHang CongNoKhachHang = CongNoKhachHang.Load(id);
                    CustomerDebtPaymentForm f = new CustomerDebtPaymentForm();
                    f.CongNoKhachHang = CongNoKhachHang;
                    f.ShowDialog(this);
                }
                LoadDebt();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListReceipts_LoadingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal GiaTri = (decimal)e.Row.Cells["GiaTri"].Value;
                    long LoaiThuId = (long)e.Row.Cells["LoaiThuId"].Value;
                    e.Row.Cells["GiaTri"].Text = GiaTri.ToString("#,##0");
                    e.Row.Cells["LoaiThuId"].Text = LoaiThu.Load(LoaiThuId).Ten;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListReceipts_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    PhieuThu PhieuThu = PhieuThu.Load(id);
                    ReceiptsForm f = new ReceiptsForm();
                    f.PhieuThu = PhieuThu;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
