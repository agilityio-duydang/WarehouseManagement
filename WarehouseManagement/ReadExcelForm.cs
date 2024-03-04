using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Excel;
using Company.WM.BLL;

namespace WarehouseManagement
{
    public partial class ReadExcelForm : BaseForm
    {        
        public ReadExcelForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog sf = new OpenFileDialog();
                sf.ShowDialog(this);
                txtFilePath.Text = sf.FileName;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                Workbook wb = new Workbook();

                Worksheet ws = null;
                try
                {
                    wb = Workbook.Load(txtFilePath.Text, true);
                }
                catch (Exception ex)
                {
                    ShowMessage("Lỗi khi đọc file. Doanh nghiệp hãy kiểm tra lại đường dẫn hoặc đóng file trước khi đọc.", false, false);
                    return;
                }
                try
                {
                    List<String> Collection = new List<string>();
                    foreach (Worksheet worksheet in wb.Worksheets)
                    {
                        Collection.Add(worksheet.Name);
                    }
                    ws = wb.Worksheets[Collection.FirstOrDefault().ToString()];
                }
                catch
                {
                    ShowMessage("Không tồn tại bất kỳ sheet nào", false, false);
                    return;
                }
                WorksheetRowCollection wsrc = ws.Rows;
                foreach (WorksheetRow wsr in wsrc)
                {
                    if (wsr.Index >= 2)
                    {
                        try
                        {
                            HangHoa HangHoa = new HangHoa();
                            try
                            {
                                HangHoa.TenHangHoa = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("A"))].Value);
                                if (HangHoa.TenHangHoa.ToString().Length == 0)
                                {
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                break;
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

        private int ConvertCharToInt(char ch)
        {
            return ch - 'A';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkFileExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateExcelTemplate();
        }

        public static void CreateExcelTemplate()
        {
            try
            {
                //Chọn đường dẫn file cần lưu
                string fileName = "MauFileSanPham.xls";
                string pathTemplateFolder = AppDomain.CurrentDomain.BaseDirectory + "\\ExcelTemplate";
                if (!System.IO.Directory.Exists(pathTemplateFolder))
                    System.IO.Directory.CreateDirectory(pathTemplateFolder);

                string filePath = pathTemplateFolder + "\\" + fileName;

                if (System.IO.File.Exists(filePath))
                    System.Diagnostics.Process.Start(filePath);

                Infragistics.Excel.Workbook workBook = new Infragistics.Excel.Workbook(Infragistics.Excel.WorkbookFormat.Excel97To2003);
                Infragistics.Excel.Worksheet workSheet = workBook.Worksheets.Add("Sheet1");

                workSheet.GetCell("A1").Value = "Loại hàng";
                workSheet.GetCell("B1").Value = "Loại thực đơn";
                workSheet.GetCell("C1").Value = "Nhóm hàng(3 Cấp)";
                workSheet.GetCell("D1").Value = "Mã hàng";
                workSheet.GetCell("E1").Value = "Tên hàng hóa";
                workSheet.GetCell("F1").Value = "Giá bán";
                workSheet.GetCell("G1").Value = "Giá vốn";
                workSheet.GetCell("H1").Value = "Tồn kho";
                workSheet.GetCell("I1").Value = "Tồn nhỏ nhất";
                workSheet.GetCell("J1").Value = "Tồn lớn nhất";
                workSheet.GetCell("K1").Value = "ĐVT";

                //Ghi nội dung file gốc vào file cần lưu
                Infragistics.Excel.BIFF8Writer.WriteWorkbookToFile(workBook, filePath);

                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                throw ex;
            }
        }
    }
}
