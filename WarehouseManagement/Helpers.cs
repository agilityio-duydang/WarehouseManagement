using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Globalization;
using System.Data;
using System.Reflection;
using Company.WM.BLL;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public class Helpers
    {
        public void SendEmmail(HoaDon hoadon)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "" + User.Load(hoadon.NhanVienId).FullName.ToString() + " vừa thanh toán một đơn hàng trị giá " + hoadon.TongTien.ToString("N0");
                string tr = "";
                foreach (var item in hoadon.HangHoaCollection)
                {
                    tr += "<tr>";
                    tr += "<td>" + item.STT.ToString() + "</td>";
                    tr += "<td>" + item.TenHangHoa.ToString() + "</td>";
                    tr += "<td>" + item.DonViTinh.ToString() + "</td>";
                    tr += "<td>" + ToTrimmedString(item.SoLuong) + "</td>";
                    tr += "<td>" + item.DonGiaBan.ToString("#,##0") + "</td>";
                    tr += "<td>" + item.ThanhTienBan.ToString("#,##0") + "</td>";
                    tr += "</tr>";
                }
                string body = "Mã hoá đơn   : " + hoadon.MaHoaDon + "<br>";
                body += "Thời gian vào        : " + hoadon.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss") + "<br>";
                body += "Thời gian thanh toán : " + hoadon.ThoiGianThanhToan.ToString("dd/MM/yyyy HH:mm:ss") + "<br>";
                body += "Tên nhân viên   : " + User.Load(hoadon.NhanVienId).FullName.ToString() + "<br>";
                body += "Tên khách hàng  : " + KhachHang.Load(hoadon.KhachHangId).TenKhachHang.ToString() + "<br>";
                body += "Tổng tiền hàng  : " + hoadon.TongTienHang.ToString("#,##0") + "<br>";
                body += "Tiền thuế       : " + hoadon.TienThue.ToString("#,##0") + "<br>";
                body += "Giảm giá (%)    : " + hoadon.GiamGia.ToString("#,##0") + "<br>";
                body += "Trị giá giảm    : " + hoadon.TriGiaGiam.ToString("#,##0") + "<br>";
                body += "Tổng thanh toán : " + hoadon.TongTien.ToString("#,##0") + "<br>";

                body += "<table>"
                     + "<thead>"
                        + "<tr>"
                            + "<th>STT</th>"
                            + "<th>Tên hàng hoá</th>"
                            + "<th>ĐVT</th>"
                            + "<th>Số lượng</th>"
                            + "<th>Đơn giá</th>"
                            + "<th>Thành tiền</th>"
                        + "</tr>"
                     + "</thead>"
                     + "<tbody>" + tr
                     + "</tbody>"
                     + "</table><br>";

                var bodyTotal = GenrateReportTotal(DateTime.Now, DateTime.Now);
                if (bodyTotal != null)
                {
                    body += bodyTotal;
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void SendDeleteEmmail(HoaDon hoadon)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "" + User.Load(hoadon.NhanVienId).FullName.ToString() + " vừa xoá một hoá đơn trị giá " + hoadon.TongTien.ToString("N0");
                string tr = "";
                foreach (var item in hoadon.HangHoaCollection)
                {
                    tr += "<tr>";
                    tr += "<td>" + item.STT.ToString() + "</td>";
                    tr += "<td>" + item.TenHangHoa.ToString() + "</td>";
                    tr += "<td>" + item.DonViTinh.ToString() + "</td>";
                    tr += "<td>" + ToTrimmedString(item.SoLuong) + "</td>";
                    tr += "<td>" + item.DonGiaBan.ToString("#,##0") + "</td>";
                    tr += "<td>" + item.ThanhTienBan.ToString("#,##0") + "</td>";
                    tr += "</tr>";
                }
                string body = "Mã hoá đơn   : " + hoadon.MaHoaDon + "<br>";
                body += "Thời gian vào        : " + hoadon.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss") + "<br>";
                body += "Thời gian thanh toán : " + hoadon.ThoiGianThanhToan.ToString("dd/MM/yyyy HH:mm:ss") + "<br>";
                body += "Tên nhân viên   : " + User.Load(hoadon.NhanVienId).FullName.ToString() + "<br>";
                body += "Tên khách hàng  : " + KhachHang.Load(hoadon.KhachHangId).TenKhachHang.ToString() + "<br>";
                body += "Tổng tiền hàng  : " + hoadon.TongTienHang.ToString("#,##0") + "<br>";
                body += "Tiền thuế       : " + hoadon.TienThue.ToString("#,##0") + "<br>";
                body += "Giảm giá (%)    : " + hoadon.GiamGia.ToString("#,##0") + "<br>";
                body += "Trị giá giảm    : " + hoadon.TriGiaGiam.ToString("#,##0") + "<br>";
                body += "Tổng thanh toán : " + hoadon.TongTien.ToString("#,##0") + "<br>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void SendEmmailReportTotal(DateTime fromDate, DateTime toDate)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "Báo cáo doanh thu từ ngày " + fromDate.ToString("dd-MM-yyyy") + " đến ngày " + toDate.ToString("dd-MM-yyyy") + "";
                string body = "";

                var bodyTotal = GenrateReportTotal(fromDate, toDate);
                if (bodyTotal != null)
                {
                    body += bodyTotal;
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void SendEmmailPayment(Payment payment)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "" + User.Load(payment.NhanVienId).FullName + " vừa chi một phiếu chi trị giá " + payment.GiaTri.ToString("N0");
                string body = "";

                body += "Mã phiếu : " + payment.MaPhieu.ToString() + "<br>";
                body += "Ngày : " + payment.ThoiGian.ToString("dd/MM/yyyy") + "<br>";
                body += "Loại chi : " + PaymentType.Load(payment.PaymentTypeId).Ten.ToString() + "<br>";
                body += "Giá trị  : " + payment.GiaTri.ToString("N0") + "<br><br>";

                string tr = "";

                var bodyTotal = GenrateReportPayment(DateTime.Now, DateTime.Now);
                if (bodyTotal != null)
                {
                    body += bodyTotal;
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void SendEmmailDeletePayment(Payment payment)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "" + User.Load(payment.NhanVienId).FullName + " vừa xoá một phiếu chi trị giá " + payment.GiaTri.ToString("N0");
                string body = "";

                body += "Mã phiếu : " + payment.MaPhieu.ToString() + "<br>";
                body += "Ngày : " + payment.ThoiGian.ToString("dd/MM/yyyy") + "<br>";
                body += "Loại chi : " + PaymentType.Load(payment.PaymentTypeId).Ten.ToString() + "<br>";
                body += "Giá trị  : " + payment.GiaTri.ToString("N0") + "<br><br>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void SendEmmailPaymentTotal(DateTime fromDate, DateTime toDate)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "Báo cáo thu chi từ ngày " + fromDate.ToString("dd-MM-yyyy") + " đến ngày " + toDate.ToString("dd-MM-yyyy") + "";
                string body = "";
                string tr = "";

                var bodyTotal = GenrateReportPayment(fromDate, toDate);
                if (bodyTotal != null)
                {
                    body += bodyTotal;
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        public void SendEmmailReceipts(PhieuThu phieuThu)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "" + User.Load(phieuThu.NhanVienId).FullName + " vừa thu một phiếu thu trị giá " + phieuThu.GiaTri.ToString("N0");
                string body = "";

                body += "Mã phiếu : " + phieuThu.MaPhieu.ToString() + "<br>";
                body += "Ngày : " + phieuThu.ThoiGian.ToString("dd/MM/yyyy") + "<br>";
                body += "Loại thu : " + LoaiThu.Load(phieuThu.LoaiThuId).Ten.ToString() + "<br>";
                body += "Giá trị  : " + phieuThu.GiaTri.ToString("N0") + "<br><br>";

                string tr = "";

                var bodyTotal = GenrateReportReceipts(DateTime.Now, DateTime.Now);
                if (bodyTotal != null)
                {
                    body += bodyTotal;
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        public void SendEmmailDeleteReceipts(PhieuThu phieuThu)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "" + User.Load(phieuThu.NhanVienId).FullName + " vừa xoá một phiếu thu trị giá " + phieuThu.GiaTri.ToString("N0");
                string body = "";

                body += "Mã phiếu : " + phieuThu.MaPhieu.ToString() + "<br>";
                body += "Ngày : " + phieuThu.ThoiGian.ToString("dd/MM/yyyy") + "<br>";
                body += "Loại thu : " + LoaiThu.Load(phieuThu.LoaiThuId).Ten.ToString() + "<br>";
                body += "Giá trị  : " + phieuThu.GiaTri.ToString("N0") + "<br><br>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void SendEmmailReceiptsTotal(DateTime fromDate, DateTime toDate)
        {
            try
            {
                GlobalSettings.RefreshKey();
                var fromAddress = new MailAddress("dangphuocduy@gmail.com", GlobalSettings.COMPANYNAME);
                var toAddress = new MailAddress(GlobalSettings.EMAIL.Trim(), "To Name");
                const string fromPassword = "smthalnacttksxvz";
                string subject = "Báo cáo thu từ ngày " + fromDate.ToString("dd-MM-yyyy") + " đến ngày " + toDate.ToString("dd-MM-yyyy") + "";
                string body = "";
                string tr = "";

                var bodyTotal = GenrateReportReceipts(fromDate, toDate);
                if (bodyTotal != null)
                {
                    body += bodyTotal;
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
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

        public List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        public string GenrateReportTotal(DateTime fromDate, DateTime toDate)
        {
            try
            {
                string body = "";
                DataTable DataTableHoaDon = HoaDon.SelectDynamic("ThoiGianThanhToan BETWEEN '" + fromDate.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + toDate.ToString("yyyy-MM-dd 23:59:59") + "'", null).Tables[0];

                List<HoaDon> HoaDonCollection = new List<HoaDon>();
                HoaDonCollection = ConvertDataTable<HoaDon>(DataTableHoaDon);

                decimal tongThu = 0;
                foreach (var item in HoaDonCollection)
                {
                    tongThu += item.TongTien;
                }

                DataTable DataTablePayment = Payment.SelectDynamic("ThoiGian BETWEEN '" + fromDate.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + toDate.ToString("yyyy-MM-dd 23:59:59") + "'", null).Tables[0];
                List<Payment> PaymentCollection = new List<Payment>();
                PaymentCollection = ConvertDataTable<Payment>(DataTablePayment);

                decimal tongChi = 0;
                foreach (var item in PaymentCollection)
                {
                    tongChi += item.GiaTri;
                }

                DataTable DataTableReceipts = PhieuThu.SelectDynamic("ThoiGian BETWEEN '" + fromDate.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + toDate.ToString("yyyy-MM-dd 23:59:59") + "'", null).Tables[0];
                List<PhieuThu> PhieuThuCollection = new List<PhieuThu>();
                PhieuThuCollection = ConvertDataTable<PhieuThu>(DataTableReceipts);

                decimal tongPhieuThu = 0;
                foreach (var item in PhieuThuCollection)
                {
                    tongPhieuThu += item.GiaTri;
                }

                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                string TongThu = decimal.Parse(tongThu.ToString()).ToString("#,###", cultureInfo.NumberFormat);

                string TongChi = decimal.Parse(tongChi.ToString()).ToString("#,###", cultureInfo.NumberFormat);

                string TonQuy = decimal.Parse((tongThu + tongPhieuThu - tongChi).ToString()).ToString("#,###", cultureInfo.NumberFormat);

                string TongPhieuThu = decimal.Parse(tongPhieuThu.ToString()).ToString("#,###", cultureInfo.NumberFormat);

                body += "TỔNG THU HOÁ ĐƠN : " + TongThu + "<br>";
                body += "TỔNG PHIẾU THU : " + TongPhieuThu + "<br>";
                body += "TỔNG PHIẾU CHI : " + TongChi + "<br>";
                body += "TỒN QUỸ  : " + TonQuy + "<br>";
                body += "TỔNG HOÁ ĐƠN ĐÃ THANH TOÁN  : " + HoaDonCollection.Count.ToString() + "<br>";

                body += "<br>THỐNG KÊ CHI TIẾT SỐ LƯỢNG HÀNG HOÁ<br>";
                string trReportTotal = "";
                DataTable DataTableReport = HoaDon.SelectReportReport(fromDate.ToString("yyyy-MM-dd 00:00:00"), toDate.ToString("yyyy-MM-dd 23:59:59")).Tables[0];

                foreach (DataRow item in DataTableReport.Rows)
                {
                    trReportTotal += "<tr>";
                    trReportTotal += "<td>" + item["STT"] + "</td>";
                    trReportTotal += "<td>" + item["TenHangHoa"] + "</td>";
                    trReportTotal += "<td>" + item["DonViTinh"] + "</td>";
                    trReportTotal += "<td>" + Convert.ToDecimal(item["SoLuong"]).ToString("#,##0") + "</td>";
                    trReportTotal += "<td>" + Convert.ToDecimal(item["ThanhTien"]).ToString("#,##0") + "</td>";
                    trReportTotal += "</tr>";
                }

                body += "<table>"
                     + "<thead>"
                     + "<tr>"
                        + "<th>STT</th>"
                        + "<th>Tên hàng hoá</th>"
                        + "<th>ĐVT</th>"
                        + "<th>Số lượng</th>"
                        + "<th>Thành tiền</th>"
                     + "</tr>"
                     + "</thead>"
                     + "<tbody>" + trReportTotal
                     + "</tbody>"
                     + "</table>";

                return body;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }
        public string GenrateReportPayment(DateTime fromDate, DateTime toDate)
        {
            try
            {
                string body = "";
                DataTable DataTablePayment = Payment.SelectDynamic("ThoiGian BETWEEN '" + fromDate.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + toDate.ToString("yyyy-MM-dd 23:59:59") + "'", null).Tables[0];
                List<Payment> PaymentCollection = new List<Payment>();
                PaymentCollection = ConvertDataTable<Payment>(DataTablePayment);

                decimal tongChi = 0;
                foreach (var item in PaymentCollection)
                {
                    tongChi += item.GiaTri;
                }

                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");

                string TongChi = decimal.Parse(tongChi.ToString()).ToString("#,###", cultureInfo.NumberFormat);

                body += "TỔNG CHI : " + TongChi + "<br>";

                body += "<br>THỐNG KÊ CHI TIẾT DANH SÁCH CHI<br>";
                string trReportTotal = "";
                DataTable DataTableReport = Payment.SelectReportPaymentTotal(fromDate.ToString("yyyy-MM-dd 00:00:00"), toDate.ToString("yyyy-MM-dd 23:59:59")).Tables[0];
                foreach (DataRow item in DataTableReport.Rows)
                {
                    trReportTotal += "<tr>";
                    trReportTotal += "<td>" + item["STT"].ToString() + "</td>";
                    trReportTotal += "<td>" + item["LoaiChi"] + "</td>";
                    trReportTotal += "<td>" + item["SoLan"] + "</td>";
                    trReportTotal += "<td>" + Convert.ToDecimal(item["GiaTri"]).ToString("#,##0") + "</td>";
                    trReportTotal += "</tr>";
                }

                body += "<table>"
                     + "<thead>"
                     + "<tr>"
                        + "<th>STT</th>"
                        + "<th>Loại chi</th>"
                        + "<th>Số lần</th>"
                        + "<th>Giá trị</th>"
                     + "</tr>"
                     + "</thead>"
                     + "<tbody>" + trReportTotal
                     + "</tbody>"
                     + "</table>";

                return body;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        public string GenrateReportReceipts(DateTime fromDate, DateTime toDate)
        {
            try
            {
                string body = "";
                DataTable DataTableReceipts = PhieuThu.SelectDynamic("ThoiGian BETWEEN '" + fromDate.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + toDate.ToString("yyyy-MM-dd 23:59:59") + "'", null).Tables[0];
                List<PhieuThu> PhieuThuCollection = new List<PhieuThu>();
                PhieuThuCollection = ConvertDataTable<PhieuThu>(DataTableReceipts);

                decimal tongThu = 0;
                foreach (var item in PhieuThuCollection)
                {
                    tongThu += item.GiaTri;
                }

                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");

                string TongThu = decimal.Parse(tongThu.ToString()).ToString("#,###", cultureInfo.NumberFormat);

                body += "TỔNG THU : " + TongThu + "<br>";

                body += "<br>THỐNG KÊ CHI TIẾT DANH SÁCH THU<br>";
                string trReportTotal = "";
                DataTable DataTableReport = PhieuThu.SelectReportReceiptsTotal(fromDate.ToString("yyyy-MM-dd 00:00:00"), toDate.ToString("yyyy-MM-dd 23:59:59")).Tables[0];
                foreach (DataRow item in DataTableReport.Rows)
                {
                    trReportTotal += "<tr>";
                    trReportTotal += "<td>" + item["STT"].ToString() + "</td>";
                    trReportTotal += "<td>" + item["LoaiThu"] + "</td>";
                    trReportTotal += "<td>" + item["SoLan"] + "</td>";
                    trReportTotal += "<td>" + Convert.ToDecimal(item["GiaTri"]).ToString("#,##0") + "</td>";
                    trReportTotal += "</tr>";
                }

                body += "<table>"
                     + "<thead>"
                     + "<tr>"
                        + "<th>STT</th>"
                        + "<th>Loại thu</th>"
                        + "<th>Số lần</th>"
                        + "<th>Giá trị</th>"
                     + "</tr>"
                     + "</thead>"
                     + "<tbody>" + trReportTotal
                     + "</tbody>"
                     + "</table>";

                return body;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }
    }
}
