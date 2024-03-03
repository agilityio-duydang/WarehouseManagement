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

namespace WarehouseManagement
{
    public partial class BackupAndRestoreForm : BaseForm
    {
        public bool isBackUp = true;
        public static DateTime lastBackUp = new DateTime(1900, 01, 01);
        SQLDMO.BackupClass backupClass;
        public BackupAndRestoreForm()
        {
            InitializeComponent();
        }

        private void BackupAndRestoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Tao mac dinh thu muc sao luu du lieu
                string folderDataBackup = "";
                string folderDataRemote = "";

                try
                {
                    /******************************************************************
                    //1. Tạo thư mục lưu data (Nếu chưa có): [Ổ đĩa]/SOFTECH/ECS/DATABASE 
                    //2. Kiểm tra tên file data, tên file log vật lý tại thư mục lưu dữ liệu có trùng tên trước khi copy.
                    //   Nếu đã có thì cảnh báo và không thực hiện copy file.
                    //3. Copy file du lieu từ [Thư mục chương trình ECS]\DATA den vi tri thư mục mới: [Ổ đĩa]/SOFTECH/ECS/DATABASE
                    //4. Lấy thông tin đường dẫn mới của file data.
                    *******************************************************************/

                    string driverName = "";
                    string[] drivers = System.IO.Directory.GetLogicalDrives();

                    for (int i = 0; i < drivers.Length; i++)
                    {
                        if (drivers[i] == "C:\\" || drivers[i] == "A:\\" || drivers[i] == "B:\\")
                            continue;
                        if (drivers[i] == "D:\\")
                        {
                            driverName = drivers[i];
                            break;
                        }
                        else
                        {
                            driverName = drivers[i];
                            break;
                        }
                    }

                    folderDataRemote = SQL.GetFolderDatabaseRemote(GlobalSettings.SERVER_NAME, GlobalSettings.DATABASE_NAME, GlobalSettings.USER, GlobalSettings.PASS);

                    if (folderDataRemote.Trim().Length == 0)
                    {
                        folderDataBackup = (driverName + "CMC\\DATABASE\\BACKUP");
                        if (!System.IO.Directory.Exists(folderDataBackup))
                        {
                            //System.IO.Directory.CreateDirectory(folderDataBackup);
                            //Dung dong code duoi de phan quyen tren folder
                           CommonApplicationData direc = new CommonApplicationData(driverName + "CMC\\DATABASE", "BACKUP", true);
                        }
                    }
                    else
                        folderDataBackup = folderDataRemote;
                }
                catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }

                if (!GlobalSettings.PATH_BACKUP.Equals(""))
                    txtPath.Text = GlobalSettings.PATH_BACKUP.Trim();
                else
                    txtPath.Text = folderDataBackup;

                txtDatabaseName.Text = string.Format("{0}_{1}", GlobalSettings.DATABASE_NAME, DateTime.Now.ToString("dd_MM_yyyy_[HH_mm].bak"));
                if (GlobalSettings.NGAYSAOLUU == "")
                    label3.Enabled = label4.Enabled = cbbDateRemind.Enabled = false;

                string nhacNhoSaoLuu = ConfigConecionForm.ReadNodeXmlAppSettings("NHAC_NHO_SAO_LUU");

                if (GlobalSettings.NGON_NGU == "0")
                {
                    if (isBackUp)
                    {
                        if (nhacNhoSaoLuu != "")
                            cbbDateRemind.SelectedValue = nhacNhoSaoLuu;
                        else
                            cbbDateRemind.SelectedValue = "7";
                    }
                }
                else
                {

                    if (isBackUp)
                    {
                        if (nhacNhoSaoLuu != "")
                            cbbDateRemind.SelectedValue = nhacNhoSaoLuu;
                        else
                            cbbDateRemind.SelectedValue = "7";
                    }
                }

                chkCheckRemind.Checked = nhacNhoSaoLuu != null || nhacNhoSaoLuu != "" ? true : false;

                chkCheckRemind_CheckedChanged(null, EventArgs.Empty);

                backupClass = new SQLDMO.BackupClass();
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }
        }

        private void btnBrowers_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFolderBrowse frm = new FrmFolderBrowse(GlobalSettings.USER, GlobalSettings.PASS, GlobalSettings.SERVER_NAME);
                frm.ShowDialog(this);
                txtPath.Text = FrmFolderBrowse.pathSelected;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }

        private void chkCheckRemind_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheckRemind.Checked == false)
            {
                label3.Enabled =cbbDateRemind.Enabled=label4.Enabled= false;
            }
            else
                label3.Enabled = cbbDateRemind.Enabled = label4.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!ValidateForm(false))
                    return;
                if (chkCheckRemind.Checked)
                {
                    ConfigConecionForm.SaveNodeXmlAppSettings("NGAYSAOLUU", DateTime.Today.ToString("dd/MM/yyyy"));
                    ConfigConecionForm.SaveNodeXmlAppSettings("NHAC_NHO_SAO_LUU", cbbDateRemind.SelectedValue.ToString());
                }
                else
                {
                    ConfigConecionForm.SaveNodeXmlAppSettings("NGAYSAOLUU", "");
                    ConfigConecionForm.SaveNodeXmlAppSettings("NHAC_NHO_SAO_LUU", "");
                }

                ConfigConecionForm.SaveNodeXmlAppSettings("PATH_BACKUP", txtPath.Text.Trim());

                ShowMessage("Lưu cấu hình thành công.", false);
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }
            finally { this.Cursor = Cursors.Default; }
        }
        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtPath, errorProvider, "Đường đẫn ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtDatabaseName, errorProvider, "Tên file ", isOnlyWarning);
            return isValid;
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (string.IsNullOrEmpty(txtPath.Text) || string.IsNullOrEmpty(txtDatabaseName.Text))
                    ShowMessage("Đường dẫn hoặc tên file không được để trống", false);
                else
                {
                    if (isBackUp)
                    {
                        using (SqlConnection cnn = new SqlConnection())
                        {
                            cnn.ConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connect Timeout={4}", new object[] { GlobalSettings.SERVER_NAME, GlobalSettings.DATABASE_NAME, GlobalSettings.USER, GlobalSettings.PASS, GlobalSettings.TimeoutBackup * 60 }); //TimeoutBackup = phút * 60 giây.
                            //                            cnn.Open();
                            //                            string cmdText = @"			                                
                            //                                            BEGIN
                            //
                            //                                            EXEC SP_CONFIGURE 'remote query timeout', 1800
                            //                                            reconfigure
                            //                                            EXEC sp_configure
                            //
                            //
                            //                                            EXEC SP_CONFIGURE 'show advanced options', 1
                            //                                            reconfigure
                            //                                            EXEC sp_configure
                            //
                            //
                            //                                            EXEC SP_CONFIGURE 'remote query timeout', 1800
                            //                                            reconfigure
                            //                                            EXEC sp_configure
                            //
                            //                                            END
                            //                                         ";
                            //                            SqlCommand sqlCmd = new SqlCommand(cmdText);
                            //                            sqlCmd.CommandType = CommandType.Text;
                            //                            sqlCmd.Connection = cnn;
                            //                            sqlCmd.ExecuteNonQuery();
                            //                            cnn.Close();


                            cnn.Open();
                            string cmdText = @"
			                                --Default backup database LanNT                                            
                                            --Create 10-05-2012
                                            BEGIN

                                            DECLARE @filedata  AS NVARCHAR(255)
                                            DECLARE @filename  AS NVARCHAR(255)
                                            DECLARE @dbName AS NVARCHAR(255)
                                           
                                            SET @dbName = '" + GlobalSettings.DATABASE_NAME + @"'
                                            SET @filename ='" + Path.Combine(txtPath.Text, txtDatabaseName.Text) + @"'		                                
                                            BACKUP DATABASE @dbName
                                            TO DISK =@filename
                                            WITH FORMAT,INIT,MEDIANAME = 'Z_SQLServerBackups',
                                            NAME = 'Full Backup of AdventureWorks',
                                            SKIP,NOREWIND,NOUNLOAD,STATS = 10;
                                            END
                                         ";
                            SqlCommand sqlCmd = new SqlCommand(cmdText);
                            sqlCmd.CommandType = CommandType.Text;
                            sqlCmd.CommandTimeout = GlobalSettings.TimeoutBackup * 60;
                            sqlCmd.Connection = cnn;
                            sqlCmd.ExecuteNonQuery();
                        }
                    }

                    if (chkCheckRemind.Checked)
                    {
                        ConfigConecionForm.SaveNodeXmlAppSettings("NGAYSAOLUU", DateTime.Today.ToString("dd/MM/yyyy"));
                        ConfigConecionForm.SaveNodeXmlAppSettings("NHAC_NHO_SAO_LUU", cbbDateRemind.SelectedValue.ToString());
                    }
                    else
                    {
                        ConfigConecionForm.SaveNodeXmlAppSettings("NGAYSAOLUU", "");
                        ConfigConecionForm.SaveNodeXmlAppSettings("NHAC_NHO_SAO_LUU", "");
                    }

                    ConfigConecionForm.SaveNodeXmlAppSettings("LAST_BACKUP", DateTime.Now.ToString("dd/MM/yyyy"));
                    ConfigConecionForm.SaveNodeXmlAppSettings("PATH_BACKUP", txtPath.Text.Trim());

                    ShowMessage("Sao lưu dữ liệu thành công.", false);
                    GlobalSettings.RefreshKey();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                string st = "";
                if (isBackUp)
                    st = "Lỗi khi sao lưu dữ liệu.";
                else
                    st = "Lỗi khi phục hồi dữ liệu.";
                ShowMessage(st + " " + ex.Message, false);

                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
            finally { this.Cursor = Cursors.Default; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
