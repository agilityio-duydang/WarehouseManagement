namespace WarehouseManagement
{
    partial class ReadExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadExcelForm));
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnReadFile = new Janus.Windows.EditControls.UIButton();
            this.linkFileExcel = new System.Windows.Forms.LinkLabel();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtFilePath = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnSelectFile = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Controls.Add(this.btnClose);
            this.uiGroupBox2.Controls.Add(this.linkFileExcel);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 68);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(860, 53);
            this.uiGroupBox2.TabIndex = 318;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageIndex = 4;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(735, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Image = ((System.Drawing.Image)(resources.GetObject("btnReadFile.Image")));
            this.btnReadFile.ImageIndex = 4;
            this.btnReadFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReadFile.Location = new System.Drawing.Point(737, 21);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(113, 31);
            this.btnReadFile.TabIndex = 18;
            this.btnReadFile.Text = "Đọc File";
            this.btnReadFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // linkFileExcel
            // 
            this.linkFileExcel.AutoSize = true;
            this.linkFileExcel.BackColor = System.Drawing.Color.Transparent;
            this.linkFileExcel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFileExcel.Location = new System.Drawing.Point(13, 19);
            this.linkFileExcel.Name = "linkFileExcel";
            this.linkFileExcel.Size = new System.Drawing.Size(110, 19);
            this.linkFileExcel.TabIndex = 17;
            this.linkFileExcel.TabStop = true;
            this.linkFileExcel.Text = "File Excel mẫu";
            this.linkFileExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFileExcel_LinkClicked);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.AutoScroll = true;
            this.uiGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox3.Controls.Add(this.txtFilePath);
            this.uiGroupBox3.Controls.Add(this.btnReadFile);
            this.uiGroupBox3.Controls.Add(this.btnSelectFile);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(860, 68);
            this.uiGroupBox3.TabIndex = 317;
            this.uiGroupBox3.Text = "Đường dẫn file Excel cần nhập";
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(11, 23);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(596, 27);
            this.txtFilePath.TabIndex = 15;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
            this.btnSelectFile.ImageIndex = 4;
            this.btnSelectFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectFile.Location = new System.Drawing.Point(617, 21);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(113, 31);
            this.btnSelectFile.TabIndex = 16;
            this.btnSelectFile.Text = "Chọn File";
            this.btnSelectFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // ReadExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(860, 121);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReadExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đọc hàng hoá từ File Excel";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIButton btnReadFile;
        private System.Windows.Forms.LinkLabel linkFileExcel;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.GridEX.EditControls.EditBox txtFilePath;
        private Janus.Windows.EditControls.UIButton btnSelectFile;
    }
}