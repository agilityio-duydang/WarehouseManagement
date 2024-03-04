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

namespace WarehouseManagement.WareHouse
{
    public partial class WareHouseForm : BaseForm
    {
        public Kho Kho;
        public List<PhieuNhapKho> PhieuNhapKhoCollection = new List<PhieuNhapKho>();
        public WareHouseForm()
        {
            InitializeComponent();
        }

        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Kho != null)
                {
                    SetWareHouse();
                    PhieuNhapKhoCollection = PhieuNhapKho.SelectCollectionDynamic("MaKho = N'" + Kho.MaKho + "'","");
                    CaculatorData();
                    LoadHistory();
                }
                else
                {
                    Kho = new Kho();
                    tabHistory.Enabled = false;
                    txtMaKho.Text = GetMaKho();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }


        private string GetMaKho()
        {
            try
            {
                string MaKho = string.Empty;
                List<Kho> KhoCollection = Kho.SelectCollectionAll();
                if (KhoCollection.Count == 0)
                {
                    MaKho = "KHO0000000001";
                }
                else
                {
                    var LastPayment = KhoCollection.Last();
                    var NumberKho = Convert.ToInt32(LastPayment.MaKho.Substring(3, 10));
                    if (NumberKho >= 0 && NumberKho < 9)
                    {
                        MaKho = "KHO000000000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 9 && NumberKho < 99)
                    {
                        MaKho = "KHO00000000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 99 && NumberKho < 999)
                    {
                        MaKho = "KHO0000000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 999 && NumberKho < 9999)
                    {
                        MaKho = "KHO000000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 9999 && NumberKho < 99999)
                    {
                        MaKho = "KHO00000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 99999 && NumberKho < 999999)
                    {
                        MaKho = "KHO0000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 999999 && NumberKho < 9999999)
                    {
                        MaKho = "KHO000" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 9999999 && NumberKho < 99999999)
                    {
                        MaKho = "KHO00" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 99999999 && NumberKho < 999999999)
                    {
                        MaKho = "KHO0" + (NumberKho + 1);
                    }
                    else if (NumberKho >= 999999999 && NumberKho < 9999999999)
                    {
                        MaKho = "KHO" + (NumberKho + 1);
                    }
                }
                return MaKho;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void CaculatorData()
        {
            try
            {
                decimal TotalTongTien = 0;
                decimal TotalTongThanhToan = 0;
                decimal TotalTongConNo = 0;
                decimal TotalChiPhiNhap = 0;
                decimal TotalGiamGia = 0;
                foreach (PhieuNhapKho item in PhieuNhapKhoCollection)
                {
                    TotalTongTien += item.TongTien;
                    TotalTongThanhToan += item.TongDaThanhToan;
                    TotalTongConNo += item.TongConNo;
                    TotalChiPhiNhap += item.ChiPhiNhap;
                    TotalGiamGia += item.GiamGia;
                }
                txtTongTien.Text = TotalTongTien.ToString();
                txtTongThanhToan.Text = TotalTongThanhToan.ToString();
                txtTongConNo.Text = TotalTongConNo.ToString();
                txtTongChiPhiNhap.Text = TotalChiPhiNhap.ToString();
                txtTongGiamGia.Text = TotalGiamGia.ToString();
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
                dgList.DataSource = PhieuNhapKhoCollection;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void SetWareHouse()
        {
            try
            {
                txtMaKho.Text = Kho.MaKho;
                txtTenKho.Text = Kho.TenKho;
                txtGhiChu.Text = Kho.GhiChu;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void GetWareHouse()
        {
            try
            {
                Kho.MaKho = txtMaKho.Text.ToString().Trim();
                Kho.TenKho = txtTenKho.Text.ToString().Trim();
                Kho.GhiChu = txtGhiChu.Text.ToString().Trim();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtMaKho, errorProvider, "Mã kho", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtTenKho, errorProvider, "Tên kho", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                GetWareHouse();
                Kho.InsertUpdate();
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

                    decimal TongDaThanhToan = (decimal)e.Row.Cells["TongDaThanhToan"].Value;
                    e.Row.Cells["TongDaThanhToan"].Text = TongDaThanhToan.ToString("#,##0");

                    decimal TongConNo = (decimal)e.Row.Cells["TongConNo"].Value;
                    e.Row.Cells["TongConNo"].Text = TongConNo.ToString("#,##0");

                    decimal ChiPhiNhap = (decimal)e.Row.Cells["ChiPhiNhap"].Value;
                    e.Row.Cells["ChiPhiNhap"].Text = ChiPhiNhap.ToString("#,##0");

                    decimal GiamGia = (decimal)e.Row.Cells["GiamGia"].Value;
                    e.Row.Cells["GiamGia"].Text = GiamGia.ToString("#,##0");
                }
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
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
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
    }
}
