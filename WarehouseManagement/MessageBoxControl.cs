using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace WarehouseManagement
{
    public partial class MessageBoxControl : BaseForm
    {
        public MessageBoxControl()
        {
            InitializeComponent();
        }
        public string ReturnValue = "Cancel";
        public string exceptionString = "";
        public bool ShowYesNoButton
        {
            set
            {
                this.btnNo.Visible = this.btnYes.Visible = value;
                this.btnCancel.Visible = !value;
                if (!value) this.CancelButton = btnCancel;
                else this.CancelButton = btnNo;
            }
        }

        public bool ShowErrorButton
        {
            set
            {

                this.btnSendError.Visible = value;
                //this.btnCancel.Visible = !this.btnNo.Visible;
            }
        }

        public string MessageString
        {
            set { this.txtMessage.Text = value; }
            get { return this.txtMessage.Text; }
        }

        public void dispEnglish()
        {
            this.Text = "Announcement";
            this.btnYes.Text = "&Yes";
            this.btnNo.Text = "&No";
            this.btnCancel.Text = "&Close";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Yes";
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "No";
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageBoxControl_Load(object sender, EventArgs e)
        {
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                //Ghi ảnh màn hình lỗi
                if (System.IO.Directory.Exists("Errors") == false)
                {
                    System.IO.Directory.CreateDirectory("Errors");
                }
                string fileName = Application.StartupPath + string.Format("\\Errors\\{0} - {1}.jpg", string.Empty, DateTime.Now.ToString().Replace("/", "").Replace("\\", "").Replace(":", ""));
                if (!SaveAsImage(fileName))
                    fileName = "";
                //Thông tin gởi email
                string subject = string.Format("Lỗi phần mềm", string.Empty);

                sendEmail(subject, this.MessageString, fileName, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, this.exceptionString);

                ShowMessage("Đã gởi thông tin lỗi tới nhà cung cấp phần mềm", false);
                this.Close();
            }
            catch (Exception ex)
            {
                ShowMessage("Xảy ra lỗi khi gởi thông tin lỗi tới nhà cung cấp phần mềm", false);
            }
        }
        #region Send email
        public static bool SendMailReg(string subject, string tenDN, string maDN, string maHQ, string soDT, string nguoiLH, string diachi, string email, string loaiHinh, string appVersion, string dataversion)
        {
            return sendEmail(subject, string.Empty, string.Empty, tenDN, maDN, maHQ, soDT, string.Empty, nguoiLH, diachi, email, loaiHinh, appVersion, dataversion, string.Empty, new List<string>());
        }
        public static void sendEmail(string subject, string body, string imagePath, string tenDN, string maDN, string soDT, string soFax, string nguoiLH, string loaiHinh, string appVersion, string dataversion, string exception)
        {
            sendEmail(subject, body, imagePath, maDN, maDN, "", soDT, soFax, nguoiLH, loaiHinh, appVersion, dataversion, exception);
        }
        public static bool sendEmail(string subject, string body, string imagePath, string tenDN, string maDN, string maHQ, string soDT, string soFax, string nguoiLH, string loaiHinh, string appVersion, string dataversion, string exception)
        {
            return sendEmail(subject, body, imagePath, tenDN, maDN, maHQ, soDT, soFax, nguoiLH, string.Empty, string.Empty, loaiHinh, appVersion, dataversion, exception, new List<string>());
        }
        public static bool sendEmail(string subject, string body, string imagePath, string tenDN, string maDN, string maHQ, string soDT, string soFax, string nguoiLH, string diachi, string email, string loaiHinh, string appVersion, string dataversion, string exception, List<string> Files)
        {
            try
            {
                string ccTo = "";//((SiteIdentity)MainForm.QuanTri.Identity).user.Email;
                string toEmail = "dangphuocduy@gmail.com";
                if (!CheckEmail(toEmail))
                    toEmail = "dangphuocduy@gmail.com";
                string fromEmail = "dangphuocduy@gmail.com";
                string content = "<font color=#1F497D><b>Hệ thống tự động báo lỗi</b><br><b>Tên doanh nghiệp:</b> " + tenDN + "<br>";
                content += string.IsNullOrEmpty(maDN) ? string.Empty : "<b>Mã doanh nghiệp: </b>" + maDN + "<br>";
                content += string.IsNullOrEmpty(diachi) ? string.Empty : "<b>Địa chỉ doanh nghiệp: </b>" + diachi + "<br>";
                content += string.IsNullOrEmpty(email) ? string.Empty : "<b>Email: </b>" + email + "<br>";
                content += string.IsNullOrEmpty(maHQ) ? string.Empty : "<b>Mã Hải quan: </b>" + maHQ + "<br>";
                content += string.IsNullOrEmpty(soDT) ? string.Empty : "<b>Số điện thoại: </b>" + soDT + "<br>";
                content += string.IsNullOrEmpty(maHQ) ? string.Empty : "<b>Số Fax: </b>" + soFax + "<br>";
                content += string.IsNullOrEmpty(maHQ) ? string.Empty : "<b>Người liên hệ: </b>" + nguoiLH + "<br>";
                MailMessage messageObj = new MailMessage();
                messageObj.Subject = subject;
                messageObj.Body = content;
                messageObj.IsBodyHtml = true;
                messageObj.Priority = MailPriority.Normal;
                if (imagePath != "")
                {
                    Attachment attachment = new Attachment(imagePath);
                    messageObj.Attachments.Add(attachment);
                }
                foreach (string item in Files)
                {
                    if (File.Exists(item))
                        messageObj.Attachments.Add(new Attachment(item));
                }
                #region Send Mail

                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromEmail, "GoodLuck@260696@2023");
                client.SendCompleted += new SendCompletedEventHandler(client_SendCompleted);
                messageObj.From = new MailAddress(fromEmail);
                messageObj.To.Add(toEmail);
                if (CheckEmail(ccTo))
                    messageObj.CC.Add(ccTo);

                #endregion Send Mail
                client.Timeout = 15000;
                client.SendAsync(messageObj, "Sending..");
                return true;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return false;
            }
        }

        static void client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;
            if (e.Error != null)
            {
                //comment by minhnd
                //throw e.Error;

            }
            else
            {
                //  LoggerWrapper.Logger.Write("Message Delivered.", LogCategory.Information);
            }
        }
        private static bool CheckEmail(string str)
        {
            Regex re = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (re.IsMatch(str))
                return true;
            else
                return false;
        }
        public static bool SaveAsImage(string filename)
        {
            try
            {
                Bitmap b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                Size s = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, s, CopyPixelOperation.SourceCopy);
                b.Save(filename, ImageFormat.Jpeg);
                return true;
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
                return false;
            }
            //b.Save(@"c:\ERROR.png", ImageFormat.Png);  
        }

        /// <summary>
        /// Kiểm tra chuỗi nhập vào có phải là kiểu số.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isNumber(string value)
        {
            bool isValid = true;

            char[] arr = value.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                isValid &= Char.IsNumber(arr[i]);
            }

            return isValid;
        }

        public static bool isEmail(string inputEmail)
        {
            return CheckEmail(inputEmail);
        }
        #endregion
    }
}
