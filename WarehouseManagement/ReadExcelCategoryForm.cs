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

namespace WarehouseManagement
{
    public partial class ReadExcelCategoryForm : BaseForm
    {
        public List<NhomHangHoa> NhomHangHoaCollection = new List<NhomHangHoa>();
        public List<NhomHangHoa> NhomHangHoaInValidCollection = new List<NhomHangHoa>();
        public List<NhomHangHoa> NhomHangHoaAllCollection = new List<NhomHangHoa>();

        public ReadExcelCategoryForm()
        {
            InitializeComponent();
        }

        private void ReadExcelCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                NhomHangHoaCollection = new List<NhomHangHoa>();
                NhomHangHoaInValidCollection = new List<NhomHangHoa>();
                NhomHangHoaAllCollection = NhomHangHoa.SelectCollectionAll();
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
                dgList.DataSource = NhomHangHoaCollection;
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
                dgListInValid.DataSource = NhomHangHoaInValidCollection;
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
                NhomHangHoaCollection = new List<NhomHangHoa>();
                NhomHangHoaInValidCollection = new List<NhomHangHoa>();
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
                NhomHangHoaAllCollection = NhomHangHoa.SelectCollectionAll();
                foreach (WorksheetRow wsr in wsrc)
                {
                    if (wsr.Index >= 1)
                    {
                        try
                        {
                            NhomHangHoa nhomHangHoa = new NhomHangHoa();
                            bool isAdd = true;
                            try
                            {
                                nhomHangHoa.TenNhom = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("A"))].Value);
                                if (nhomHangHoa.TenNhom.ToString().Length == 0)
                                {
                                    nhomHangHoa.GhiChu += "\nTên nhóm hàng hoá không được trống";
                                    isAdd = false;
                                }
                                else
                                {
                                    bool isExits = false;
                                    isExits = NhomHangHoaAllCollection.Any(x => x.TenNhom.ToLower().Trim() == nhomHangHoa.TenNhom.ToLower().Trim());
                                    if (isExits)
                                    {
                                        nhomHangHoa.GhiChu += "\nTên nhóm hàng hoá đã tồn tại";
                                        isAdd = false;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                isAdd = false;
                                nhomHangHoa.GhiChu += "\nTên nhóm hàng hoá không hợp lệ";
                            }
                            if (isAdd)
                            {
                                nhomHangHoa.GhiChu = String.Empty;
                                NhomHangHoaCollection.Add(nhomHangHoa);
                            }
                            else
                            {
                                NhomHangHoaInValidCollection.Add(nhomHangHoa);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (NhomHangHoaCollection.Count > 0)
                {
                    if (ShowMessage("Bạn có chắc chắn muốn nhập những nhóm hàng hoá hợp lệ này không?", true, false) == "Yes")
                    {
                        foreach (NhomHangHoa item in NhomHangHoaCollection)
                        {
                            item.InsertUpdate();
                        }
                    }
                    NhomHangHoaCollection = new List<NhomHangHoa>();
                    NhomHangHoaInValidCollection = new List<NhomHangHoa>();
                    BinDataImport();
                    BinDataInvalidImport();
                    ShowMessage("Lưu thông tin thành công", false, false);
                    this.Close();
                }
                else
                {
                    ShowMessage("Không có thông tin nhóm hàng hoá để nhập", false, false);
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
                string fileName = "MauFileNhomSanPham.xls";
                string pathTemplateFolder = AppDomain.CurrentDomain.BaseDirectory + "\\ExcelTemplate";
                if (!System.IO.Directory.Exists(pathTemplateFolder))
                    System.IO.Directory.CreateDirectory(pathTemplateFolder);

                string filePath = pathTemplateFolder + "\\" + fileName;

                if (System.IO.File.Exists(filePath))
                    System.Diagnostics.Process.Start(filePath);

                Infragistics.Excel.Workbook workBook = new Infragistics.Excel.Workbook(Infragistics.Excel.WorkbookFormat.Excel97To2003);
                Infragistics.Excel.Worksheet workSheet = workBook.Worksheets.Add("Sheet1");

                workSheet.GetCell("A1").Value = "Tên nhóm";

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách nhóm hàng hoá không hợp lệ_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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
    }
}
