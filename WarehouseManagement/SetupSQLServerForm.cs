using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.ServiceProcess;
using System.Diagnostics;
using Microsoft.Win32;
using System.Reflection;

namespace WarehouseManagement
{
    public partial class SetupSQLServerForm : BaseForm
    {
        private static string AppDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private static ManualResetEvent handle = new ManualResetEvent(true);
        public string InstanceName = "ECSEXPRESS";
        public string ServerAddress = "";
        public string Password = "";
        public string User = "";
        private bool DownloadComplete = false;
        public SetupSQLServerForm()
        {
            InitializeComponent();
        }
        private void InstallSQL()
        {
            try
            {
                string Result = "";
                backgroundWorker1.WorkerReportsProgress = true;
                bool isSucess = Install(InstanceName, ref ServerAddress, ref Result, backgroundWorker1, lblStatus);
                if (isSucess)
                {
                    UpdateConfig();
                    ShowMessage("Cài đặt SQL Server 2008 thành công ", false);
                    this.Close();
                }
                else
                {
                    ShowMessage("Cài đặt SQL Server 2008 không thành công ", false);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void InstallSQL2005()
        {
            try
            {
                string Result = "";
                backgroundWorker1.WorkerReportsProgress = true;
                bool isSucess = InstallSQL2005(InstanceName, ref ServerAddress, ref Result, backgroundWorker1, lblStatus);
                if (isSucess)
                {
                    UpdateConfig();
                    ShowMessage("Cài đặt SQL Server 2005 thành công ", false,false);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void UpdateConfig()
        {
            try
            {

                ConfigConecionForm.SaveNodeXmlAppSettings("pass", Password.ToString().Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("user", User.ToString().Trim());
                ConfigConecionForm.SaveNodeXmlAppSettings("ServerName", Environment.MachineName + "\\" + InstanceName.ToString().Trim());
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallSQL2005();
            //InstallSQL();
        }
        // Methods
        public static bool CheckServiceExist(string instanceName, ref string serverAddr)
        {
            bool flag2;
            try
            {
                String machineName = "";
                if (GetIPAddress().Trim().Length == 0)
                {
                    machineName = Environment.MachineName;
                }
                ServiceController controller = null;
                bool flag = false;
                controller = new ServiceController("MSSQL$" + instanceName);
                try
                {
                    string serviceName = controller.ServiceName;
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
                if (!flag)
                {
                    flag2 = false;
                }
                else
                {
                    string[] strArray = new string[] { machineName, @"\", instanceName, ",", Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\" + instanceName + @"\MSSQLServer\SuperSocketNetLib\Tcp", true).GetValue("TcpPort").ToString() };
                    serverAddr = string.Concat(strArray);
                    flag2 = true;
                }
            }
            catch (Exception)
            {
                flag2 = false;
            }
            return flag2;
        }

        private static string GetIPAddress()
        {
            try
            {
                return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            UpdateProgressBar(uiProgressBar1, e.ProgressPercentage);
        }

        private void WebClientDownloadCompleted(object sender, AsyncCompletedEventArgs args)
        {
            if (!args.Cancelled && args.Error == null)
            {
                UpdateProgressBar(uiProgressBar1, 100);
                UpdateLabel(lblStatus, "Tải bộ cài đặt SQL Express 2008 SP2 R2 từ trang chủ thành công ");
                DownloadComplete = true;
            }
            handle.Set();
        }
        private void DownloadFile()
        {
            try
            {
                string path = Path.Combine(AppDir, "SQLEXPR_x86_SP2_R2.exe");
                using (WebClient client = new WebClient())
                {
                    var ur = new Uri("http://ecs.softech.cloud/Tool/SQLEXPR_x86_SP2_R2.exe");
                    client.DownloadProgressChanged += WebClientDownloadProgressChanged;
                    client.DownloadFileCompleted += WebClientDownloadCompleted;
                    client.DownloadFileAsync(ur, path);
                    handle.WaitOne();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
        public bool InstallSQL2005(string instanceName, ref string serverAddr, ref string ketQua, BackgroundWorker bgw, Label lblStatus)
        {
            bool flag3 = true;
            string[] strArray;
            try
            {
                UpdateLabel(lblStatus, "Đang kiểm tra bộ cài SQL...");
                string path = Path.Combine(AppDir, "SQLEXPRESS_2005.exe");
                if (!File.Exists(path))
                {
                    try
                    {
                        UpdateLabel(lblStatus, "Đang tiến hành tải bộ cài đặt SQL từ trang chủ .Vui lòng không tắt kết nối Internet ...");
                        using (WebClient client = new WebClient())
                        {
                            var ur = new Uri("http://ecs.softech.cloud/Tool/SQLEXPRESS_2005.exe");
                            client.DownloadProgressChanged += WebClientDownloadProgressChanged;
                            client.DownloadFileCompleted += WebClientDownloadCompleted;
                            client.DownloadFileAsync(ur, path);
                            handle.WaitOne();
                        }
                        while (!DownloadComplete)
                        {
                            Application.DoEvents();
                        }
                        DownloadComplete = false;
                    }
                    catch
                    {
                        ketQua = "Không thể tải bộ cài đặt SQL Express 2005 từ trang chủ .Vui lòng kiểm tra lại kết nối Internet rồi sau đó thử lại ...";
                        UpdateLabel(lblStatus, ketQua);
                        bgw.ReportProgress(100);
                        flag3 = false;
                    }
                }
                if (flag3)
                {
                    string machineName = "";
                    string serviceName;
                    bgw.ReportProgress(10);
                    UpdateProgressBar(uiProgressBar1, 10);
                    UpdateLabel(lblStatus, "Đang kiểm tra địa chỉ IP máy nhánh...");
                    if (GetIPAddress().Trim().Length == 0)
                    {
                        machineName = Environment.MachineName;
                    }
                    machineName = Environment.MachineName;
                    bgw.ReportProgress(20);
                    UpdateProgressBar(uiProgressBar1, 20);
                    UpdateLabel(lblStatus, "Đang tiến hành kiểm tra SQL Service...");
                    ServiceController controller = null;
                    bool flag = false;
                    controller = new ServiceController("MSSQL$" + instanceName);
                    try
                    {
                        serviceName = controller.ServiceName;
                        flag = true;
                    }
                    catch
                    {
                        flag = false;
                    }
                    if (flag)
                    {
                        //strArray = new string[] { machineName, @"\", instanceName, ",", Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\" + instanceName + @"\MSSQLServer\SuperSocketNetLib\Tcp", true).GetValue("TcpPort").ToString() };
                        //serverAddr = string.Concat(strArray);
                        ketQua = "Đã tồn tại Instance " + instanceName;
                        UpdateLabel(lblStatus, ketQua);
                        bgw.ReportProgress(100);
                        UpdateProgressBar(uiProgressBar1, 100);
                        flag3 = true;
                    }
                    else
                    {
                        bgw.ReportProgress(40);
                        UpdateProgressBar(uiProgressBar1, 40);
                        UpdateLabel(lblStatus, "Đang tiến hành cài đặt SQL Server 2005...");
                        string arguments = "";
                        arguments = "/qb USERNAME=\"sa\" COMPANYNAME=\"WM\" ADDLOCAL=ALL  DISABLENETWORKPROTOCOLS=\"0\" INSTANCENAME=\"" + instanceName + "\" SECURITYMODE=\"SQL\" SAPWD=\"123456\"";
                        ProcessStartInfo info = new ProcessStartInfo(path, arguments)
                        {
                            UseShellExecute = true,
                            Verb = "runas"
                        };
                        Process process = new Process
                        {
                            StartInfo = info
                        };
                        process.Start();
                        process.WaitForExit();
                        bgw.ReportProgress(70);
                        UpdateProgressBar(uiProgressBar1, 70);
                        UpdateLabel(lblStatus, "Đang tiến hành kiểm tra SQL Service...");
                        bool flag2 = false;
                        controller = new ServiceController("MSSQL$" + instanceName);
                        try
                        {
                            serviceName = controller.ServiceName;
                            flag2 = true;
                        }
                        catch
                        {
                            flag2 = false;
                        }
                        if (!flag2)
                        {
                            strArray = new string[] { "Cài đặt SQL Server 2005 không thành công", Environment.NewLine, path, " ", arguments };
                            ketQua = string.Concat(strArray);
                            UpdateLabel(lblStatus, ketQua);
                            bgw.ReportProgress(100);
                            UpdateProgressBar(uiProgressBar1, 100);
                            flag3 = false;
                        }
                        else
                        {
                            bgw.ReportProgress(80);
                            UpdateProgressBar(uiProgressBar1, 80);
                            UpdateLabel(lblStatus, "Đang tiến hành kiểm tra cấu hình SQL Server...");
                            string str6 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\" + instanceName + @"\MSSQLServer\SuperSocketNetLib\Tcp", true).GetValue("TcpPort").ToString();
                            bgw.ReportProgress(90);
                            UpdateProgressBar(uiProgressBar1, 90);
                            UpdateLabel(lblStatus, "Đang tiến hành tạo rule firewall cho SQL Server...");
                            StringBuilder builder = new StringBuilder();
                            builder.AppendLine("netsh advfirewall firewall delete rule name = SQLPort_eBH");
                            builder.AppendLine("netsh advfirewall firewall add rule name = SQLPort_eBH dir = in protocol = tcp action = allow localport = " + str6 + " remoteip = localsubnet profile = ANY");
                            File.WriteAllText(Path.Combine(AppDir, "InstallRule.bat"), builder.ToString());
                            ProcessStartInfo info2 = new ProcessStartInfo(Path.Combine(AppDir, "InstallRule.bat"))
                            {
                                UseShellExecute = true,
                                Verb = "runas"
                            };
                            Process process2 = new Process
                            {
                                StartInfo = { CreateNoWindow = true }
                            };
                            process2.StartInfo = info2;
                            process2.Start();
                            process2.WaitForExit();
                            bgw.ReportProgress(95);
                            UpdateProgressBar(uiProgressBar1, 95);
                            strArray = new string[] { machineName, @"\", instanceName, ",", str6 };
                            serverAddr = string.Concat(strArray);
                            ketQua = "Đã cài đặt SQL Server 2005 thành công";
                            UpdateLabel(lblStatus, ketQua);
                            bgw.ReportProgress(100);
                            UpdateProgressBar(uiProgressBar1, 100);
                            flag3 = true;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                if (!ReferenceEquals(exception.InnerException, null))
                {
                    object[] objArray = new object[] { "Message : ", exception.Message, Environment.NewLine, "Inner : ", exception.InnerException, Environment.NewLine, "Stack Trace : ", exception.StackTrace };
                    ketQua = string.Concat(objArray);
                }
                else
                {
                    strArray = new string[] { "Message : ", exception.Message, Environment.NewLine, "Stack Trace : ", exception.StackTrace };
                    ketQua = string.Concat(strArray);
                }
                UpdateLabel(lblStatus, ketQua);
                bgw.ReportProgress(100);
                UpdateProgressBar(uiProgressBar1, 100);
                flag3 = false;
            }
            return flag3;
        }
        public bool Install(string instanceName, ref string serverAddr, ref string ketQua, BackgroundWorker bgw, Label lblStatus)
        {
            bool flag3 = true;
            string[] strArray;
            try
            {
                UpdateLabel(lblStatus, "Đang kiểm tra bộ cài SQL...");
                string path = Path.Combine(AppDir, "SQLEXPR_x86_SP2_R2.exe");
                if (!File.Exists(path))
                {
                    try
                    {
                        UpdateLabel(lblStatus, "Đang tiến hành tải bộ cài đặt SQL từ trang chủ .Vui lòng không tắt kết nối Internet ...");
                        using (WebClient client = new WebClient())
                        {
                            var ur = new Uri("http://ecs.softech.cloud/Tool/SQLEXPR_x86_SP2_R2.exe");
                            client.DownloadProgressChanged += WebClientDownloadProgressChanged;
                            client.DownloadFileCompleted += WebClientDownloadCompleted;
                            client.DownloadFileAsync(ur, path);
                            handle.WaitOne();
                        }
                        while (!DownloadComplete)
                        {
                            Application.DoEvents();
                        }
                        DownloadComplete = false;
                    }
                    catch
                    {
                        ketQua = "Không thể tải bộ cài đặt SQL Express 2008 SP2 R2 từ trang chủ .Vui lòng kiểm tra lại kết nối Internet rồi sau đó thử lại ...";
                        UpdateLabel(lblStatus, ketQua);
                        bgw.ReportProgress(100);
                        flag3 = false;
                    }
                }
                if (flag3)
                {
                    string machineName = "";
                    string serviceName;
                    bgw.ReportProgress(10);
                    UpdateProgressBar(uiProgressBar1, 10);
                    UpdateLabel(lblStatus, "Đang kiểm tra địa chỉ IP máy nhánh...");
                    if (GetIPAddress().Trim().Length == 0)
                    {
                        machineName = Environment.MachineName;
                    }
                    bgw.ReportProgress(20);
                    UpdateProgressBar(uiProgressBar1, 20);
                    UpdateLabel(lblStatus, "Đang tiến hành kiểm tra SQL Service...");
                    ServiceController controller = null;
                    bool flag = false;
                    controller = new ServiceController("MSSQL$" + instanceName);
                    try
                    {
                        serviceName = controller.ServiceName;
                        flag = true;
                    }
                    catch
                    {
                        flag = false;
                    }
                    if (flag)
                    {
                        strArray = new string[] { machineName, @"\", instanceName, ",", Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\" + instanceName + @"\MSSQLServer\SuperSocketNetLib\Tcp", true).GetValue("TcpPort").ToString() };
                        serverAddr = string.Concat(strArray);
                        ketQua = "Đã tồn tại Instance " + instanceName;
                        UpdateLabel(lblStatus, ketQua);
                        bgw.ReportProgress(100);
                        UpdateProgressBar(uiProgressBar1, 100);
                        flag3 = true;
                    }
                    else
                    {
                        bgw.ReportProgress(40);
                        UpdateProgressBar(uiProgressBar1, 40);
                        UpdateLabel(lblStatus, "Đang tiến hành cài đặt SQL Server 2008...");
                        string arguments = "";
                        arguments = "/q /ACTION=INSTALL /FEATURES=SQL /INSTANCENAME=" + instanceName + " /SQLSVCSTARTUPTYPE=Automatic /SQLSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\" /SQLSYSADMINACCOUNTS=\"BUILTIN\\Administrators\" /AGTSVCACCOUNT=\"NT AUTHORITY\\Network Service\" /ADDCURRENTUSERASSQLADMIN=true /TCPENABLED=1 /NPENABLED=1 /SECURITYMODE=SQL /SAPWD=123456 /IACCEPTSQLSERVERLICENSETERMS=true /HIDECONSOLE";
                        ProcessStartInfo info = new ProcessStartInfo(path, arguments)
                        {
                            UseShellExecute = true,
                            Verb = "runas"
                        };
                        Process process = new Process
                        {
                            StartInfo = info
                        };
                        process.Start();
                        process.WaitForExit();
                        bgw.ReportProgress(70);
                        UpdateProgressBar(uiProgressBar1, 70);
                        UpdateLabel(lblStatus, "Đang tiến hành kiểm tra SQL Service...");
                        bool flag2 = false;
                        controller = new ServiceController("MSSQL$" + instanceName);
                        try
                        {
                            serviceName = controller.ServiceName;
                            flag2 = true;
                        }
                        catch
                        {
                            flag2 = false;
                        }
                        if (!flag2)
                        {
                            strArray = new string[] { "Cài đặt SQL Server 2008 không thành công", Environment.NewLine, path, " ", arguments };
                            ketQua = string.Concat(strArray);
                            UpdateLabel(lblStatus, ketQua);
                            bgw.ReportProgress(100);
                            UpdateProgressBar(uiProgressBar1, 100);
                            flag3 = false;
                        }
                        else
                        {
                            bgw.ReportProgress(80);
                            UpdateProgressBar(uiProgressBar1, 80);
                            UpdateLabel(lblStatus, "Đang tiến hành kiểm tra cấu hình SQL Server...");
                            string str6 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\" + instanceName + @"\MSSQLServer\SuperSocketNetLib\Tcp", true).GetValue("TcpPort").ToString();
                            bgw.ReportProgress(90);
                            UpdateProgressBar(uiProgressBar1, 90);
                            UpdateLabel(lblStatus, "Đang tiến hành tạo rule firewall cho SQL Server...");
                            StringBuilder builder = new StringBuilder();
                            builder.AppendLine("netsh advfirewall firewall delete rule name = SQLPort_eBH");
                            builder.AppendLine("netsh advfirewall firewall add rule name = SQLPort_eBH dir = in protocol = tcp action = allow localport = " + str6 + " remoteip = localsubnet profile = ANY");
                            File.WriteAllText(Path.Combine(AppDir, "InstallRule.bat"), builder.ToString());
                            ProcessStartInfo info2 = new ProcessStartInfo(Path.Combine(AppDir, "InstallRule.bat"))
                            {
                                UseShellExecute = true,
                                Verb = "runas"
                            };
                            Process process2 = new Process
                            {
                                StartInfo = { CreateNoWindow = true }
                            };
                            process2.StartInfo = info2;
                            process2.Start();
                            process2.WaitForExit();
                            bgw.ReportProgress(95);
                            UpdateProgressBar(uiProgressBar1, 95);
                            strArray = new string[] { machineName, @"\", instanceName, ",", str6 };
                            serverAddr = string.Concat(strArray);
                            ketQua = "Đã cài đặt SQL Server 2008 thành công";
                            UpdateLabel(lblStatus, ketQua);
                            bgw.ReportProgress(100);
                            UpdateProgressBar(uiProgressBar1, 100);
                            flag3 = true;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                if (!ReferenceEquals(exception.InnerException, null))
                {
                    object[] objArray = new object[] { "Message : ", exception.Message, Environment.NewLine, "Inner : ", exception.InnerException, Environment.NewLine, "Stack Trace : ", exception.StackTrace };
                    ketQua = string.Concat(objArray);
                }
                else
                {
                    strArray = new string[] { "Message : ", exception.Message, Environment.NewLine, "Stack Trace : ", exception.StackTrace };
                    ketQua = string.Concat(strArray);
                }
                UpdateLabel(lblStatus, ketQua);
                bgw.ReportProgress(100);
                UpdateProgressBar(uiProgressBar1, 100);
                flag3 = false;
            }
            return flag3;
        }

        private static void UpdateLabel(Label lbl, string text)
        {
            Action method = () => lbl.Text = text;
            lbl.Invoke(method);
        }

        private static void UpdateProgressBar(Janus.Windows.EditControls.UIProgressBar pgb, int Value)
        {
            Action method = () => pgb.Value = Value;
            pgb.Invoke(method);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateProgressBar(uiProgressBar1, e.ProgressPercentage);
        }

        private void SetupSQLServerForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
