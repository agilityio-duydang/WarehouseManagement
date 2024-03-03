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

namespace WarehouseManagement
{
    public partial class InventoryManagementForm : BaseForm
    {
        public string where;
        public List<XuatNhapTon> XuatNhapTonCollection = new List<XuatNhapTon>();
        public InventoryManagementForm()
        {
            InitializeComponent();
        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            LoadCategoty();
            btnSearch_Click(null, null);
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

        private string GetSearchWhere()
        {
            try
            {
                where = " 1 = 1";
                if (!String.IsNullOrEmpty(txtMaHangHoa.Text))
                {
                    where += " AND MaHangHoa LIKE N'%" + txtMaHangHoa.Text + "%'";
                }
                if (!String.IsNullOrEmpty(txtTenHangHoa.Text))
                {
                    where += " AND TenHangHoa LIKE N'%" + txtTenHangHoa.Text + "%'";
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
                XuatNhapTonCollection = XuatNhapTon.SelectCollectionDynamic(GetSearchWhere(), null);
                dgList.Refetch();
                dgList.DataSource = XuatNhapTonCollection;
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
                decimal TotalNhap = 0;
                decimal TotalBan = 0;
                decimal TotalTon = 0;

                decimal TotalThanhTienNhap = 0;
                decimal TotalThanhTienBan = 0;
                decimal TotalThanhTienTon = 0;
                foreach (XuatNhapTon item in XuatNhapTonCollection)
                {
                    TotalNhap += item.LuongNhap;
                    TotalBan += item.LuongBan;
                    TotalTon += item.LuongTon;

                    TotalThanhTienNhap += item.LuongNhap * item.DonGiaNhap;
                    TotalThanhTienBan += item.ThanhTienBan;
                    TotalThanhTienTon += item.ThanhTienTon;
                }

                txtLuongNhap.Text = TotalNhap.ToString();
                txtLuongBan.Text = TotalBan.ToString();
                txtLuongTon.Text = TotalTon.ToString();

                txtThanhTienNhap.Text = TotalThanhTienNhap.ToString();
                txtThanhTienBan.Text = TotalThanhTienBan.ToString();
                txtThanhTienTon.Text = TotalThanhTienTon.ToString();
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

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal DonGiaNhap = (decimal)e.Row.Cells["DonGiaNhap"].Value;
                    decimal DonGiaBan = (decimal)e.Row.Cells["DonGiaBan"].Value;
                    decimal LuongNhap = (decimal)e.Row.Cells["LuongNhap"].Value;
                    decimal LuongBan = (decimal)e.Row.Cells["LuongBan"].Value;
                    decimal LuongTon = (decimal)e.Row.Cells["LuongTon"].Value;
                    decimal ThanhTienNhap = (decimal)e.Row.Cells["ThanhTienNhap"].Value;
                    decimal ThanhTienBan = (decimal)e.Row.Cells["ThanhTienBan"].Value;
                    decimal ThanhTienTon = (decimal)e.Row.Cells["ThanhTienTon"].Value;
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    long NhomHangHoaId = (long)e.Row.Cells["NhomHangHoaId"].Value;
                    e.Row.Cells["DonGiaNhap"].Text = decimal.Parse(DonGiaNhap.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    e.Row.Cells["DonGiaBan"].Text = decimal.Parse(DonGiaBan.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    e.Row.Cells["NhomHangHoaId"].Text = NhomHangHoa.Load(NhomHangHoaId).TenNhom;

                    e.Row.Cells["LuongNhap"].Text = ToTrimmedString(LuongNhap);
                    e.Row.Cells["LuongBan"].Text = ToTrimmedString(LuongBan);
                    e.Row.Cells["LuongTon"].Text = ToTrimmedString(LuongTon);
                    e.Row.Cells["ThanhTienNhap"].Text = ThanhTienNhap == 0 ? "0" : decimal.Parse(ThanhTienNhap.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    e.Row.Cells["ThanhTienBan"].Text = ThanhTienBan == 0 ? "0" : decimal.Parse(ThanhTienBan.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    e.Row.Cells["ThanhTienTon"].Text = ThanhTienTon == 0 ? "0" : decimal.Parse(ThanhTienTon.ToString()).ToString("#,###", cultureInfo.NumberFormat);
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
    }
}
