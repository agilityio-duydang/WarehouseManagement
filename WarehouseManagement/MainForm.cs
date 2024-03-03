﻿using System;
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
                user = User.Load(((SiteIdentity)MainForm.QuanTri.Identity).user.ID);
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
                if (forms[i].Name.ToString().Equals("WarehouseManagement"))
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
                user = User.Load(((SiteIdentity)MainForm.QuanTri.Identity).user.ID);
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
                case "cmdPaymentManagement":
                    this.PaymentManagement();
                    break;
                case "cmdAddReceipts":
                    this.Receipts();
                    break;
                case "cmdAddReceiptsType":
                    this.ReceiptsType();
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

        private void Receipts()
        {
            ReceiptsForm f = new ReceiptsForm();
            f.User = user;
            f.ShowDialog(this);
        }

    }
}
