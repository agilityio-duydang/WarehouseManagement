using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Threading;

namespace WarehouseManagement
{
    public partial class ConfigConecionForm : BaseForm
    {
        public ConfigConecionForm()
        {
            InitializeComponent();
        }
        private void SetListTable()
        {
            try
            {
                if (GlobalSettings.ListTableNameSource.Count > 0)
                {
                    cbDatabaseSource.Items.Clear();
                    cbDatabaseSource.Items.Add("(-Làm mới-)");

                    foreach (string item in GlobalSettings.ListTableNameSource)
                    {
                        cbDatabaseSource.Items.Add(item);
                    }

                    cbDatabaseSource.Sorted = true;
                    if (cbDatabaseSource.SelectedItem == null) cbDatabaseSource.SelectedItem = new Janus.Windows.EditControls.UIComboBoxItem(GlobalSettings.DATABASE_NAME);
                    cbDatabaseSource.SelectedItem.Value = GlobalSettings.DATABASE_NAME;
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void GetListTableSource(Janus.Windows.EditControls.UIComboBox comboBox)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string strConnString = "server=" + txtServerName.Text;
                strConnString += ";User Id=" + txtSa.Text + ";Password=" + txtPass.Text;

                //fServer = new SQLDMO.SQLServerClass();
                //fServer.Connect(txtServerName.Text, txtSa.Text, txtPass.Text);

                SQL.InitializeServer(strConnString);

                comboBox.Items.Clear();
                comboBox.Items.Add("(-Làm mới-)");

                //foreach (SQLDMO.Database db in fServer.Databases)
                //{
                //    comboBox.Items.Add(db.Name);
                //}

                foreach (string dbName in SQL.ListDatabases())
                {
                    comboBox.Items.Add(dbName);
                }

                comboBox.Sorted = true;

                comboBox.SelectedIndexChanged -= new EventHandler(cbDatabaseSource_SelectedIndexChanged);
                comboBox.SelectedIndex = 0;
                comboBox.SelectedIndexChanged += new EventHandler(cbDatabaseSource_SelectedIndexChanged);

            }
            catch (Exception e1)
            {
                ShowMessage("Kết nối không thành công. Bạn hãy kiểm tra lại thông tin cấu hình.\r\n\nChi tiết: " + e1.Message, false);
                Logger.LocalLogger.Instance().WriteMessage(e1);
            }
            finally { Cursor = Cursors.Default; }
        }
        private void GetServerInstances()
        {
            txtServerName.Items.Clear();
            txtServerName.Items.Add("(- Làm mới -)");
            Cursor = Cursors.WaitCursor;
            try
            {
                SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
                System.Data.DataTable table = instance.GetDataSources();
                foreach (DataRow item in table.Rows)
                {
                    string serverName = item[0].ToString();
                    serverName += "\\";
                    serverName += item[1].ToString();
                    txtServerName.Items.Add(serverName);
                }
                txtServerName.SelectedIndexChanged -= new EventHandler(txtServerName_SelectedIndexChanged);
                txtServerName.SelectedIndex = 0;
                txtServerName.SelectedIndexChanged += new EventHandler(txtServerName_SelectedIndexChanged);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }

        }

        private void txtServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtServerName.SelectedIndex == 0)
            {
                GetServerInstances();
            }
        }

        private void cbDatabaseSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDatabaseSource.SelectedIndex == 0)
            {
                GetListTableSource(cbDatabaseSource);
            }
        }

        private void cbDatabaseSource_DropDown(object sender, EventArgs e)
        {
            if (cbDatabaseSource.Items.Count <= 1)
                GetListTableSource(cbDatabaseSource);
        }

        private void cbDatabaseSource_Closed(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (cbDatabaseSource.SelectedIndex == 0)
                {
                    GetListTableSource(cbDatabaseSource);
                }

                GlobalSettings.ListTableNameSource.Clear();
                for (int i = 1; i < cbDatabaseSource.Items.Count; i++)
                {
                    GlobalSettings.ListTableNameSource.Add(cbDatabaseSource.Items[i].Text);
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string MSSQLConnectionString = ReadNodeXmlConnectionStrings2();
                if (!ValidateForm(false))
                    return;
                //Cấu hình lại connectionString.
                string st = "Server=" + txtServerName.Text.Trim() + ";Database=" + cbDatabaseSource.Text.Trim() + ";Uid=" + txtSa.Text.Trim() + ";Pwd=" + txtPass.Text.Trim();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["MSSQL"].ConnectionString = st;
                //cấu hình WS
                SqlConnection con = new SqlConnection(st);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    Logger.LocalLogger.Instance().WriteMessage(ex);
                    ShowMessage("Không kết nối được tới máy chủ này\r\nLý do: " + ex.Message, false);
                }

                SaveNodeXmlAppSettings("SERVER_NAME", txtServerName.Text.Trim());
                SaveNodeXmlAppSettings("USER", txtSa.Text.Trim());
                SaveNodeXmlAppSettings("PASS", txtPass.Text.Trim());
                SaveNodeXmlAppSettings("DATABASE_NAME", cbDatabaseSource.Text.Trim());

                ShowMessage("Lưu file cấu hình Kết nối Database thành công.", false);
                string mssql = "Server=" + txtServerName.Text.Trim() + "; database=" + cbDatabaseSource.Text.Trim() + "; uid=" + txtSa.Text.Trim() + "; pwd=" + txtPass.Text.Trim();
                SaveNodeXmlConnectionStrings(mssql);
                this.Close();
                Application.Restart();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, false);
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private bool ValidateForm(bool isOnlyWarning)
        {
            bool isValid = true;
            isValid &= ValidateControl.ValidateNull(txtServerName, errorProvider, "Tên/IP máy chủ ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtSa, errorProvider, "Tên đăng nhập ", isOnlyWarning);
            isValid &= ValidateControl.ValidateNull(txtPass, errorProvider, "Mật khẩu  ", isOnlyWarning);
            isValid &= ValidateControl.ValidateChoose(cbDatabaseSource, errorProvider, "Tên CSDL ", isOnlyWarning);
            return isValid;
        }
        public struct sConnectionString
        {
            public static string Server;
            public static string Database;
            public static string User;
            public static string Pass;
        }
        #region SAVE NODE XML
        public static void SaveNodeXmlAppSettings(string key, object value, object setting)
        {
            SaveNodeXmlAppSettings(key, value);
            try
            {
                setting = value;
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(key, ex); }
        }

        public static void SaveNodeXmlAppSettings(string key, object value)
        {
            try
            {
                System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(config.FilePath);
                string groupSettingName = "appSettings";

                SaveNodeXml(config, doc, groupSettingName, key, value);
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(key, ex); }
        }
        public static string ReadNodeXmlAppSettings(string key)
        {
            return ReadNodeXmlAppSettings(key, "");
        }
        public static string ReadNodeXmlAppSettings(string key, string defaultValue)
        {
            System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(config.FilePath);
            string groupSettingName = "appSettings";

            return ReadNodeXml(config, doc, groupSettingName, key, defaultValue);
        }

        public static void SaveNodeXml(System.Configuration.Configuration config, System.Xml.XmlDocument xmlDocument, string groupSettingName, string key, object value)
        {
            try
            {
                xmlDocument.SelectSingleNode("//" + groupSettingName + "//add[@key='" + key + "']").SelectSingleNode("@value").Value = value.ToString();
                xmlDocument.Save(config.FilePath);
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(key, ex); }
        }

        public static void UpdateNodeXml(System.Xml.XmlDocument xmlDocument, string groupSettingName, string key, object value)
        {
            try
            {
                xmlDocument.SelectSingleNode("//" + groupSettingName + "//add[@key='" + key + "']").SelectSingleNode("@value").Value = value.ToString();
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }
        }

        public static string ReadNodeXml(System.Configuration.Configuration config, System.Xml.XmlDocument xmlDocument, string groupSettingName, string key)
        {
            string result = "";

            try
            {
                XmlNode Node = xmlDocument.SelectSingleNode("//" + groupSettingName + "//add[@key='" + key + "']");
                if (Node != null)
                {
                    result = Node.SelectSingleNode("@value").Value;
                }
                else
                {
                    AddNodeConfig(key, "");
                }
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(key, ex); }

            return result;
        }
        public static string ReadNodeXml(System.Configuration.Configuration config, System.Xml.XmlDocument xmlDocument, string groupSettingName, string key, string default_Value)
        {
            string result = "";

            try
            {
                XmlNode Node = xmlDocument.SelectSingleNode("//" + groupSettingName + "//add[@key='" + key + "']");
                if (Node != null)
                {

                    result = Node.SelectSingleNode("@value").Value;
                    if (string.IsNullOrEmpty(result))
                    {
                        result = default_Value;
                    }
                }
                else
                {
                    AddNodeConfig(key, default_Value);
                    result = default_Value;
                }
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(key, ex); }
            if (string.IsNullOrEmpty(result))
                result = default_Value;
            return result;
        }
        public static void AddNodeConfig(string key, string ValueDefault)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, ValueDefault);
            config.Save();
        }

        public static void SaveNodeXmlSetting(string name, object value)
        {
            try
            {
                System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(config.FilePath);
                string s = "//setting[@name='" + name + "']";
                doc.SelectSingleNode(s).SelectSingleNode("value").ChildNodes[0].Value = value.ToString();
                doc.Save(config.FilePath);
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage("Error at key: " + name, ex); }
        }

        public static void SaveNodeXmlConnectionStrings(string connectionString)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["MSSQL"].ConnectionString = connectionString;
                config.Save(ConfigurationSaveMode.Modified);
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }
        }

        public static void ReadNodeXmlConnectionStrings()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string connectionString = config.ConnectionStrings.ConnectionStrings["MSSQL"].ConnectionString;

                string[] arr = connectionString.Split(new char[] { ';' });

                sConnectionString.Server = arr[0].Split(new char[] { '=' })[1];
                sConnectionString.Database = arr[1].Split(new char[] { '=' })[1];
                sConnectionString.User = arr[2].Split(new char[] { '=' })[1];
                sConnectionString.Pass = arr[3].Split(new char[] { '=' })[1];
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }
        }

        public static string ReadNodeXmlConnectionStrings2()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string connectionString = config.ConnectionStrings.ConnectionStrings["MSSQL"].ConnectionString;

                return connectionString;
            }
            catch (Exception ex) { Logger.LocalLogger.Instance().WriteMessage(ex); }

            return "";
        }
        #endregion

        private void ConfigConecionForm_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                GetServerInstances();
            }));
            txtServerName.Text = GlobalSettings.SERVER_NAME;
            txtSa.Text = GlobalSettings.USER;
            txtPass.Text = GlobalSettings.PASS;
            cbDatabaseSource.Text = GlobalSettings.DATABASE_NAME;
            SetListTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            AttachAndRestoreDatabaseForm f = new AttachAndRestoreDatabaseForm();
            f.ShowDialog(this);
        }

        private void btnSetupSQL_Click(object sender, EventArgs e)
        {
            SetupSQLServerForm f = new SetupSQLServerForm();
            f.ShowDialog();
        }

        private void btnTaoCSDL_Click(object sender, EventArgs e)
        {

        }
    }
}
