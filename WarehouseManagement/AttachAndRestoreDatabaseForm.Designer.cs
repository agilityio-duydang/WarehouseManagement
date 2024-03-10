namespace WarehouseManagement
{
    partial class AttachAndRestoreDatabaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachAndRestoreDatabaseForm));
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtFileLdf = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnSelectFileLdf = new Janus.Windows.EditControls.UIButton();
            this.rdbFromFile = new Janus.Windows.EditControls.UIRadioButton();
            this.btnSelectFileMdf = new Janus.Windows.EditControls.UIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileMdf = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtFolderDatabase = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnSelectFolderDatabase = new Janus.Windows.EditControls.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnRestoreDatabase = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtFileBackup = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnSelectFileBackup = new Janus.Windows.EditControls.UIButton();
            this.rdbFromBak = new Janus.Windows.EditControls.UIRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox5.Controls.Add(this.txtFileLdf);
            this.uiGroupBox5.Controls.Add(this.btnSelectFileLdf);
            this.uiGroupBox5.Controls.Add(this.rdbFromFile);
            this.uiGroupBox5.Controls.Add(this.btnSelectFileMdf);
            this.uiGroupBox5.Controls.Add(this.label8);
            this.uiGroupBox5.Controls.Add(this.label7);
            this.uiGroupBox5.Controls.Add(this.label6);
            this.uiGroupBox5.Controls.Add(this.label5);
            this.uiGroupBox5.Controls.Add(this.label4);
            this.uiGroupBox5.Controls.Add(this.txtFileMdf);
            this.uiGroupBox5.Controls.Add(this.label3);
            this.uiGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox5.Location = new System.Drawing.Point(0, 140);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(695, 225);
            this.uiGroupBox5.TabIndex = 12;
            this.uiGroupBox5.Text = "      &Từ File CSDL";
            this.uiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtFileLdf
            // 
            this.txtFileLdf.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileLdf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLdf.Location = new System.Drawing.Point(176, 68);
            this.txtFileLdf.Name = "txtFileLdf";
            this.txtFileLdf.Size = new System.Drawing.Size(348, 27);
            this.txtFileLdf.TabIndex = 1;
            this.txtFileLdf.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFileLdf.ButtonClick += new System.EventHandler(this.txtFileLdf_ButtonClick);
            // 
            // btnSelectFileLdf
            // 
            this.btnSelectFileLdf.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFileLdf.Image")));
            this.btnSelectFileLdf.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectFileLdf.Location = new System.Drawing.Point(530, 66);
            this.btnSelectFileLdf.Name = "btnSelectFileLdf";
            this.btnSelectFileLdf.Size = new System.Drawing.Size(148, 31);
            this.btnSelectFileLdf.TabIndex = 7;
            this.btnSelectFileLdf.Text = "&Chọn File";
            this.btnSelectFileLdf.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectFileLdf.Click += new System.EventHandler(this.txtFileLdf_ButtonClick);
            // 
            // rdbFromFile
            // 
            this.rdbFromFile.AutoSize = true;
            this.rdbFromFile.Location = new System.Drawing.Point(9, 0);
            this.rdbFromFile.Name = "rdbFromFile";
            this.rdbFromFile.Size = new System.Drawing.Size(17, 24);
            this.rdbFromFile.TabIndex = 0;
            this.rdbFromFile.Click += new System.EventHandler(this.rdbFromFile_Click);
            // 
            // btnSelectFileMdf
            // 
            this.btnSelectFileMdf.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFileMdf.Image")));
            this.btnSelectFileMdf.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectFileMdf.Location = new System.Drawing.Point(530, 30);
            this.btnSelectFileMdf.Name = "btnSelectFileMdf";
            this.btnSelectFileMdf.Size = new System.Drawing.Size(148, 31);
            this.btnSelectFileMdf.TabIndex = 7;
            this.btnSelectFileMdf.Text = "&Chọn File";
            this.btnSelectFileMdf.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectFileMdf.Click += new System.EventHandler(this.txtFileMdf_ButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(43, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "- Nhấn Đóng để Bỏ qua và Thoát";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(43, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "- Nhấn Thực hiện để Khôi phục lại CSDL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(23, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(634, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nếu thực hiện tạo lại  WAREHOUSEMANAGEMENT_V1 thì toàn bộ dữ liệu cũ sẽ bị mất .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(23, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cơ sở dữ liệu WAREHOUSEMANAGEMENT_V1 đã có";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "File CSDL (.ldf)";
            // 
            // txtFileMdf
            // 
            this.txtFileMdf.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileMdf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileMdf.Location = new System.Drawing.Point(176, 32);
            this.txtFileMdf.Name = "txtFileMdf";
            this.txtFileMdf.Size = new System.Drawing.Size(348, 27);
            this.txtFileMdf.TabIndex = 1;
            this.txtFileMdf.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFileMdf.ButtonClick += new System.EventHandler(this.txtFileMdf_ButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "File CSDL (.mdf)";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Controls.Add(this.txtFolderDatabase);
            this.uiGroupBox2.Controls.Add(this.btnSelectFolderDatabase);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 68);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(695, 72);
            this.uiGroupBox2.TabIndex = 10;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtFolderDatabase
            // 
            this.txtFolderDatabase.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFolderDatabase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderDatabase.Location = new System.Drawing.Point(173, 27);
            this.txtFolderDatabase.Name = "txtFolderDatabase";
            this.txtFolderDatabase.Size = new System.Drawing.Size(348, 27);
            this.txtFolderDatabase.TabIndex = 1;
            this.txtFolderDatabase.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFolderDatabase.ButtonClick += new System.EventHandler(this.txtFolderDatabase_ButtonClick);
            // 
            // btnSelectFolderDatabase
            // 
            this.btnSelectFolderDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFolderDatabase.Image")));
            this.btnSelectFolderDatabase.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectFolderDatabase.Location = new System.Drawing.Point(530, 25);
            this.btnSelectFolderDatabase.Name = "btnSelectFolderDatabase";
            this.btnSelectFolderDatabase.Size = new System.Drawing.Size(148, 31);
            this.btnSelectFolderDatabase.TabIndex = 7;
            this.btnSelectFolderDatabase.Text = "&Chọn Thư mục";
            this.btnSelectFolderDatabase.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectFolderDatabase.Click += new System.EventHandler(this.txtFolderDatabase_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục lưu CSDL";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.btnClose);
            this.uiGroupBox1.Controls.Add(this.btnRestoreDatabase);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 365);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(695, 52);
            this.uiGroupBox1.TabIndex = 9;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(570, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đón&g";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDatabase.Image")));
            this.btnRestoreDatabase.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRestoreDatabase.Location = new System.Drawing.Point(451, 13);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(113, 31);
            this.btnRestoreDatabase.TabIndex = 7;
            this.btnRestoreDatabase.Text = "&Thực hiện";
            this.btnRestoreDatabase.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox4.Controls.Add(this.txtFileBackup);
            this.uiGroupBox4.Controls.Add(this.btnSelectFileBackup);
            this.uiGroupBox4.Controls.Add(this.rdbFromBak);
            this.uiGroupBox4.Controls.Add(this.label2);
            this.uiGroupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox4.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(695, 68);
            this.uiGroupBox4.TabIndex = 11;
            this.uiGroupBox4.Text = "      &Từ File sao lưu";
            this.uiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtFileBackup
            // 
            this.txtFileBackup.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileBackup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileBackup.Location = new System.Drawing.Point(170, 26);
            this.txtFileBackup.Name = "txtFileBackup";
            this.txtFileBackup.Size = new System.Drawing.Size(348, 27);
            this.txtFileBackup.TabIndex = 1;
            this.txtFileBackup.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFileBackup.ButtonClick += new System.EventHandler(this.txtFileBackup_ButtonClick);
            // 
            // btnSelectFileBackup
            // 
            this.btnSelectFileBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFileBackup.Image")));
            this.btnSelectFileBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectFileBackup.Location = new System.Drawing.Point(530, 24);
            this.btnSelectFileBackup.Name = "btnSelectFileBackup";
            this.btnSelectFileBackup.Size = new System.Drawing.Size(148, 31);
            this.btnSelectFileBackup.TabIndex = 7;
            this.btnSelectFileBackup.Text = "&Chọn File";
            this.btnSelectFileBackup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectFileBackup.Click += new System.EventHandler(this.txtFileBackup_ButtonClick);
            // 
            // rdbFromBak
            // 
            this.rdbFromBak.AutoSize = true;
            this.rdbFromBak.Location = new System.Drawing.Point(9, -2);
            this.rdbFromBak.Name = "rdbFromBak";
            this.rdbFromBak.Size = new System.Drawing.Size(17, 24);
            this.rdbFromBak.TabIndex = 0;
            this.rdbFromBak.Click += new System.EventHandler(this.rdbFromBak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "File sao lưu (.bak)";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AttachAndRestoreDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.uiGroupBox5);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AttachAndRestoreDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.FormAttachAndRestoreDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private Janus.Windows.GridEX.EditControls.EditBox txtFileLdf;
        private Janus.Windows.EditControls.UIButton btnSelectFileLdf;
        private Janus.Windows.EditControls.UIRadioButton rdbFromFile;
        private Janus.Windows.EditControls.UIButton btnSelectFileMdf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.GridEX.EditControls.EditBox txtFileMdf;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.GridEX.EditControls.EditBox txtFolderDatabase;
        private Janus.Windows.EditControls.UIButton btnSelectFolderDatabase;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIButton btnRestoreDatabase;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Janus.Windows.GridEX.EditControls.EditBox txtFileBackup;
        private Janus.Windows.EditControls.UIButton btnSelectFileBackup;
        private Janus.Windows.EditControls.UIRadioButton rdbFromBak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}