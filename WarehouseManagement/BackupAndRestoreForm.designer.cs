namespace WarehouseManagement
{
    partial class BackupAndRestoreForm
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupAndRestoreForm));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.grbRemind = new Janus.Windows.EditControls.UIGroupBox();
            this.chkCheckRemind = new Janus.Windows.EditControls.UICheckBox();
            this.cbbDateRemind = new Janus.Windows.EditControls.UIComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtPath = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnBrowers = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.btnBackup = new Janus.Windows.EditControls.UIButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbRemind)).BeginInit();
            this.grbRemind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.grbRemind);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox3);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox2);
            this.uiGroupBox1.Controls.Add(this.btnClose);
            this.uiGroupBox1.Controls.Add(this.btnSave);
            this.uiGroupBox1.Controls.Add(this.btnBackup);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(714, 349);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grbRemind
            // 
            this.grbRemind.AutoScroll = true;
            this.grbRemind.Controls.Add(this.chkCheckRemind);
            this.grbRemind.Controls.Add(this.cbbDateRemind);
            this.grbRemind.Controls.Add(this.label4);
            this.grbRemind.Controls.Add(this.label3);
            this.grbRemind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbRemind.Location = new System.Drawing.Point(3, 169);
            this.grbRemind.Margin = new System.Windows.Forms.Padding(4);
            this.grbRemind.Name = "grbRemind";
            this.grbRemind.Size = new System.Drawing.Size(708, 108);
            this.grbRemind.TabIndex = 8;
            this.grbRemind.Text = "Hiển thị nhắc nhở";
            this.grbRemind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chkCheckRemind
            // 
            this.chkCheckRemind.BackColor = System.Drawing.Color.Transparent;
            this.chkCheckRemind.Checked = true;
            this.chkCheckRemind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckRemind.Location = new System.Drawing.Point(163, 26);
            this.chkCheckRemind.Margin = new System.Windows.Forms.Padding(4);
            this.chkCheckRemind.Name = "chkCheckRemind";
            this.chkCheckRemind.Size = new System.Drawing.Size(177, 26);
            this.chkCheckRemind.TabIndex = 4;
            this.chkCheckRemind.Text = "Hiển thị nhắc nhở";
            this.chkCheckRemind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.chkCheckRemind.CheckedChanged += new System.EventHandler(this.chkCheckRemind_CheckedChanged);
            // 
            // cbbDateRemind
            // 
            this.cbbDateRemind.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "7";
            uiComboBoxItem1.Value = "7";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "15";
            uiComboBoxItem2.Value = "15";
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "30";
            uiComboBoxItem3.Value = "30";
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "60";
            uiComboBoxItem4.Value = "60";
            this.cbbDateRemind.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4});
            this.cbbDateRemind.Location = new System.Drawing.Point(206, 59);
            this.cbbDateRemind.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDateRemind.Name = "cbbDateRemind";
            this.cbbDateRemind.Size = new System.Drawing.Size(141, 27);
            this.cbbDateRemind.TabIndex = 5;
            this.cbbDateRemind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(355, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hiển thị nhắc nhở sau";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.AutoScroll = true;
            this.uiGroupBox3.Controls.Add(this.txtPath);
            this.uiGroupBox3.Controls.Add(this.label1);
            this.uiGroupBox3.Controls.Add(this.label2);
            this.uiGroupBox3.Controls.Add(this.txtDatabaseName);
            this.uiGroupBox3.Controls.Add(this.btnBrowers);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox3.Location = new System.Drawing.Point(3, 52);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(708, 117);
            this.uiGroupBox3.TabIndex = 0;
            this.uiGroupBox3.Text = "Thông tin sao lưu dữ liệu";
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(163, 26);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(491, 27);
            this.txtPath.TabIndex = 1;
            this.txtPath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên file :";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(163, 71);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(491, 27);
            this.txtDatabaseName.TabIndex = 3;
            this.txtDatabaseName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnBrowers
            // 
            this.btnBrowers.Location = new System.Drawing.Point(656, 26);
            this.btnBrowers.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowers.Name = "btnBrowers";
            this.btnBrowers.Size = new System.Drawing.Size(27, 27);
            this.btnBrowers.TabIndex = 2;
            this.btnBrowers.Text = "...";
            this.btnBrowers.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnBrowers.Click += new System.EventHandler(this.btnBrowers_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.Controls.Add(this.label8);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.Location = new System.Drawing.Point(3, 8);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(708, 44);
            this.uiGroupBox2.TabIndex = 0;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(26, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(574, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "* Vui lòng chọn thư mục( nếu bạn có quyền sao lưu dữ liệu) để lưu trữ dữ liệu.";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(437, 289);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(71, 289);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu cấu hình";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackup.Location = new System.Drawing.Point(247, 289);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(183, 33);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Thực hiện sao lưu";
            this.btnBackup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // BackupAndRestoreForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 349);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(730, 386);
            this.Name = "BackupAndRestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sao lưu và phục hồi dữ liệu";
            this.Load += new System.EventHandler(this.BackupAndRestoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbRemind)).EndInit();
            this.grbRemind.ResumeLayout(false);
            this.grbRemind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIButton btnBrowers;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIButton btnBackup;
        private Janus.Windows.GridEX.EditControls.EditBox txtDatabaseName;
        private Janus.Windows.GridEX.EditControls.EditBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIGroupBox grbRemind;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.EditControls.UICheckBox chkCheckRemind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIComboBox cbbDateRemind;
        private Janus.Windows.EditControls.UIButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}