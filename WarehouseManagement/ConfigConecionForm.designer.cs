namespace WarehouseManagement
{
    partial class ConfigConecionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigConecionForm));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.cbDatabaseSource = new Janus.Windows.EditControls.UIComboBox();
            this.txtServerName = new Janus.Windows.EditControls.UIComboBox();
            this.txtPass = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtSa = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.btnSetupSQL = new Janus.Windows.EditControls.UIButton();
            this.btnRestoreDatabase = new Janus.Windows.EditControls.UIButton();
            this.btnTaoCSDL = new Janus.Windows.EditControls.UIButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.btnClose);
            this.uiGroupBox1.Controls.Add(this.btnSave);
            this.uiGroupBox1.Controls.Add(this.cbDatabaseSource);
            this.uiGroupBox1.Controls.Add(this.txtServerName);
            this.uiGroupBox1.Controls.Add(this.txtPass);
            this.uiGroupBox1.Controls.Add(this.txtSa);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(605, 266);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(363, 196);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(190, 196);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu cấu hình";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbDatabaseSource
            // 
            this.cbDatabaseSource.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabaseSource.Location = new System.Drawing.Point(190, 155);
            this.cbDatabaseSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDatabaseSource.Name = "cbDatabaseSource";
            this.cbDatabaseSource.Size = new System.Drawing.Size(348, 27);
            this.cbDatabaseSource.TabIndex = 4;
            this.cbDatabaseSource.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbDatabaseSource.Closed += new System.EventHandler(this.cbDatabaseSource_Closed);
            this.cbDatabaseSource.SelectedIndexChanged += new System.EventHandler(this.cbDatabaseSource_SelectedIndexChanged);
            this.cbDatabaseSource.DropDown += new System.EventHandler(this.cbDatabaseSource_DropDown);
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(190, 32);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(348, 27);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.txtServerName.SelectedIndexChanged += new System.EventHandler(this.txtServerName_SelectedIndexChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(190, 114);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(348, 27);
            this.txtPass.TabIndex = 3;
            this.txtPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSa
            // 
            this.txtSa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSa.Location = new System.Drawing.Point(190, 71);
            this.txtSa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSa.Name = "txtSa";
            this.txtSa.Size = new System.Drawing.Size(348, 27);
            this.txtSa.TabIndex = 2;
            this.txtSa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên CSDL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên / IP máy chủ :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.Location = new System.Drawing.Point(0, 0);
            this.uiTab1.Margin = new System.Windows.Forms.Padding(5);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Size = new System.Drawing.Size(607, 294);
            this.uiTab1.TabIndex = 4;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1});
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.uiGroupBox1);
            this.uiTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.Image")));
            this.uiTabPage2.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(605, 266);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "Cấu hình thông số kết nối";
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.btnSetupSQL);
            this.uiTabPage1.Controls.Add(this.btnRestoreDatabase);
            this.uiTabPage1.Controls.Add(this.btnTaoCSDL);
            this.uiTabPage1.Controls.Add(this.label10);
            this.uiTabPage1.Controls.Add(this.label6);
            this.uiTabPage1.Controls.Add(this.label5);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(605, 266);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "Cài đặt cơ sở dữ liệu";
            // 
            // btnSetupSQL
            // 
            this.btnSetupSQL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupSQL.Image = ((System.Drawing.Image)(resources.GetObject("btnSetupSQL.Image")));
            this.btnSetupSQL.Location = new System.Drawing.Point(18, 57);
            this.btnSetupSQL.Name = "btnSetupSQL";
            this.btnSetupSQL.Size = new System.Drawing.Size(576, 31);
            this.btnSetupSQL.TabIndex = 5;
            this.btnSetupSQL.Text = "1 . Cài đặt SQL Server";
            this.btnSetupSQL.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSetupSQL.Click += new System.EventHandler(this.btnSetupSQL_Click);
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDatabase.Image")));
            this.btnRestoreDatabase.Location = new System.Drawing.Point(18, 219);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(576, 31);
            this.btnRestoreDatabase.TabIndex = 6;
            this.btnRestoreDatabase.Text = "Khôi phục cơ sở dữ liệu";
            this.btnRestoreDatabase.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // btnTaoCSDL
            // 
            this.btnTaoCSDL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoCSDL.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoCSDL.Image")));
            this.btnTaoCSDL.Location = new System.Drawing.Point(18, 138);
            this.btnTaoCSDL.Name = "btnTaoCSDL";
            this.btnTaoCSDL.Size = new System.Drawing.Size(576, 31);
            this.btnTaoCSDL.TabIndex = 7;
            this.btnTaoCSDL.Text = "2 . Tạo cơ sở dữ liệu";
            this.btnTaoCSDL.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnTaoCSDL.Click += new System.EventHandler(this.btnTaoCSDL_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(18, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(420, 38);
            this.label10.TabIndex = 3;
            this.label10.Text = "Khôi phục Cơ sở dữ liệu\r\n(Trường hợp đã có Cơ sở dữ liệu thì dùng chức năng này)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(18, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(470, 38);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bước 2 : Tạo mới cơ sở dữ liệu\r\n(Trường hợp đã có Cơ sở dữ liệu trước đó thì bỏ q" +
                "ua bước này ) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bước 1  : Cài đặt Hệ quản trị cơ sở dữ liệu SQL Server \r\n(Nếu máy đã cài đặt thì " +
                "bỏ qua bước này)";
            // 
            // ConfigConecionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(607, 294);
            this.Controls.Add(this.uiTab1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConfigConecionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình thông số kết nối";
            this.Load += new System.EventHandler(this.ConfigConecionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIComboBox cbDatabaseSource;
        private Janus.Windows.EditControls.UIComboBox txtServerName;
        private Janus.Windows.GridEX.EditControls.EditBox txtPass;
        private Janus.Windows.GridEX.EditControls.EditBox txtSa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.EditControls.UIButton btnSetupSQL;
        private Janus.Windows.EditControls.UIButton btnRestoreDatabase;
        private Janus.Windows.EditControls.UIButton btnTaoCSDL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}