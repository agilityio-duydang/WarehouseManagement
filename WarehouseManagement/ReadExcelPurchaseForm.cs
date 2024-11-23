using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using Infragistics.Excel;
using Janus.Windows.GridEX;

namespace WarehouseManagement
{
    public partial class ReadExcelPurchaseForm : BaseForm
    {
        List<PhieuNhapKho_HangHoa> HangHoaCollection = new List<PhieuNhapKho_HangHoa>();
        List<PhieuNhapKho_HangHoa> HangHoaInValidCollection = new List<PhieuNhapKho_HangHoa>();
        public PhieuNhapKho PhieuNhapKho;

        public ReadExcelPurchaseForm()
        {
            InitializeComponent();
        }

        private void ReadExcelPurchaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoaCollection = new List<PhieuNhapKho_HangHoa>();
                HangHoaInValidCollection = new List<PhieuNhapKho_HangHoa>();
                BinDataImport();
                BinDataInvalidImport();
                OpenFileDialog sf = new OpenFileDialog();
                sf.ShowDialog(this);
                txtFilePath.Text = sf.FileName;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void BinDataImport()
        {
            try
            {
                dgList.Refetch();
                dgList.DataSource = HangHoaCollection;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void BinDataInvalidImport()
        {
            try
            {
                dgListInValid.Refetch();
                dgListInValid.DataSource = HangHoaInValidCollection;
                dgListInValid.Refresh();
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoaCollection = new List<PhieuNhapKho_HangHoa>();
                HangHoaInValidCollection = new List<PhieuNhapKho_HangHoa>();
                BinDataImport();
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
                List<HangHoa> AllHangHoaCollection = new List<HangHoa>();
                AllHangHoaCollection = HangHoa.SelectCollectionAll();
                foreach (WorksheetRow wsr in wsrc)
                {
                    if (wsr.Index >= 1)
                    {
                        try
                        {
                            PhieuNhapKho_HangHoa hangHoa = new PhieuNhapKho_HangHoa();
                            bool isAdd = true;
                            HangHoa HangHoaExits = null;
                            try
                            {
                                hangHoa.MaHangHoa = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("A"))].Value).Trim();
                                if (hangHoa.MaHangHoa.ToString().Length == 0)
                                {
                                    hangHoa.GhiChu += "\nMã hàng hoá không được để trống";
                                    isAdd = false;
                                }
                                else
                                {
                                    HangHoaExits = AllHangHoaCollection.Where(x => x.MaHangHoa.ToLower().Trim() == hangHoa.MaHangHoa.ToLower().Trim()).FirstOrDefault();
                                    if (HangHoaExits == null)
                                    {
                                        hangHoa.GhiChu += "\nMã hàng hoá không tồn tại";
                                        isAdd = false;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                isAdd = false;
                                hangHoa.GhiChu += "\nMã hàng hoá không hợp lệ";
                            }
                            if (HangHoaExits != null)
                            {
                                hangHoa.TenHangHoa = HangHoaExits.TenHangHoa;
                                hangHoa.NhomHangHoaId = HangHoaExits.NhomHangHoaId;
                                hangHoa.DonViTinh = HangHoaExits.DonViTinh;
                            }
                            try
                            {
                                hangHoa.SoLuong = Convert.ToDecimal(wsr.Cells[ConvertCharToInt(Convert.ToChar("B"))].Value);
                                if (hangHoa.SoLuong <= 0)
                                {
                                    hangHoa.GhiChu += "\nĐơn giá nhập phải lớn hơn 0";
                                    isAdd = false;
                                }
                            }
                            catch (Exception)
                            {
                                hangHoa.GhiChu += "\nĐơn giá nhập không hợp lệ";
                                isAdd = false;
                            }
                            try
                            {
                                hangHoa.DonGia = Convert.ToDecimal(wsr.Cells[ConvertCharToInt(Convert.ToChar("C"))].Value);
                                if (hangHoa.DonGia <= 0)
                                {
                                    hangHoa.GhiChu += "\nĐơn giá nhập phải lớn hơn 0";
                                    isAdd = false;
                                }
                            }
                            catch (Exception)
                            {
                                hangHoa.GhiChu += "\nĐơn giá nhập không hợp lệ";
                                isAdd = false;
                            }
                            try
                            {
                                hangHoa.ThanhTien = Convert.ToDecimal(wsr.Cells[ConvertCharToInt(Convert.ToChar("D"))].Value);
                                if (hangHoa.ThanhTien <= 0)
                                {
                                    hangHoa.GhiChu += "\nThành tiền phải lớn hơn 0";
                                    isAdd = false;
                                }
                            }
                            catch (Exception)
                            {
                                hangHoa.GhiChu += "\nThành tiền không hợp lệ";
                                isAdd = false;
                            }
                            if (isAdd)
                            {
                                hangHoa.GhiChu = String.Empty;
                                HangHoaCollection.Add(hangHoa);
                            }
                            else
                            {
                                HangHoaInValidCollection.Add(hangHoa);
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.LocalLogger.Instance().WriteMessage(ex);
                        }
                    }
                }
                BinDataImport();
                BinDataInvalidImport();
                ShowMessage("Đọc thông tin thành công", false, false);
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách hàng hoá không hợp lệ_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
                sfNPL.Filter = "Excel files| *.xls";
                if (ShowMessage("Bạn có muốn xuất thông tin này ra File Excel không? ", true, false) == "Yes")
                {
                    if (sfNPL.ShowDialog(this) == DialogResult.OK && sfNPL.FileName != "")
                    {

                        Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter();
                        gridEXExporter1.GridEX = dgListInValid;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (HangHoaCollection.Count > 0)
                {
                    if (ShowMessage("Bạn có chắc chắn muốn nhập những hàng hoá hợp lệ này không?", true, false) == "Yes")
                    {
                        PhieuNhapKho.HangHoaCollection = HangHoaCollection;
                    }
                    HangHoaCollection = new List<PhieuNhapKho_HangHoa>();
                    HangHoaInValidCollection = new List<PhieuNhapKho_HangHoa>();
                    BinDataImport();
                    BinDataInvalidImport();
                    ShowMessage("Nhập thông tin thành công", false, false);
                    this.Close();
                }
                else
                {
                    ShowMessage("Không có thông tin hàng hoá để nhập", false, false);
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

        private void linkFileExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateExcelTemplate();
        }

        public static void CreateExcelTemplate()
        {
            try
            {
                //Chọn đường dẫn file cần lưu
                string fileName = "MauFileNhapKhoSanPham.xls";
                string pathTemplateFolder = AppDomain.CurrentDomain.BaseDirectory + "\\ExcelTemplate";
                if (!System.IO.Directory.Exists(pathTemplateFolder))
                    System.IO.Directory.CreateDirectory(pathTemplateFolder);

                string filePath = pathTemplateFolder + "\\" + fileName;

                if (System.IO.File.Exists(filePath))
                    System.Diagnostics.Process.Start(filePath);

                Infragistics.Excel.Workbook workBook = new Infragistics.Excel.Workbook(Infragistics.Excel.WorkbookFormat.Excel97To2003);
                Infragistics.Excel.Worksheet workSheet = workBook.Worksheets.Add("Sheet1");

                workSheet.GetCell("A1").Value = "Mã hàng";
                workSheet.GetCell("B1").Value = "Số lượng";
                workSheet.GetCell("C1").Value = "Đơn giá";
                workSheet.GetCell("D1").Value = "Thành tiền";

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
        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal DonGia = (decimal)e.Row.Cells["DonGia"].Value;
                    decimal ThanhTien = (decimal)e.Row.Cells["ThanhTien"].Value;
                    e.Row.Cells["DonGia"].Text = DonGia.ToString("#,#.0000#");
                    e.Row.Cells["ThanhTien"].Text = ThanhTien.ToString("#,#.0000#");
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListInValid_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal DonGia = (decimal)e.Row.Cells["DonGia"].Value;
                    decimal ThanhTien = (decimal)e.Row.Cells["ThanhTien"].Value;
                    e.Row.Cells["DonGia"].Text = DonGia.ToString("#,#.0000#");
                    e.Row.Cells["ThanhTien"].Text = ThanhTien.ToString("#,#.0000#");
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
