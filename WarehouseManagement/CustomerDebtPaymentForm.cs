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
    public partial class CustomerDebtPaymentForm : BaseForm
    {
        public CongNoKhachHang CongNoKhachHang;
        public CustomerDebtPaymentForm()
        {
            InitializeComponent();
        }

        private void CustomerDebtPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategoty();
                if (CongNoKhachHang != null)
                {
                    txtThoiGian.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                    txtNoHienTai.Text = CongNoKhachHang.TongConNo.ToString();
                    txtNoSau.Text = CongNoKhachHang.TongConNo.ToString();

                    List<CongNoKhachHang> CongNoKhachHangCapCollection = new List<CongNoKhachHang>();
                    CongNoKhachHangCapCollection.Add(CongNoKhachHang);
                    dgList.Refetch();
                    dgList.DataSource = CongNoKhachHangCapCollection;
                    dgList.Refresh();
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
                cbbLoaiThu.DataSource = LoaiThu.SelectAll().Tables[0];
                cbbLoaiThu.DisplayMember = "Ten";
                cbbLoaiThu.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateChoose(cbbLoaiThu, errorProvider, "Loại thu", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;

                if (Convert.ToDecimal(txtThuTuKhach.Text.Replace(" ₫", "")) < 0)
                {
                    errorProvider.SetError(txtThuTuKhach, "Tiền thu từ khách phải lớn hơn 0");
                    return;
                }

                if (Convert.ToDecimal(txtNoSau.Text.Replace(" ₫", "")) > 0)
                {
                    errorProvider.SetError(txtNoSau, "Tiền nợ sau phải nhỏ hơn hoặc bằng 0");
                    return;
                }

                CongNoKhachHang.TongDaThanhToan += Convert.ToDecimal(txtThuTuKhach.Text.Replace(" ₫", ""));
                CongNoKhachHang.TongConNo = Convert.ToDecimal(txtNoSau.Text.Replace(" ₫", ""));
                CongNoKhachHang.InsertUpdate();

                PhieuThu PhieuThu = new PhieuThu();
                PhieuThu.ThoiGian = DateTime.Now;
                PhieuThu.NhanVienId = CongNoKhachHang.NhanVienId;
                PhieuThu.LoaiThuId = Convert.ToInt64(cbbLoaiThu.SelectedValue);
                PhieuThu.MaPhieu = GetMaPhieu();
                PhieuThu.NguoiThu = User.Load(CongNoKhachHang.NhanVienId).FullName;
                PhieuThu.GiaTri = Convert.ToDecimal(txtThuTuKhach.Text.Replace(" ₫", ""));
                PhieuThu.KhachHangId = CongNoKhachHang.KhachHangId;
                PhieuThu.HoaDonId = CongNoKhachHang.HoaDonId;
                PhieuThu.GhiChu = txtGhiChu.Text;
                PhieuThu.InsertUpdate();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtThuTuKhach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal ThuTuKhach = Convert.ToDecimal(txtThuTuKhach.Text.Replace(" ₫", ""));
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
