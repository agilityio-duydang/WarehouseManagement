using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Janus.Windows.GridEX;
using Company.WM.BLL;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class InvoicesForm : BaseForm
    {
        public HoaDon HoaDon;
        public decimal Total;
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal SoLuong = (decimal)e.Row.Cells["SoLuong"].Value;
                    decimal ThanhTienBan = (decimal)e.Row.Cells["ThanhTienBan"].Value;
                    decimal DonGiaBan = (decimal)e.Row.Cells["DonGiaBan"].Value;

                    e.Row.Cells["SoLuong"].Text = ToTrimmedString(SoLuong);
                    e.Row.Cells["ThanhTienBan"].Text = ThanhTienBan.ToString("#,##0");
                    e.Row.Cells["DonGiaBan"].Text = DonGiaBan.ToString("#,##0");
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
        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (HoaDon != null)
                {
                    lblTenNhanVien.Text = User.Load(HoaDon.NhanVienId).FullName;
                    lblTenKhachHang.Text = KhachHang.Load(HoaDon.KhachHangId).TenKhachHang;
                    lblThoiGianTao.Text = HoaDon.ThoiGianThanhToan.ToString("dd-MM-yyyy HH:mm");
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    lblToTalTax.Text = decimal.Parse(HoaDon.TongTienHang.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    lblTax.Text = decimal.Parse(HoaDon.TienThue.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    lblGiamGia.Text = HoaDon.GiamGia == 0 ? "" : HoaDon.GiamGia.ToString("N0");
                    lblTriGiaGiam.Text = decimal.Parse(HoaDon.TriGiaGiam.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    lblTongTien.Text = decimal.Parse(HoaDon.TongTien.ToString()).ToString("#,###", cultureInfo.NumberFormat);
                    dgList.Refetch();
                    dgList.DataSource = HoaDon.HangHoaCollection;
                    dgList.Refresh();
                }
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
                if (HoaDon != null)
                {
                    if (HoaDon.HangHoaCollection.Count() > 0)
                    {
                        K80PrintTemplates f = new K80PrintTemplates();
                        f.HoaDon = HoaDon;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách hàng hoá hoá đơn_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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
