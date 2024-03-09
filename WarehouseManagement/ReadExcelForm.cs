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
using Janus.Windows.GridEX;
using System.Reflection;

namespace WarehouseManagement
{
    public partial class ReadExcelForm : BaseForm
    {
        List<HangHoa> HangHoaCollection = new List<HangHoa>();
        List<HangHoa> HangHoaInValidCollection = new List<HangHoa>();
        public List<HangHoa> HangHoaAllCollection = new List<HangHoa>();
        public ReadExcelForm()
        {
            InitializeComponent();
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoaCollection = new List<HangHoa>();
                HangHoaInValidCollection = new List<HangHoa>();
                HangHoaAllCollection = HangHoa.SelectCollectionAll();
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoaCollection = new List<HangHoa>();
                HangHoaInValidCollection = new List<HangHoa>();
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
                List<NhomHangHoa> NhomHangHoaCollection = new List<NhomHangHoa>();
                NhomHangHoaCollection = NhomHangHoa.SelectCollectionAll();
                foreach (WorksheetRow wsr in wsrc)
                {
                    if (wsr.Index >= 2)
                    {
                        try
                        {
                            HangHoa HangHoa = new HangHoa();
                            bool isAdd = true;
                            try
                            {
                                string TenNhomHangHoa = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("C"))].Value).ToLower().Trim();
                                HangHoa.NhomHangHoaId = NhomHangHoaCollection.FirstOrDefault(x => x.TenNhom.ToLower().Trim() == TenNhomHangHoa).Id;
                                if (HangHoa.NhomHangHoaId.ToString().Length == 0)
                                {
                                    isAdd = false;                                   
                                    //break;
                                }
                            }
                            catch (Exception)
                            {
                                isAdd = false;
                                HangHoa.GhiChu = "\nNhóm hàng hoá không tồn tại";
                                //break;
                            }
                            try
                            {
                                HangHoa.MaHangHoa = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("D"))].Value).Trim();
                                if (HangHoa.MaHangHoa.ToString().Length == 0)
                                {
                                    HangHoa.GhiChu += "\nMã hàng hoá không được để trống";
                                    isAdd = false;
                                    //break;
                                }
                                else
                                {
                                    bool isExits = false;
                                    isExits = HangHoaAllCollection.Any(x => x.MaHangHoa.ToLower().Trim() == HangHoa.MaHangHoa.ToLower().Trim());
                                    if (isExits)
                                    {
                                        HangHoa.GhiChu += "\nMã hàng hoá đã tồn tại";
                                        isAdd = false;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                isAdd = false;
                                HangHoa.GhiChu += "\nMã hàng hoá không hợp lệ";
                                //break;
                            }
                            try
                            {
                                HangHoa.TenHangHoa = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("E"))].Value).Trim();
                                if (HangHoa.TenHangHoa.ToString().Length == 0)
                                {
                                    HangHoa.GhiChu += "\nTên hàng hoá không được để trống";
                                    isAdd = false;
                                    //break;
                                }
                            }
                            catch (Exception)
                            {
                                HangHoa.GhiChu += "\nTên hàng hoá không hợp lệ";
                                isAdd = false;
                                //break;
                            }
                            try
                            {
                                HangHoa.DonGiaBan = Convert.ToDecimal(wsr.Cells[ConvertCharToInt(Convert.ToChar("F"))].Value);
                                if (HangHoa.DonGiaBan <= 0)
                                {
                                    HangHoa.GhiChu += "\nĐơn giá bán phải lớn hơn 0";
                                    isAdd = false;
                                    //break;
                                }
                            }
                            catch (Exception)
                            {
                                HangHoa.GhiChu += "\nĐơn giá bán không hợp lệ";
                                isAdd = false;
                                //break;
                            }
                            try
                            {
                                HangHoa.DonGiaNhap = Convert.ToDecimal(wsr.Cells[ConvertCharToInt(Convert.ToChar("G"))].Value);
                                if (HangHoa.DonGiaNhap <= 0)
                                {
                                    HangHoa.GhiChu += "\nĐơn giá nhập phải lớn hơn 0";
                                    isAdd = false;
                                    //break;
                                }
                            }
                            catch (Exception)
                            {
                                HangHoa.GhiChu += "\nĐơn giá nhập không hợp lệ";
                                isAdd = false;
                                //break;
                            }
                            try
                            {
                                HangHoa.DonViTinh = Convert.ToString(wsr.Cells[ConvertCharToInt(Convert.ToChar("K"))].Value).Trim();
                                if (HangHoa.DonViTinh.ToString().Length == 0)
                                {
                                    HangHoa.GhiChu += "\nĐơn vị tính không được để trống";
                                    isAdd = false;
                                    //break;
                                }
                            }
                            catch (Exception)
                            {
                                HangHoa.GhiChu += "\nĐơn giá tính không hợp lệ";
                                isAdd = false;
                                //break;
                            }
                            if (isAdd)
                            {
                                HangHoa.GhiChu = String.Empty;
                                HangHoaCollection.Add(HangHoa);
                            }
                            else
                            {
                                HangHoaInValidCollection.Add(HangHoa);
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

                workSheet.GetCell("C1").Value = "Nhóm hàng)";
                workSheet.GetCell("D1").Value = "Mã hàng";
                workSheet.GetCell("E1").Value = "Tên hàng hóa";
                workSheet.GetCell("F1").Value = "Giá bán";
                workSheet.GetCell("G1").Value = "Giá nhập";
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

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal DonGiaNhap = (decimal)e.Row.Cells["DonGiaNhap"].Value;
                    decimal DonGiaBan = (decimal)e.Row.Cells["DonGiaBan"].Value;
                    long NhomHangHoaId = (long)e.Row.Cells["NhomHangHoaId"].Value;
                    e.Row.Cells["DonGiaNhap"].Text = DonGiaNhap.ToString("#,##0");
                    e.Row.Cells["DonGiaBan"].Text = DonGiaBan.ToString("#,##0");
                    e.Row.Cells["NhomHangHoaId"].Text = NhomHangHoa.Load(NhomHangHoaId).TenNhom;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (HangHoaCollection.Count > 0)
                {
                    if (ShowMessage("Bạn có chắc chắn muốn nhập những hàng hoá hợp lệ này không?", true, false) == "Yes")
                    {
                        foreach (HangHoa item in HangHoaCollection)
                        {
                            item.InsertUpdate();
                            XuatNhapTon XuatNhapTon = new XuatNhapTon();
                            XuatNhapTon.MaHangHoa = item.MaHangHoa;
                            XuatNhapTon.TenHangHoa = item.TenHangHoa;
                            XuatNhapTon.NhomHangHoaId = item.NhomHangHoaId;
                            XuatNhapTon.DonGiaBan = item.DonGiaBan;
                            XuatNhapTon.DonGiaNhap = item.DonGiaNhap;
                            XuatNhapTon.DonViTinh = item.DonViTinh;
                            XuatNhapTon.GhiChu = item.GhiChu;
                            XuatNhapTon.InsertUpdate();
                        }
                    }
                    HangHoaCollection = new List<HangHoa>();
                    HangHoaInValidCollection = new List<HangHoa>();
                    BinDataImport();
                    BinDataInvalidImport();
                    ShowMessage("Lưu thông tin thành công", false, false);
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

        private void dgListInValid_LoadingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long NhomHangHoaId = (long)e.Row.Cells["NhomHangHoaId"].Value;
                    e.Row.Cells["NhomHangHoaId"].Text = NhomHangHoa.Load(NhomHangHoaId).TenNhom;
                }
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
    }
}
