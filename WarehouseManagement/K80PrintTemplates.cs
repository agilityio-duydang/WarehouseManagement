using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Company.WM.BLL;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class K80PrintTemplates : DevExpress.XtraReports.UI.XtraReport
    {
        public BanHang BanHang;
        public HoaDon HoaDon;
        public int ThueGTGT;
        public decimal Tax;
        decimal Total;
        decimal TotalTax;
        public int GiamGia;
        public decimal TriGiaGiam;
        public decimal TienThue;
        public decimal TongThanhToan;
        public K80PrintTemplates()
        {
            InitializeComponent();
        }

        public void BindReport()
        {
            try
            {
                if (BanHang != null)
                {
                    GlobalSettings.Refreskey();
                    lblTenNhaHang.Text = GlobalSettings.COMPANYNAME;
                    lblDiaChi.Text = GlobalSettings.ADDRESS;
                    lblSoDienThoai.Text = GlobalSettings.PHONENUMBER;
                    lblLoaiPhieu.Text = GlobalSettings.LOAIPHIEU;
                    lblNhanVien.Text = User.Load(BanHang.NhanVienId).FullName;

                    lblNote1.Text = GlobalSettings.NOTE1;
                    lblNote2.Text = GlobalSettings.NOTE2;
                    lblNote3.Text = GlobalSettings.NOTE3;
                    lblNote4.Text = GlobalSettings.NOTE4;
                    lblNote5.Text = GlobalSettings.NOTE5;
                    lblTenKhachHang.Text = KhachHang.Load(BanHang.KhachHangId).TenKhachHang;
                    lblGioVao.Text = BanHang.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                    lblGioThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lblTenThue.Text = GlobalSettings.TENTHUE;
                    if (BanHang.HangHoaCollection.Count > 0)
                    {
                        int k = 1;
                        foreach (var item in BanHang.HangHoaCollection)
                        {
                            item.STT = k;
                            k++;
                            Total += item.ThanhTienBan;
                        }
                        if (ThueGTGT != 0)
                        {
                            lblTax.Text = TienThue.ToString("N0");
                            lblNote1.Text = String.Empty;
                        }
                        lblToTal.Text = Total.ToString("N0");
                        lblToTalTax.Text = TongThanhToan.ToString("N0");
                        if (GiamGia != 0)
                        {
                            lblPercent.Text = GiamGia.ToString("N0");
                        }
                        if (TriGiaGiam != 0)
                        {
                            lblTriGiaGiam.Text = TriGiaGiam.ToString("N0");
                        }
                        if (TongThanhToan == 0)
                        {
                            if (ThueGTGT != 0)
                            {
                                Tax = (Total * ThueGTGT) / 100;
                                TotalTax = Total + Tax;
                                lblToTal.Text = Total.ToString("N0"); //Total.ToString("0.##");
                                lblTax.Text = Tax.ToString("N0"); //Total.ToString("0.##");
                                lblToTalTax.Text = TotalTax.ToString("N0"); //Total.ToString("0.##");
                                lblNote1.Text = String.Empty;
                            }
                            else
                            {
                                lblToTal.Text = Total.ToString("N0"); //Total.ToString("0.##");
                                lblToTalTax.Text = Total.ToString("N0"); //Total.ToString("0.##");
                            }
                        }
                        this.DetailReport.DataSource = BanHang.HangHoaCollection;
                        lblSTT.DataBindings.Add("Text", this.DetailReport.DataSource, "STT");
                        lblTenHangHoa.DataBindings.Add("Text", this.DetailReport.DataSource, "TenHangHoa");
                        lblSoLuong.DataBindings.Add("Text", this.DetailReport.DataSource, "SoLuong", "{0:0.##}");
                        lblDonGia.DataBindings.Add("Text", this.DetailReport.DataSource, "DonGiaBan", "{0:#,0}");
                        lblThanhTien.DataBindings.Add("Text", this.DetailReport.DataSource, "ThanhTienBan", "{0:#,0}");
                    }
                }
                else if (HoaDon != null)
                {
                    GlobalSettings.Refreskey();
                    lblTenNhaHang.Text = GlobalSettings.COMPANYNAME;
                    lblDiaChi.Text = GlobalSettings.ADDRESS;
                    lblSoDienThoai.Text = GlobalSettings.PHONENUMBER;
                    lblLoaiPhieu.Text = GlobalSettings.HOADON;
                    lblNhanVien.Text = User.Load(HoaDon.NhanVienId).FullName;

                    lblNote1.Text = GlobalSettings.NOTE1;
                    lblNote2.Text = GlobalSettings.NOTE2;
                    lblNote3.Text = GlobalSettings.NOTE3;
                    lblNote5.Text = GlobalSettings.NOTE5;
                    lblNote4.Text = GlobalSettings.NOTE4;
                    lblTenKhachHang.Text = KhachHang.Load(HoaDon.KhachHangId).TenKhachHang;
                    lblGioVao.Text = HoaDon.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                    lblGioThanhToan.Text = HoaDon.ThoiGianThanhToan.ToString("dd/MM/yyyy HH:mm:ss");
                    lblTenThue.Text = GlobalSettings.TENTHUE;
                    if (HoaDon.HangHoaCollection.Count > 0)
                    {
                        int k = 1;
                        foreach (var item in HoaDon.HangHoaCollection)
                        {
                            item.STT = k;
                            Total += item.ThanhTienBan;
                            k++;
                        }
                        if (HoaDon.ThueSuat != 0)
                        {
                            lblTax.Text = HoaDon.TienThue.ToString("N0");
                            lblNote1.Text = String.Empty;
                        }
                        lblToTal.Text = HoaDon.TongTienHang.ToString("N0");
                        lblToTalTax.Text = HoaDon.TongTien.ToString("N0");
                        if (HoaDon.GiamGia != 0)
                        {
                            lblPercent.Text = HoaDon.GiamGia.ToString("N0");
                        }
                        if (HoaDon.TriGiaGiam != 0)
                        {
                            lblTriGiaGiam.Text = HoaDon.TriGiaGiam.ToString("N0");
                        }
                        this.DetailReport.DataSource = HoaDon.HangHoaCollection;
                        lblSTT.DataBindings.Add("Text", this.DetailReport.DataSource, "STT");
                        lblTenHangHoa.DataBindings.Add("Text", this.DetailReport.DataSource, "TenHangHoa");
                        lblSoLuong.DataBindings.Add("Text", this.DetailReport.DataSource, "SoLuong", "{0:0.##}");
                        lblDonGia.DataBindings.Add("Text", this.DetailReport.DataSource, "DonGiaBan", "{0:#,0}");
                        lblThanhTien.DataBindings.Add("Text", this.DetailReport.DataSource, "ThanhTienBan", "{0:#,0}");
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
