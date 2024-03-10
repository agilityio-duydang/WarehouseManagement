using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Configuration;
using System.Threading;

namespace WarehouseManagement
{
    public partial class AttachAndRestoreDatabaseForm : BaseForm
    {
        public FolderBrowserDialog targetDirectory = new FolderBrowserDialog();
        public OpenFileDialog OpenFileDialog = new OpenFileDialog();
        public String ServerName = "";
        public String DatabaseName = "WAREHOUSEMANAGEMENT_V1";
        public String User = "";
        public String Password = "";
        public static SqlConnection sqlConnection;
        public static SqlCommand sqlCommand;
        public string[] paras = new string[3] { string.Empty, string.Empty, string.Empty };
        static int _timeoutBackup = 30;
        public static int TimeoutBackup
        {
            get { return _timeoutBackup; }
            set { _timeoutBackup = value; }
        }

        public AttachAndRestoreDatabaseForm()
        {
            InitializeComponent();
        }

        public bool CheckExitsConnection()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection())
                {
                    cnn.ConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connect Timeout={4}", new object[] { GlobalSettings.SERVER_NAME, GlobalSettings.DATABASE_NAME, GlobalSettings.USER, GlobalSettings.PASS, TimeoutBackup * 60 }); //TimeoutBackup = phút * 60 giây.
                    cnn.Open();
                    cnn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
        public void RestoreFromFileBackup()
        {
            try
            {
                if (string.IsNullOrEmpty(txtFileBackup.Text))
                {
                    ShowMessage("Bạn chưa chọn File sao lưu ", false);
                }
                else
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(txtFolderDatabase.Text);
                    if (!directoryInfo.Exists)
                    {
                        directoryInfo.Create();
                    }
                    string[] strArray = new string[] { "RESTORE DATABASE " + DatabaseName + "   FROM DISK='", txtFileBackup.Text.Trim(), "'    WITH      Move '" + DatabaseName + "' TO '", txtFolderDatabase.Text.Trim(), @"\" + DatabaseName + ".mdf',    Move '" + DatabaseName + "_log' TO '", txtFolderDatabase.Text.Trim(), @"\" + DatabaseName + "_1.ldf', NOUNLOAD, REPLACE, STATS = 10  " };
                    SQLExecuteSQL(String.Concat(strArray));
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        public void SQLExecuteSQL(string strSQL)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection())
                {
                    DatabaseName = string.Format("WAREHOUSEMANAGEMENT_V{0}", "1");

                    cnn.ConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connect Timeout={4}", new object[] { ServerName, "master", User, Password, TimeoutBackup * 60 }); //TimeoutBackup = phút * 60 giây.
                    cnn.Open();
                    SqlCommand sqlCmd = new SqlCommand(strSQL);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = cnn;
                    sqlCmd.ExecuteNonQuery();

                    UpdateConfig();
                    ShowMessage("Khôi phục Cơ sở dữ liệu thành công.", false);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Có lỗi:\r\n" + ex.Message + "\r\n" + ex.StackTrace + "", false);
            }
        }
        private void UpdateConfig()
        {
            try
            {
                string st = "Server=" + ServerName.ToString().Trim() + ";Database=" + DatabaseName.ToString().Trim() + ";Uid=" + User.ToString().Trim() + ";Pwd=" + Password.ToString().Trim();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["MSSQL"].ConnectionString = st;

                ConfigConecionForm.SaveNodeXmlAppSettings("pass", Password.ToString().Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("DATABASE_NAME", DatabaseName.ToString().Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("user", User.ToString().Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("ServerName", ServerName.ToString().Trim());
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void DoWork(object obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public void AttachDatabase()
        {
            try
            {
                paras[0] = txtFileMdf.Text;
                paras[1] = txtFileLdf.Text;
                using (SqlConnection cnn = new SqlConnection())
                {
                    DatabaseName = string.Format("WAREHOUSEMANAGEMENT_V{0}", "1");
                    paras[2] = DatabaseName;
                    cnn.ConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connect Timeout={4}", new object[] { ServerName, "master", User, Password, TimeoutBackup * 60 }); //TimeoutBackup = phút * 60 giây.
                    cnn.Open();
                    string sfmtCreateData = string.Format(@"
                                                                    CREATE DATABASE [{0}] ON 
                                                                    ( FILENAME = N'{1}' ),
                                                                    ( FILENAME = N'{2}' )
                                                                     FOR ATTACH
                                                                    ", new object[]{paras[2],paras[0],paras[1]                                                                     
                                                                 });
                    SqlCommand sqlCmd = new SqlCommand(sfmtCreateData);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = cnn;
                    sqlCmd.ExecuteNonQuery();
                    UpdateConfig();
                    ShowMessage("Khôi phục Cơ sở dữ liệu thành công.", false);
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                if (ex.Message.Contains("cannot be restored over the existing"))
                {
                    ShowMessage("Có lỗi: Đã tồn tại file .mdf tại đường dẫn " + paras[0] + ", bạn không thể Ghi đè mà phải lưu dữ liệu SQL ở một thư mục khác.", false);
                }
                if (ex.Message.Contains("Access is denied"))
                {
                    ShowMessage("Có lỗi: Bạn không có đầy đủ quyền tạo CSDL. Vui lòng Copy thư mục cài đặt ECS sang ổ khác (Tốt nhất là ổ D:) và tiến hành tạo lại CSDL.", false);
                }
                ShowMessage("Có lỗi:\r\n" + ex.Message + "\r\n" + ex.StackTrace, false);

            }
        }
        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckExitsConnection())
                {
                    ShowMessage("Phát hiện dữ liệu mặc định đã được thiết lập.", false);
                    return;
                }
                if (!System.IO.Directory.Exists(txtFolderDatabase.Text))
                {
                    errorProvider.SetError(txtFolderDatabase, "Thư mục Lưu Cơ sở dữ liệu không tồn tại . Hoặc đường dẫn Thư mục không hợp lệ");
                    return;
                }
                else
                {
                    GrantAccess(txtFolderDatabase.Text);
                }
                if (rdbFromBak.Checked)
                {
                    if (!System.IO.File.Exists(txtFileBackup.Text))
                    {
                        errorProvider.SetError(txtFileBackup, "File Sao lưu không không tồn tại . Hoặc đường dẫn File Sao lưu không hợp lệ");
                        return;
                    }
                    else
                    {
                        GrantAccess(txtFileBackup.Text);
                    }
                    DatabaseName = string.Format("WAREHOUSEMANAGEMENT_V{0}", "1");
                    if (ShowMessage("Bạn có chắc chắn muốn tạo mới CSDL không ? ", true, false) == "Yes")
                    {
                        Invoke(new Action(() =>
                        {
                            RestoreFromFileBackup();
                        }));
                    }
                }
                else if (rdbFromFile.Checked)
                {
                    if (!System.IO.File.Exists(txtFileMdf.Text))
                    {
                        errorProvider.SetError(txtFileMdf, "File Data Database không không tồn tại . Hoặc đường dẫn File Data Database không hợp lệ");
                        return;
                    }
                    if (!System.IO.File.Exists(txtFileLdf.Text))
                    {
                        errorProvider.SetError(txtFileLdf, "File Data Database không không tồn tại . Hoặc đường dẫn File Data Database không hợp lệ");
                        return;
                    }
                    if (ShowMessage("Bạn có chắc chắn muốn tạo mới CSDL không ? ", true, false) == "Yes")
                    {
                        Invoke(new Action(() =>
                        {
                            AttachDatabase();
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtFolderDatabase_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                targetDirectory = new FolderBrowserDialog();
                if (targetDirectory.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    txtFolderDatabase.Text = targetDirectory.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtFileBackup_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.FileName = "";
                OpenFileDialog.Filter = "Backup Files (*.bak;*.tm;*.log)|*.bak;*.tm;*.log|All Files (*.*)|*.*;";
                OpenFileDialog.Multiselect = false;
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileInfo fin = new System.IO.FileInfo(OpenFileDialog.FileName);
                    if (fin.Extension.ToUpper() != ".BAK".ToUpper() && fin.Extension.ToUpper() != ".TM".ToUpper() && fin.Extension.ToUpper() != ".LOG".ToUpper())
                    {
                        ShowMessage("TỆP TIN  :" + fin.Name + " KHÔNG ĐÚNG ĐỊNH DẠNG FILE BACKUP", false, false);
                    }
                    else
                    {
                        txtFileBackup.Text = OpenFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtFileMdf_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.FileName = "";
                OpenFileDialog.Filter = "Database Data Files (*.mdf)|*.mdf|All Files (*.*)|*.*;";
                OpenFileDialog.Multiselect = false;
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileInfo fin = new System.IO.FileInfo(OpenFileDialog.FileName);
                    if (fin.Extension.ToUpper() != ".MDF".ToUpper())
                    {
                        ShowMessage("TỆP TIN : " + fin.Name + " KHÔNG ĐÚNG ĐỊNH DẠNG DATABASE DATA FILE", false, false);
                    }
                    else
                    {
                        txtFileMdf.Text = OpenFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void txtFileLdf_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.FileName = "";
                OpenFileDialog.Filter = "Database Data Files (*.ldf)|*.ldf|All Files (*.*)|*.*;";
                OpenFileDialog.Multiselect = false;
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileInfo fin = new System.IO.FileInfo(OpenFileDialog.FileName);
                    if (fin.Extension.ToUpper() != ".LDF".ToUpper())
                    {
                        ShowMessage("TỆP TIN : " + fin.Name + " KHÔNG ĐÚNG ĐỊNH DẠNG DATABASE LOG FILE", false, false);
                    }
                    else
                    {
                        txtFileLdf.Text = OpenFileDialog.FileName;
                    }
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

        private void FormAttachAndRestoreDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                ServerName = GlobalSettings.SERVER_NAME;
                DatabaseName = GlobalSettings.DATABASE_NAME;
                User = GlobalSettings.USER;
                Password = GlobalSettings.PASS;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void rdbFromBak_Click(object sender, EventArgs e)
        {
            if (rdbFromBak.Checked)
            {
                txtFileBackup.Enabled = true;
                btnSelectFileBackup.Enabled = true;

                txtFileMdf.Enabled = false;
                txtFileLdf.Enabled = false;
                btnSelectFileLdf.Enabled = false;
                btnSelectFileMdf.Enabled = false;
                rdbFromFile.Checked = false;
            }
            else
            {

                txtFileMdf.Enabled = true;
                txtFileLdf.Enabled = true;
                btnSelectFileLdf.Enabled = true;
                btnSelectFileMdf.Enabled = true;
                rdbFromFile.Checked = true;
            }
        }

        private void rdbFromFile_Click(object sender, EventArgs e)
        {
            if (rdbFromFile.Checked)
            {
                txtFileBackup.Enabled = false;
                btnSelectFileBackup.Enabled = false;

                txtFileMdf.Enabled = true;
                txtFileLdf.Enabled = true;
                btnSelectFileLdf.Enabled = true;
                btnSelectFileMdf.Enabled = true;
                rdbFromBak.Checked = false;
            }
            else
            {
                txtFileMdf.Enabled = false;
                txtFileLdf.Enabled = false;
                btnSelectFileLdf.Enabled = false;
                btnSelectFileMdf.Enabled = false;
                rdbFromBak.Checked = false;
            }
        }
    }
}
