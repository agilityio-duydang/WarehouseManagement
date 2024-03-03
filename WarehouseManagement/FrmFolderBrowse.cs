using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLFolderBrowser;

namespace WarehouseManagement
{
    public partial class FrmFolderBrowse : BaseForm
    {
        private SQLServerFolderBrowse folderbrowse = new SQLServerFolderBrowse();
        public static string pathSelected;
        public string userName;
        public string passWord;
        public string serverName;
        public FrmFolderBrowse(string _userName, string _passWord, string _serverName)
        {
            InitializeComponent();

            try
            {
                userName = _userName;
                passWord = _passWord;
                serverName = _serverName;
                Cursor.Current = Cursors.WaitCursor;
                SetParameters();
                DataMain();
                SetDefaults();
                HelpAndTips();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Khởi tạo bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                //ShowMessage("Khởi tạo bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
                
        #region Paremeters
        private void SetParameters()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Giá trị tham số bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Giá trị tham số bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Data
        private void DataMain()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                AssociateQuery();
                LoadData();
                ConstraintsViewsAndManagers();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Data Main bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Data Main bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void AssociateQuery()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Associate Query bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Associate Query bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Load Data bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Load Data bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void ConstraintsViewsAndManagers()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Create Constraint bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Create Constraint bị lỗi  \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Default
        private void SetDefaults()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Thiết lập tham số mặc định bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Thiết lập tham số mặc định bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Help and Tips
        private void HelpAndTips()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                SetHelp();
                SetTips();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Help and Tips bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Help and Tips bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void SetHelp()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Set Help bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Set Help bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void SetTips()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Set Tips bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Set Tips bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strDrivers;
            TreeNode nParent;
            string strFullName;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Connect(userName, passWord, serverName);

                strDrivers = folderbrowse.GetFixedDrives();
                foreach(string strDriver in strDrivers)
                {
                    nParent = tvFolders.Nodes.Add(strDriver);
                    nParent.ImageIndex = 0;
                    strFullName = strDriver + ":";
                    nParent.Tag = strFullName;
                    if (!(folderbrowse.GetSubFolders(strFullName) == null))
                        nParent.Nodes.Add("Dummy");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Không thể Load dữ liệu", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Không thể Load dữ liệu \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Process
        private void Connect(string userName, string passWord, string serverName)
        {
            try
            {
                folderbrowse.Username = userName;
                folderbrowse.Password = passWord;
                folderbrowse.Server = serverName;
                folderbrowse.Timeout = 600;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Kết nối CSDL bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Kết nối CSDL bị lỗi \r\n" + ex.Message, false, true);
            }
        }
        
        private void tvFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string strFullName;
            string[] strFolders;
            TreeNode nChild;
            TreeNode nGrandChildNode;
            try
            {
                //if (!loaded)
                //{
                    Cursor.Current = Cursors.WaitCursor;
                    Connect(userName, passWord, serverName);

                    if (e.Node.GetNodeCount(true) > 0)
                    {
                        nChild = e.Node;
                        e.Node.FirstNode.Remove();
                        strFullName = Convert.ToString(e.Node.Tag);
                        strFolders = folderbrowse.GetSubFolders(strFullName);
                        foreach (string strFolder in strFolders)
                        {
                            if ((!strFolder.ToLower().Equals("system volume information")) && (!strFolder.ToLower().Equals("recycle")) &&
                                !(strFolder.StartsWith("$")) && !(strFolder.ToLower().EndsWith(".msi")))
                            {
                                nGrandChildNode = nChild.Nodes.Add(strFolder);
                                nGrandChildNode.Tag = strFullName + "\\" + strFolder;
                                nGrandChildNode.ImageIndex = 1;
                                //nGrandChildNode.SelectedImageIndex = 2;
                                if (!(folderbrowse.GetSubFolders(strFullName + "\\" + strFolder) == null))
                                    nGrandChildNode.Nodes.Add("Dummy");
                            }
                        }
                    }
                    //loaded = true;
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Xử lý dữ liệu Node bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Xử lý dữ liệu Node bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pathSelected = tvFolders.SelectedNode.Tag.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Lấy thông tin thư mục bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Lấy thông tin thư mục bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pathSelected = "";
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Đóng cửa sổ bị lỗi", MessageBoxButtons.OK);
                Logger.LocalLogger.Instance().WriteMessage(ex);
                ShowMessage("Đóng cửa sổ bị lỗi \r\n" + ex.Message, false, true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion
    }
}
