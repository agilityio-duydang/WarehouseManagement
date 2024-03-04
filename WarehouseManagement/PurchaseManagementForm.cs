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

namespace WarehouseManagement
{
    public partial class PurchaseManagementForm : BaseForm
    {
        public string where;
        public List<PhieuNhapKho> PhieuNhapKhoCollection = new List<PhieuNhapKho>();
        public PurchaseManagementForm()
        {
            InitializeComponent();
        }

        private void PurchaseManagementForm_Load(object sender, EventArgs e)
        {
            LoadSupplier();
            LoadWareHouse();
            btnSearch_Click(null, null);
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
                cbbMaKho.DisplayMember = "TenKho";
                cbbMaKho.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhapKhoCollection = PhieuNhapKho.SelectCollectionDynamic(GetSearchWhere(), null);
                dgList.Refetch();
                dgList.DataSource = PhieuNhapKhoCollection;
                dgList.Refresh();
                CaculatorData();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
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

        private string GetSearchWhere()
        {
            try
            {
                where = " 1 = 1";
                if (cbbNhaCungCap.SelectedValue != null)
                {
                    where += " AND NhaCungCapId = '" + cbbNhaCungCap.SelectedValue + "'";
                }
                if (cbbMaKho.SelectedValue != null)
                {
                    where += " AND MaKho = N'" + cbbMaKho.Text + "'";
                }
                where += " AND ThoiGian BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dateDenNgay.Value.ToString("yyyy-MM-dd 23:59:59") + "'";
                return where;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
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

                    decimal ChiPhiNhap = (decimal)e.Row.Cells["ChiPhiNhap"].Value;
                    e.Row.Cells["ChiPhiNhap"].Text = ChiPhiNhap.ToString("#,##0");

                    decimal GiamGia = (decimal)e.Row.Cells["GiamGia"].Value;
                    e.Row.Cells["GiamGia"].Text = GiamGia.ToString("#,##0");

                    long NhaCungCapId = Convert.ToInt64(e.Row.Cells["NhaCungCapId"].Value);
                    e.Row.Cells["NhaCungCapId"].Text = NhaCungCap.Load(NhaCungCapId).TenNhaCungCap;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
