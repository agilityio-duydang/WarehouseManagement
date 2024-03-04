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
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class DebtPaymentSupplierForm : BaseForm
    {
        public CongNoNhaCungCap CongNoNhaCungCap;
        public DebtPaymentSupplierForm()
        {
            InitializeComponent();
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

                    decimal ChiPhiNhap = (decimal)e.Row.Cells["ChiPhiNhap"].Value;
                    e.Row.Cells["ChiPhiNhap"].Text = ChiPhiNhap.ToString("#,##0");

                    decimal GiamGia = (decimal)e.Row.Cells["GiamGia"].Value;
                    e.Row.Cells["GiamGia"].Text = GiamGia.ToString("#,##0");

                    long PhieuNhapKhoId = Convert.ToInt64(e.Row.Cells["PhieuNhapKhoId"].Value);
                    e.Row.Cells["PhieuNhapKhoId"].Text = PhieuNhapKho.Load(PhieuNhapKhoId).MaPhieu;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListDebt_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["PhieuNhapKhoId"].Value);
                    PhieuNhapKho PhieuNhapKho = PhieuNhapKho.Load(id);
                    PhieuNhapKho.HangHoaCollection = PhieuNhapKho_HangHoa.SelectCollectionBy_PhieuNhapKhoId(PhieuNhapKho.Id);
                    PurchaseForm f = new PurchaseForm();
                    f.PhieuNhapKho = PhieuNhapKho;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void DebtPaymentSupplierForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategoty();
                if (CongNoNhaCungCap != null)
                {
                    txtThoiGian.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                    txtNoHienTai.Text = CongNoNhaCungCap.TongConNo.ToString();
                    txtNoSau.Text = CongNoNhaCungCap.TongConNo.ToString();

                    List<CongNoNhaCungCap> CongNoNhaCungCapCollection = new List<CongNoNhaCungCap>();
                    CongNoNhaCungCapCollection.Add(CongNoNhaCungCap);
                    dgListDebt.Refetch();
                    dgListDebt.DataSource = CongNoNhaCungCapCollection;
                    dgListDebt.Refresh();
                }
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
                cbbLoaiChi.DataSource = PaymentType.SelectAll().Tables[0];
                cbbLoaiChi.DisplayMember = "Ten";
                cbbLoaiChi.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateChoose(cbbLoaiChi, errorProvider, "Loại chi", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;

                if (Convert.ToDecimal(txtTraNCC.Text.Replace(" ₫", "")) < 0)
                {
                    errorProvider.SetError(txtTraNCC, "Tiền trả NCC phải lớn hơn 0");
                    return;
                }

                if (Convert.ToDecimal(txtNoSau.Text.Replace(" ₫", "")) > 0)
                {
                    errorProvider.SetError(txtNoSau, "Tiền nợ sau phải nhỏ hơn hoặc bằng 0");
                    return;
                }

                CongNoNhaCungCap.TongDaThanhToan += Convert.ToDecimal(txtTraNCC.Text.Replace(" ₫", ""));
                CongNoNhaCungCap.TongConNo = Convert.ToDecimal(txtNoSau.Text.Replace(" ₫", ""));
                CongNoNhaCungCap.InsertUpdate();

                Payment Payment = new Payment();
                Payment.ThoiGian = DateTime.Now;
                Payment.NhanVienId = CongNoNhaCungCap.NhanVienId;
                Payment.PaymentTypeId = Convert.ToInt64(cbbLoaiChi.SelectedValue);
                Payment.MaPhieu = GetMaPhieu();
                Payment.NguoiNhan = NhaCungCap.Load(CongNoNhaCungCap.NhaCungCapId).TenNhaCungCap;
                Payment.GiaTri = Convert.ToDecimal(txtTraNCC.Text.Replace(" ₫", ""));
                Payment.NhaCungCapId = CongNoNhaCungCap.NhaCungCapId;
                Payment.PhieuNhapKhoId = CongNoNhaCungCap.PhieuNhapKhoId;
                Payment.GhiChu = txtGhiChu.Text;
                Payment.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtThuTuKhach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal ThuTuKhach = Convert.ToDecimal(txtTraNCC.Text.Replace(" ₫", ""));
                decimal NoHienTai = Convert.ToDecimal(txtNoHienTai.Text.Replace(" ₫", ""));
                txtNoSau.Text = (ThuTuKhach + NoHienTai).ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["HoaDonId"].Value);
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

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
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
    }
}
