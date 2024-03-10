namespace WarehouseManagement
{
    partial class SetupSQLServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupSQLServerForm));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.uiProgressBar1 = new Janus.Windows.EditControls.UIProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.lblStatus);
            this.uiGroupBox1.Controls.Add(this.uiProgressBar1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 365);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(761, 105);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quá trình cài đặt có thể mất từ 5 đến 15 phút . Vui lòng không tắt chương trình h" +
                "oặc khởi động lại máy tính";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(6, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(751, 14);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Đang tiến hành tải bộ cài đặt SQL từ trang chủ . Vui lòng không ngắt kết nối Inte" +
                "rnet";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiProgressBar1
            // 
            this.uiProgressBar1.Location = new System.Drawing.Point(3, 44);
            this.uiProgressBar1.Name = "uiProgressBar1";
            this.uiProgressBar1.ShowPercentage = true;
            this.uiProgressBar1.Size = new System.Drawing.Size(754, 23);
            this.uiProgressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // SetupSQLServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(761, 470);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetupSQLServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cài đặt SQL Server";
            this.Load += new System.EventHandler(this.SetupSQLServerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private Janus.Windows.EditControls.UIProgressBar uiProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}