using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Company.WM.BLL;
using System.Globalization;
using Janus.Windows.GridEX;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
    public partial class SupplierForm : BaseForm
    {
        public NhaCungCap NhaCungCap;
        public List<PhieuNhapKho> PhieuNhapKhoCollection = new List<PhieuNhapKho>();
        public List<CongNoNhaCungCap> CongNoNhaCungCapCollection = new List<CongNoNhaCungCap>();
        public List<Payment> PaymentCollection = new List<Payment>();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (NhaCungCap != null)
                {
                    if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Suppliers.Edit)))
                    {
                        btnSave.Enabled = false;
                    }
                    SetSupplier();
                    PhieuNhapKhoCollection = PhieuNhapKho.SelectCollectionBy_NhaCungCapId(NhaCungCap.Id);
                    CongNoNhaCungCapCollection = CongNoNhaCungCap.SelectCollectionBy_NhaCungCapId(NhaCungCap.Id);
                    PaymentCollection = Payment.SelectCollectionBy_NhaCungCapId(NhaCungCap.Id);
                    CaculatorData();
                    LoadHistory();
                    LoadDebt();
                    LoadPaymentHistory();
                }
                else
                {
                    NhaCungCap = new NhaCungCap();
                    txtMa.Text = GetMaNhaCungCap().ToString();
                    tabHistory.Enabled = false;
                    tabDept.Enabled = false;
                    tabPayment.Enabled = false;
                }
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
                //decimal TotalTongThanhToan = 0;
                decimal TotalTongConNo = 0;
                decimal TotalChi = 0;
                //decimal TotalGiamGia = 0;
                foreach (PhieuNhapKho item in PhieuNhapKhoCollection)
                {
                    TotalTongTien += item.TongTien;
                    //TotalTongThanhToan += item.TongDaThanhToan;
                    //TotalTongConNo += item.TongConNo;
                    //TotalChiPhiNhap += item.ChiPhiNhap;
                    //TotalGiamGia += item.GiamGia;
                }
                foreach (CongNoNhaCungCap item in CongNoNhaCungCapCollection)
                {
                    TotalTongConNo += item.TongConNo;
                }

                foreach (Payment item in PaymentCollection)
                {
                    TotalChi += item.GiaTri;
                }

                txtTongTien.Text = TotalTongTien.ToString();
                txtTongChi.Text = TotalChi.ToString();
                txtTongConNo.Text = TotalTongConNo.ToString();
                //txtTongChiPhiNhap.Text = TotalChiPhiNhap.ToString();
                //txtTongGiamGia.Text = TotalGiamGia.ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadPaymentHistory()
        {
            try
            {
                dgListPayment.Refetch();
                dgListPayment.DataSource = PaymentCollection;
                dgListPayment.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadHistory()
        {
            try
            {
                dgList.Refetch();
                dgList.DataSource = PhieuNhapKhoCollection;
                dgList.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void LoadDebt()
        {
            try
            {
                dgListDebt.Refetch();
                dgListDebt.DataSource = CongNoNhaCungCapCollection;
                dgListDebt.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void GetSupplier()
        {
            try
            {
                NhaCungCap.MaNhaCungCap = txtMa.Text.ToString();
                NhaCungCap.TenNhaCungCap = txtTen.Text.ToString().Trim();
                NhaCungCap.DiaChi = txtDiaChi.Text.ToString().Trim();
                NhaCungCap.SoDienThoai = txtSoDienThoai.Text.ToString().Trim();
                NhaCungCap.Email = txtEmail.Text.ToString().Trim();
                NhaCungCap.GhiChu = txtGhiChu.Text.ToString().Trim();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private string GetMaNhaCungCap()
        {
            try
            {
                string MaNhaCungCap = string.Empty;
                List<NhaCungCap> NhaCungCapCollection = NhaCungCap.SelectCollectionAll();
                if (NhaCungCapCollection.Count == 0)
                {
                    MaNhaCungCap = "NCC0000000001";
                }
                else
                {
                    var LastNhaCungCap = NhaCungCapCollection.Last();
                    var NumberNhaCungCap = Convert.ToInt32(LastNhaCungCap.MaNhaCungCap.Substring(3, 10));
                    if (NumberNhaCungCap >= 0 && NumberNhaCungCap < 9)
                    {
                        MaNhaCungCap = "NCC000000000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 9 && NumberNhaCungCap < 99)
                    {
                        MaNhaCungCap = "NCC00000000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 99 && NumberNhaCungCap < 999)
                    {
                        MaNhaCungCap = "NCC0000000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 999 && NumberNhaCungCap < 9999)
                    {
                        MaNhaCungCap = "NCC000000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 9999 && NumberNhaCungCap < 99999)
                    {
                        MaNhaCungCap = "NCC00000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 99999 && NumberNhaCungCap < 999999)
                    {
                        MaNhaCungCap = "NCC0000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 999999 && NumberNhaCungCap < 9999999)
                    {
                        MaNhaCungCap = "NCC000" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 9999999 && NumberNhaCungCap < 99999999)
                    {
                        MaNhaCungCap = "NCC00" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 99999999 && NumberNhaCungCap < 999999999)
                    {
                        MaNhaCungCap = "NCC0" + (NumberNhaCungCap + 1);
                    }
                    else if (NumberNhaCungCap >= 999999999 && NumberNhaCungCap < 9999999999)
                    {
                        MaNhaCungCap = "NCC" + (NumberNhaCungCap + 1);
                    }
                }
                return MaNhaCungCap;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return null;
            }
        }

        private void SetSupplier()
        {
            try
            {
                txtMa.Text = NhaCungCap.MaNhaCungCap.ToString();
                txtTen.Text = NhaCungCap.TenNhaCungCap.ToString();
                txtDiaChi.Text = NhaCungCap.DiaChi.ToString();
                txtEmail.Text = NhaCungCap.Email.ToString();
                txtSoDienThoai.Text = NhaCungCap.SoDienThoai.ToString();
                txtGhiChu.Text = NhaCungCap.GhiChu.ToString();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtTen, errorProvider, "Tên nhà cung cấp", isOnlyWarning);
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm(false))
                    return;
                GetSupplier();
                NhaCungCap.InsertUpdate();
                ShowMessage("Lưu thông tin thành công", false, false);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgList_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal TongTien = (decimal)e.Row.Cells["TongTien"].Value;
                    e.Row.Cells["TongTien"].Text = TongTien.ToString("#,##0");

                    //decimal TongDaThanhToan = (decimal)e.Row.Cells["TongDaThanhToan"].Value;
                    //e.Row.Cells["TongDaThanhToan"].Text = TongDaThanhToan.ToString("#,##0");

                    //decimal TongConNo = (decimal)e.Row.Cells["TongConNo"].Value;
                    //e.Row.Cells["TongConNo"].Text = TongConNo.ToString("#,##0");

                    decimal ChiPhiNhap = (decimal)e.Row.Cells["ChiPhiNhap"].Value;
                    e.Row.Cells["ChiPhiNhap"].Text = ChiPhiNhap.ToString("#,##0");

                    decimal GiamGia = (decimal)e.Row.Cells["GiamGia"].Value;
                    e.Row.Cells["GiamGia"].Text = GiamGia.ToString("#,##0");

                    long NhanVienId = Convert.ToInt64(e.Row.Cells["NhanVienId"].Value);
                    e.Row.Cells["NhanVienId"].Text = User.Load(NhanVienId).FullName;
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

        private void dgListDebt_LoadingRow(object sender, RowLoadEventArgs e)
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

                    long PhieuNhapKhoId = Convert.ToInt64(e.Row.Cells["PhieuNhapKhoId"].Value);
                    e.Row.Cells["PhieuNhapKhoId"].Text = PhieuNhapKho.Load(PhieuNhapKhoId).MaPhieu;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListPayment_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    Payment Payment = Payment.Load(id);
                    PaymentForm f = new PaymentForm();
                    f.Payment = Payment;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListPayment_LoadingRow(object sender, RowLoadEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    decimal GiaTri = (decimal)e.Row.Cells["GiaTri"].Value;
                    long PaymentTypeId = (long)e.Row.Cells["PaymentTypeId"].Value;
                    e.Row.Cells["GiaTri"].Text = GiaTri.ToString("#,##0");
                    e.Row.Cells["PaymentTypeId"].Text = PaymentType.Load(PaymentTypeId).Ten;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void dgListDebt_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            try
            {
                if (e.Row.RowType == RowType.Record)
                {
                    long id = Convert.ToInt64(e.Row.Cells["Id"].Value);
                    CongNoNhaCungCap CongNoNhaCungCap = CongNoNhaCungCap.Load(id);
                    DebtPaymentSupplierForm f = new DebtPaymentSupplierForm();
                    f.CongNoNhaCungCap = CongNoNhaCungCap;
                    f.ShowDialog(this);
                }
                LoadDebt();
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
                sfNPL.FileName = "Danh sách lịch sử nhập trả hàng_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
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

        private void btnExportDept_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách nợ cần trả NCC_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
                sfNPL.Filter = "Excel files| *.xls";
                if (ShowMessage("Bạn có muốn xuất thông tin này ra File Excel không? ", true, false) == "Yes")
                {
                    if (sfNPL.ShowDialog(this) == DialogResult.OK && sfNPL.FileName != "")
                    {

                        Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter();
                        gridEXExporter1.GridEX = dgListDebt;
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

        private void btnExportReceipts_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfNPL = new SaveFileDialog();
                sfNPL.FileName = "Danh sách lịch sử chi nhà cung cấp_" + DateTime.Today.ToString("dd/MM/yyyy").Replace("/", "_") + ".xls";
                sfNPL.Filter = "Excel files| *.xls";
                if (ShowMessage("Bạn có muốn xuất thông tin này ra File Excel không? ", true, false) == "Yes")
                {
                    if (sfNPL.ShowDialog(this) == DialogResult.OK && sfNPL.FileName != "")
                    {

                        Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter();
                        gridEXExporter1.GridEX = dgListPayment;
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
