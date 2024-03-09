using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WarehouseManagement;
using Company.WM.BLL.Administration;
using WarehouseManagement.Administration;
using WarehouseManagement.WareHouse;

namespace WarehouseManagement
{
    public partial class MainForm : BaseForm
    {
        public static bool isLoginSuccess = false;
        public static User user;

        #region Quản trị
        public static ECSPrincipal EcsQuanTri;
        public static Principal QuanTri;
        #endregion Quản trị

        public MainForm()
        {
            InitializeComponent();
            GlobalSettings.RefreshKey();
        }

        private void cmdMain_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            switch (e.Command.Key)
            {
                case "cmdBackupDatabase":
                    this.BackupDatabase();
                    break;
                case "cmdConfigConnection":
                    this.ConfigConnection();
                    break;
                case "cmdUser":
                    this.ManagementUser();
                    break;
                case "cmdManagementUserGroup":
                    this.ManagementUserGroup();
                    break;
                case "cmdChangePassword":
                    this.ChangePassword();
                    break;
                case "cmdLoginUser":
                    this.Logout();
                    break;
                case "cmdExit":
                    if (ShowMessage("Bạn có muốn thoát phần mềm không ?", true, false) == "Yes")
                    {
                        Application.Exit();
                    }
                    break;
                case "cmdConfigSystem":
                    this.ConfigSystem();
                    break;
                case "cmdLog":
                    System.Diagnostics.Process.Start(Application.StartupPath + "\\Error.log");
                    break;
                case "cmdSQLQuery":
                    this.SQLQuery();
                    break;
                case "cmdCloseMe":
                    this.doCloseMe();
                    break;
                case "cmdCloseAllButMe":
                    this.doCloseAllButMe();
                    break;
                case "cmdCloseAll":
                    this.doCloseAll();
                    break;
            }
        }

        private void doCloseMe()
        {
            Form form = pnMain.MdiTabGroups[0].SelectedTab.Form;
            form.Close();
        }

        private void doCloseAllButMe()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] != pnMain.MdiTabGroups[0].SelectedTab.Form)
                {
                    forms[i].Close();
                }
            }
        }

        private void doCloseAll()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                forms[i].Close();
            }
        }

        private void ManagementUser()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("ManagementUserForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            ManagementUserForm f = new ManagementUserForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ManagementUserGroup()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("ManagementUserGroupForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            ManagementUserGroupForm f = new ManagementUserGroupForm();
            f.MdiParent = this;
            f.Show();
        }
        private void ChangePassword()
        {
            ChangePassword f = new ChangePassword();
            f.user = user;
            f.ShowDialog(this);
        }

        private void Logout()
        {
            this.Hide();
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                forms[i].Close();
            }
            MainForm.EcsQuanTri = null;
            isLoginSuccess = false;
            Login login = new Login();
            login.ShowDialog(this);
            if (isLoginSuccess)
            {
                user = User.Load(((SiteIdentity)MainForm.EcsQuanTri.Identity).user.ID);
                CheckShowPanelPermission();
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void SQLQuery()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("SQLQueryForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }

            SQLQueryForm f = new SQLQueryForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ConfigSystem()
        {
            ConfigSystemForm f = new ConfigSystemForm();
            f.ShowDialog(this);
        }

        private void ConfigConnection()
        {
            ConfigConecionForm f = new ConfigConecionForm();
            f.ShowDialog(this);
        }

        private void BackupDatabase()
        {
            BackupAndRestoreForm f = new BackupAndRestoreForm();
            f.ShowDialog(this);
        }

        private void explorerBarProducts_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                case "cmdAddCategory":
                    this.ShowCategoryForm();
                    break;
                case "cmdCategoryManagement":
                    this.ShowCategoryManagement();
                    break;
                case "cmdAddProduct":
                    this.ShowProduct();
                    break;
                case "cmdProductManagement":
                    this.ShowProductManagement();
                    break;
                default:
                    break;
            }
        }

        private void ShowProductManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("ProductManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            ProductManagementForm f = new ProductManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ShowProduct()
        {
            ProductForm f = new ProductForm();
            f.ShowDialog(this);
        }
        private void ShowCategoryForm()
        {
            CategoryForm f = new CategoryForm();
            f.ShowDialog(this);
        }

        private void ShowCategoryManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("CategoryManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            CategoryManagementForm f = new CategoryManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void explorerBarCashFlow_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                case "cmdXuatNhapTonManagement":
                    this.XuatNhapTonManagement();
                    break;
                case "cmdSupplier":
                    this.Supplier();
                    break;
                case "cmdSupplierManagement":
                    this.SupplierManagement();
                    break;
                case "cmdWareHouse":
                    this.WareHouse();
                    break;
                case "cmdWareHouseManagement":
                    this.WareHouseManagement();
                    break;
                case "cmdImport":
                    this.Import();
                    break;
                case "cmdImportManagement":
                    this.ImportManagement();
                    break;
                default:
                    break;
            }
        }

        private void ImportManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("PurchaseManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }

            PurchaseManagementForm f = new PurchaseManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void Import()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("PurchaseForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            PurchaseForm f = new PurchaseForm();
            f.user = user;
            f.MdiParent = this;
            f.Show();
        }

        private void XuatNhapTonManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("InventoryManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            InventoryManagementForm f = new InventoryManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void WareHouseManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("WareHouseManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            WareHouseManagementForm f = new WareHouseManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void WareHouse()
        {
            WareHouseForm f = new WareHouseForm();
            f.ShowDialog(this);
        }

        private void SupplierManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("SupplierManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            SupplierManagementForm f = new SupplierManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void Supplier()
        {
            SupplierForm f = new SupplierForm();
            f.ShowDialog(this);
        }

        private void PaymentManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("PaymentManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            PaymentManagementForm f = new PaymentManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void PaymentType()
        {
            PaymentTypeForm f = new PaymentTypeForm();
            f.ShowDialog(this);
        }

        private void PaymentTypeManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("PaymentTypeManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            PaymentTypeManagementForm f = new PaymentTypeManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void Payment()
        {
            PaymentForm f = new PaymentForm();
            f.User = user;
            f.ShowDialog(this);
        }

        private void CashFlowManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("CashFlowManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            CashFlowManagementForm f = new CashFlowManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void explorerBarCashier_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                case "cmdCashier":
                    this.ShowCashier();
                    break;
                case "cmdCustomer":
                    this.ShowCustomer();
                    break;
                case "cmdCustomerManagement":
                    this.ShowCustomerManagement();
                    break;
                case "cmdDebtManagement":
                    this.DebtManagement();
                    break;
                    
                default:
                    break;
            }
        }

        private void DebtManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("DebtManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            DebtManagementForm f = new DebtManagementForm();
            f.MdiParent = this;
            f.Show();
        }


        private void ShowCustomer()
        {
            CustomerForm f = new CustomerForm();
            f.ShowDialog(this);
        }

        private void ShowCustomerManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("CustomerManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            CustomerManagementForm f = new CustomerManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ShowCashier()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("CashierForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            CashierForm f = new CashierForm();
            f.user = user;
            f.MdiParent = this;
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog(this);
            if (isLoginSuccess)
            {
                user = User.Load(((SiteIdentity)MainForm.EcsQuanTri.Identity).user.ID);
                CheckShowPanelPermission();
                this.Show();
                GlobalSettings.Refreskey();

                if (GlobalSettings.NGAYSAOLUU != null && GlobalSettings.NGAYSAOLUU != "")
                {
                    string st = GlobalSettings.NGAYSAOLUU;
                    DateTime time = Convert.ToDateTime(GlobalSettings.NGAYSAOLUU);
                    int NHAC_NHO_SAO_LUU = Convert.ToInt32(GlobalSettings.NHAC_NHO_SAO_LUU);
                    TimeSpan time1 = DateTime.Today.Subtract(time);
                    int ngay = NHAC_NHO_SAO_LUU - time1.Days;
                    if (ngay <= 0)
                        BackupDatabase();
                }
                else
                    BackupDatabase();

                if (!(GlobalSettings.LAST_BACKUP.Equals("")) && !(GlobalSettings.NHAC_NHO_SAO_LUU.Equals("")))
                    if (Convert.ToDateTime(GlobalSettings.LAST_BACKUP).Add(TimeSpan.Parse(GlobalSettings.NHAC_NHO_SAO_LUU)) == DateTime.Today)
                    {
                        BackupDatabase();
                    }
            }
            else
            {
                MainForm.isLoginSuccess = false;
            }
        }
        public void CheckShowPanelPermission()
        {
            #region Quản trị
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(RoleSystem.Management)))
            {
                this.cmdUser.Enabled = cmdUser1.Enabled = Janus.Windows.UI.InheritableBoolean.False;
                this.cmdManagementUserGroup.Enabled = cmdManagementUserGroup1.Enabled = Janus.Windows.UI.InheritableBoolean.False;
            }
            else
            {
                this.cmdUser.Enabled = cmdUser1.Enabled = Janus.Windows.UI.InheritableBoolean.True;
                this.cmdManagementUserGroup.Enabled = cmdManagementUserGroup1.Enabled = Janus.Windows.UI.InheritableBoolean.True;
            }
            #endregion
            #region Bán hàng
            // Thu ngân
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Sales.Cashier)))
            {
                this.explorerBarCashier.Groups[0].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCashier.Groups[0].Items[0].Enabled = true; 
            }
            // Khách hàng
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Customers.AddNew)))
            {
                this.explorerBarCashier.Groups[1].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCashier.Groups[1].Items[0].Enabled = true;
            }
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Customers.Management)))
            {
                this.explorerBarCashier.Groups[1].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarCashier.Groups[1].Items[1].Enabled = true;
            }
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Customers.DebtManagement)))
            {
                this.explorerBarCashier.Groups[1].Items[2].Enabled = false;
            }
            else
            {
                this.explorerBarCashier.Groups[1].Items[2].Enabled = true;
            }
            #endregion
            #region Hàng hoá
            // Nhóm hàng hoá
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Categories.AddNew)))
            {
                this.explorerBarProducts.Groups[0].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarProducts.Groups[0].Items[0].Enabled = true;
            }
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Categories.Management)))
            {
                this.explorerBarProducts.Groups[0].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarProducts.Groups[0].Items[1].Enabled = true;
            }
            // Hàng hoá
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Products.AddNew)))
            {
                this.explorerBarProducts.Groups[1].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarProducts.Groups[1].Items[0].Enabled = true;
            }
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Products.Management)))
            {
                this.explorerBarProducts.Groups[1].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarProducts.Groups[1].Items[1].Enabled = true;
            }
            #endregion
            #region Xuất nhập tồn
            // Xuất nhập tồn
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Inventories.Management)))
            {
                this.explorerBarCashFlow.Groups[0].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCashFlow.Groups[0].Items[0].Enabled = true;
            }
            // Nhập kho
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(PurchaseOrders.AddNew)))
            {
                this.explorerBarCashFlow.Groups[1].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCashFlow.Groups[1].Items[0].Enabled = true;
            }
            // Theo dõi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(PurchaseOrders.Management)))
            {
                this.explorerBarCashFlow.Groups[1].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarCashFlow.Groups[1].Items[1].Enabled = true;
            }
            // Nhà cung cấp
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Suppliers.AddNew)))
            {
                this.explorerBarCashFlow.Groups[2].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCashFlow.Groups[2].Items[0].Enabled = true;
            }
            // Theo dõi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Suppliers.Management)))
            {
                this.explorerBarCashFlow.Groups[2].Items[1].Enabled = false;
            }
            else 
            {
                this.explorerBarCashFlow.Groups[2].Items[1].Enabled = true;
            }
            // Kho
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(WareHouses.AddNew)))
            {
                this.explorerBarCashFlow.Groups[3].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCashFlow.Groups[3].Items[0].Enabled = true; 
            }
            // Theo dõi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(WareHouses.Management)))
            {
                this.explorerBarCashFlow.Groups[3].Items[1].Enabled = false;
            }
            else 
            {
                this.explorerBarCashFlow.Groups[3].Items[1].Enabled = true;
            }
            #endregion
            #region Sổ quỹ
            // Theo dõi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(CashFlows.Management)))
            {
                this.explorerBarCash.Groups[0].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[0].Items[0].Enabled = true;
            }
            // Thêm mới phiếu chi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Payments.AddNew)))
            {
                this.explorerBarCash.Groups[1].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[1].Items[0].Enabled = true;
            }
            // Theo dõi phiếu chi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Payments.Management)))
            {
                this.explorerBarCash.Groups[1].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[1].Items[1].Enabled = true;
            }
            // Thêm mới phiếu thu
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Receiptes.AddNew)))
            {
                this.explorerBarCash.Groups[2].Items[0].Enabled = false;
            }
            else 
            {
                this.explorerBarCash.Groups[2].Items[0].Enabled = true;
            }
            // Theo dõi phiếu thu
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(Receiptes.Management)))
            {
                this.explorerBarCash.Groups[2].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[2].Items[1].Enabled = true;
            }
            // Thêm mới loại chi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(PaymentTypes.AddNew)))
            {
                this.explorerBarCash.Groups[3].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[3].Items[0].Enabled = true;
            }
            // Theo dõi loại chi
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(PaymentTypes.Management)))
            {
                this.explorerBarCash.Groups[3].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[3].Items[1].Enabled = true;
            }
            // Thêm mới loại thu
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(ReceiptsTypes.AddNew)))
            {
                this.explorerBarCash.Groups[4].Items[0].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[4].Items[0].Enabled = true;
            }
            // Theo dõi loại thu
            if (!MainForm.EcsQuanTri.HasPermission(Convert.ToInt64(ReceiptsTypes.Management)))
            {
                this.explorerBarCash.Groups[4].Items[1].Enabled = false;
            }
            else
            {
                this.explorerBarCash.Groups[4].Items[1].Enabled = true;
            }
            #endregion
        }

        private void pnMain_MdiTabMouseDown(object sender, Janus.Windows.UI.Dock.MdiTabMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e.Tab.Form.Activate();
                if (this.MdiChildren.Length == 1)
                {
                    cmdCloseAllButMe.Enabled = Janus.Windows.UI.InheritableBoolean.False;
                }
                else
                {
                    cmdCloseAllButMe.Enabled = Janus.Windows.UI.InheritableBoolean.True;
                }
                mnuRightClick.Show(this, e.X + pnMain.MdiTabGroups[0].Location.X, e.Y + 6);
            }
        }

        private void explorerBarCash_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                case "cmdCashFlowManagement":
                    this.CashFlowManagement();
                    break;
                case "cmdPayment":
                    this.Payment();
                    break;
                case "cmdPaymentType":
                    this.PaymentType();
                    break;
                case "cmdPaymentTypeManagement":
                    this.PaymentTypeManagement();
                    break;
                case "cmdPaymentManagement":
                    this.PaymentManagement();
                    break;
                case "cmdAddReceipts":
                    this.Receipts();
                    break;
                case "cmdAddReceiptsType":
                    this.ReceiptsType();
                    break;
                case "cmdReceiptsTypeManagement":
                    this.ReceiptsTypeManagement();
                    break;
                case "cmdReceiptsManagement":
                    this.ReceiptsManagement();
                    break;
                default:
                    break;
            }
        }

        private void ReceiptsManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("ReceiptsManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            ReceiptsManagementForm f = new ReceiptsManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ReceiptsType()
        {
            ReceiptsTypeForm f = new ReceiptsTypeForm();
            f.ShowDialog(this);
        }

        private void ReceiptsTypeManagement()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i].Name.ToString().Equals("ReceiptsTypeManagementForm"))
                {
                    forms[i].Activate();
                    return;
                }
            }
            ReceiptsTypeManagementForm f = new ReceiptsTypeManagementForm();
            f.MdiParent = this;
            f.Show();
        }

        private void Receipts()
        {
            ReceiptsForm f = new ReceiptsForm();
            f.User = user;
            f.ShowDialog(this);
        }

        private void grPnSystem_SelectedPanelChanged(object sender, Janus.Windows.UI.Dock.PanelActionEventArgs e)
        {

        }

    }
}
