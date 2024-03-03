using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Globalization;
using System.Net;

namespace WarehouseManagement
{
   public class GlobalSettings
    {
        public static string DATABASE_NAME;
        public static string USER;
        public static string PASS;
        public static string SERVER_NAME;
        public static string NGAYSAOLUU;
        public static string NHAC_NHO_SAO_LUU;
        public static string LAST_BACKUP;
        public static string PATH_BACKUP;
        public static string COMPANYNAME;
        public static string ADDRESS;
        public static string PHONENUMBER;
        public static string LOAIPHIEU;
        public static string HOADON;
        public static string TENTHUE;
        public static string TENNHANVIEN;
        public static string EMAIL;
        public static bool PREVIEW;
        public static string NOTE1;
        public static string NOTE2;
        public static string NOTE3;
        public static string NOTE4;
        public static string NOTE5;
        public static string NGON_NGU;
        static int _timeoutBackup = 30;
        public static bool IsDesign = false;
        public static int TimeoutBackup
        {
            get { return _timeoutBackup; }
            set { _timeoutBackup = value; }
        }
        public static List<string> ListTableNameSource = new List<string>();
       public static void Refreskey()
       {
           try
           {
               //Get thong tin Server
               SERVER_NAME = ConfigConecionForm.ReadNodeXmlAppSettings("SERVER_NAME");
               //Get thong tin Database
               DATABASE_NAME = ConfigConecionForm.ReadNodeXmlAppSettings("DATABASE_NAME");
               //Get thong tin UserName
               USER = ConfigConecionForm.ReadNodeXmlAppSettings("USER");
               //Get thong tin PassWord
               PASS = ConfigConecionForm.ReadNodeXmlAppSettings("PASS");
               NGAYSAOLUU = ConfigConecionForm.ReadNodeXmlAppSettings("NGAYSAOLUU");
               NHAC_NHO_SAO_LUU = ConfigConecionForm.ReadNodeXmlAppSettings("NHAC_NHO_SAO_LUU");
               LAST_BACKUP = ConfigConecionForm.ReadNodeXmlAppSettings("LAST_BACKUP");
               PATH_BACKUP = ConfigConecionForm.ReadNodeXmlAppSettings("PATH_BACKUP");
               COMPANYNAME = ConfigConecionForm.ReadNodeXmlAppSettings("COMPANYNAME");
               ADDRESS = ConfigConecionForm.ReadNodeXmlAppSettings("ADDRESS");
               PHONENUMBER = ConfigConecionForm.ReadNodeXmlAppSettings("PHONENUMBER");
               LOAIPHIEU = ConfigConecionForm.ReadNodeXmlAppSettings("LOAIPHIEU");
               HOADON = ConfigConecionForm.ReadNodeXmlAppSettings("HOADON");
               TENTHUE = ConfigConecionForm.ReadNodeXmlAppSettings("TENTHUE");
               TENNHANVIEN = ConfigConecionForm.ReadNodeXmlAppSettings("TENNHANVIEN");
               EMAIL = ConfigConecionForm.ReadNodeXmlAppSettings("EMAIL");
               PREVIEW = Convert.ToBoolean(ConfigConecionForm.ReadNodeXmlAppSettings("PREVIEW"));
               NOTE1 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE1");
               NOTE2 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE2");
               NOTE3 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE3");
               NOTE4 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE4");
               NOTE5 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE5");
               NGON_NGU = ConfigConecionForm.ReadNodeXmlAppSettings("NGON_NGU");
               IsDesign = Convert.ToBoolean(ConfigConecionForm.ReadNodeXmlAppSettings("IsDesign"));
           }
           catch (Exception ex)
           {
               Logger.LocalLogger.Instance().WriteMessage(ex);
               //throw;
           }
       }

       internal static void RefreshKey()
       {
           //Get thong tin Server
           SERVER_NAME = ConfigConecionForm.ReadNodeXmlAppSettings("SERVER_NAME");
           //Get thong tin Database
           DATABASE_NAME = ConfigConecionForm.ReadNodeXmlAppSettings("DATABASE_NAME");
           //Get thong tin UserName
           USER = ConfigConecionForm.ReadNodeXmlAppSettings("USER");
           //Get thong tin PassWord
           PASS = ConfigConecionForm.ReadNodeXmlAppSettings("PASS");
           NGAYSAOLUU = ConfigConecionForm.ReadNodeXmlAppSettings("NGAYSAOLUU");
           NHAC_NHO_SAO_LUU = ConfigConecionForm.ReadNodeXmlAppSettings("NHAC_NHO_SAO_LUU");
           LAST_BACKUP = ConfigConecionForm.ReadNodeXmlAppSettings("LAST_BACKUP");
           PATH_BACKUP = ConfigConecionForm.ReadNodeXmlAppSettings("PATH_BACKUP");
           COMPANYNAME = ConfigConecionForm.ReadNodeXmlAppSettings("COMPANYNAME");
           ADDRESS = ConfigConecionForm.ReadNodeXmlAppSettings("ADDRESS");
           PHONENUMBER = ConfigConecionForm.ReadNodeXmlAppSettings("PHONENUMBER");
           LOAIPHIEU = ConfigConecionForm.ReadNodeXmlAppSettings("LOAIPHIEU");
           HOADON = ConfigConecionForm.ReadNodeXmlAppSettings("HOADON");
           TENTHUE = ConfigConecionForm.ReadNodeXmlAppSettings("TENTHUE");
           TENNHANVIEN = ConfigConecionForm.ReadNodeXmlAppSettings("TENNHANVIEN");
           EMAIL = ConfigConecionForm.ReadNodeXmlAppSettings("EMAIL");
           PREVIEW = Convert.ToBoolean(ConfigConecionForm.ReadNodeXmlAppSettings("PREVIEW"));
           NOTE1 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE1");
           NOTE2 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE2");
           NOTE3 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE3");
           NOTE4 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE4");
           NOTE5 = ConfigConecionForm.ReadNodeXmlAppSettings("NOTE5");
           NGON_NGU = ConfigConecionForm.ReadNodeXmlAppSettings("NGON_NGU");
           //IsDesign = Convert.ToBoolean(ConfigConecionForm.ReadNodeXmlAppSettings("NGON_NGU"));
       }
       public static string GetDot(int decimalFormat, bool batBuocSoThapPhan)
       {
           string ret = string.Empty;
           if (decimalFormat < 0) return ret;
           else if (decimalFormat > 0)
               ret += ".";
           for (int i = 0; i < decimalFormat; i++)
           {
               if (!batBuocSoThapPhan)
                   ret += "#";
               else
                   ret += "0";
           }
           return ret;
       }
       /// <summary>
       /// Format dữ liệu chuẩn tiếng anh.
       /// </summary>
       /// <param name="obj"></param>
       /// <param name="decimalFormat"></param>
       /// <returns></returns>
       public static string FormatNumeric(object obj, int decimalFormat, CultureInfo cultureInfo)
       {
           string ret = string.Empty;
           if (obj == null) return ret;

           string sFormat = "{0:0" + GetDot(decimalFormat, false) + "}";

           if (obj is bool)
           {
               bool b = Convert.ToBoolean(obj, cultureInfo);
               ret = b ? "1" : "0";
           }
           else
           {
               ret = string.Format(cultureInfo, sFormat, new object[] { obj });
           }
           return ret;
       }
       public static void CreateExcelTemplate()
       {
           //try
           //{

           //    //Chọn đường dẫn file cần lưu
           //    string fileName = "Danh sách thuê bao đăng ký hòa mạng.xls";
           //    string pathTemplateFolder = AppDomain.CurrentDomain.BaseDirectory + "\\ExcelTemplate";
           //    if (!System.IO.Directory.Exists(pathTemplateFolder))
           //        System.IO.Directory.CreateDirectory(pathTemplateFolder);

           //    string filePath = pathTemplateFolder + "\\" + fileName;

           //    if (System.IO.File.Exists(filePath))
           //        System.Diagnostics.Process.Start(filePath);

           //    Infragistics.Excel.Workbook workBook = new Infragistics.Excel.Workbook(Infragistics.Excel.WorkbookFormat.Excel97To2003);
           //    Infragistics.Excel.Worksheet workSheet = workBook.Worksheets.Add("Sheet1");

           //    workSheet.GetCell("A1").Value = "Số thuê bao";
           //    workSheet.GetCell("B1").Value = "Serial";
           //    workSheet.GetCell("C1").Value = "Đối tượng sử dụng";
           //    workSheet.GetCell("D1").Value = "Họ tên ";
           //    workSheet.GetCell("E1").Value = "Số CMND";
           //    workSheet.GetCell("F1").Value = "Nơi cấp";
           //    workSheet.GetCell("G1").Value = "Gói cước đăng ký";
           //    workSheet.GetCell("H1").Value = "Hạn mức đăng ký gói cước";
           //    workSheet.GetCell("I1").Value = "Phí tham gia gói cước";
           //    workSheet.GetCell("J1").Value = "Thời gian cam kết sử dụng";

           //    //Ghi nội dung file gốc vào file cần lưu
           //    Infragistics.Excel.BIFF8Writer.WriteWorkbookToFile(workBook, filePath);

           //    System.Diagnostics.Process.Start(filePath);
           //}
           //catch (Exception ex)
           //{
           //    Logger.LocalLogger.Instance().WriteMessage(ex);
           //    throw ex;
           //}
       }

       public static string GetLocalIPAddress()
       {
           string localIP = "127.0.0.1";
           try
           {
               System.Net.IPHostEntry host;
               host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
               foreach (System.Net.IPAddress ip in host.AddressList)
               {
                   if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                   {
                       localIP = ip.ToString();
                       break;
                   }
               }
           }
           catch (Exception ex)
           {
               Logger.LocalLogger.Instance().WriteMessage(ex);
           }

           return localIP;
       }
    }
}
