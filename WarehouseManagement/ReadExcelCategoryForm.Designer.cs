namespace WarehouseManagement
{
    partial class ReadExcelCategoryForm
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
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadExcelCategoryForm));
            Janus.Windows.GridEX.GridEXLayout dgListInValid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgListInValid = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnExport = new Janus.Windows.EditControls.UIButton();
            this.btnConfirm = new Janus.Windows.EditControls.UIButton();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.linkFileExcel = new System.Windows.Forms.LinkLabel();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnSelectFile = new Janus.Windows.EditControls.UIButton();
            this.btnReadFile = new Janus.Windows.EditControls.UIButton();
            this.txtFilePath = new Janus.Windows.GridEX.EditControls.EditBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListInValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.AutoScroll = true;
            this.uiGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox3.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox1);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(1137, 602);
            this.uiGroupBox3.TabIndex = 318;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.AutoScroll = true;
            this.uiGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox4.Controls.Add(this.uiTab1);
            this.uiGroupBox4.Controls.Add(this.uiGroupBox2);
            this.uiGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox4.Location = new System.Drawing.Point(3, 73);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(1131, 526);
            this.uiGroupBox4.TabIndex = 323;
            this.uiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.Location = new System.Drawing.Point(3, 8);
            this.uiTab1.Margin = new System.Windows.Forms.Padding(5);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Size = new System.Drawing.Size(1125, 459);
            this.uiTab1.TabIndex = 321;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1});
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.dgList);
            this.uiTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.Image")));
            this.uiTabPage2.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1123, 431);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "Danh sách nhóm hàng hoá hợp lệ";
            // 
            // dgList
            // 
            this.dgList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GroupByBoxVisible = false;
            this.dgList.Location = new System.Drawing.Point(0, 0);
            this.dgList.Margin = new System.Windows.Forms.Padding(5);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(1123, 431);
            this.dgList.TabIndex = 7;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.dgListInValid);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1123, 431);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "Danh sách nhóm hàng hoá không hợp lệ";
            // 
            // dgListInValid
            // 
            this.dgListInValid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgListInValid.ColumnAutoResize = true;
            dgListInValid_DesignTimeLayout.LayoutString = resources.GetString("dgListInValid_DesignTimeLayout.LayoutString");
            this.dgListInValid.DesignTimeLayout = dgListInValid_DesignTimeLayout;
            this.dgListInValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListInValid.GroupByBoxVisible = false;
            this.dgListInValid.Location = new System.Drawing.Point(0, 0);
            this.dgListInValid.Margin = new System.Windows.Forms.Padding(5);
            this.dgListInValid.Name = "dgListInValid";
            this.dgListInValid.RecordNavigator = true;
            this.dgListInValid.Size = new System.Drawing.Size(1123, 431);
            this.dgListInValid.TabIndex = 7;
            this.dgListInValid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Controls.Add(this.btnExport);
            this.uiGroupBox2.Controls.Add(this.btnConfirm);
            this.uiGroupBox2.Controls.Add(this.btnClose);
            this.uiGroupBox2.Controls.Add(this.linkFileExcel);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox2.Location = new System.Drawing.Point(3, 467);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(1125, 56);
            this.uiGroupBox2.TabIndex = 319;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(580, 16);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(278, 31);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Xuất Excel hàng hoá không hợp lệ";
            this.btnExport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageIndex = 4;
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Location = new System.Drawing.Point(866, 16);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 31);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Xác nhận ";
            this.btnConfirm.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageIndex = 4;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(985, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkFileExcel
            // 
            this.linkFileExcel.AutoSize = true;
            this.linkFileExcel.BackColor = System.Drawing.Color.Transparent;
            this.linkFileExcel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFileExcel.Location = new System.Drawing.Point(13, 22);
            this.linkFileExcel.Name = "linkFileExcel";
            this.linkFileExcel.Size = new System.Drawing.Size(110, 19);
            this.linkFileExcel.TabIndex = 17;
            this.linkFileExcel.TabStop = true;
            this.linkFileExcel.Text = "File Excel mẫu";
            this.linkFileExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFileExcel_LinkClicked);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.btnSelectFile);
            this.uiGroupBox1.Controls.Add(this.btnReadFile);
            this.uiGroupBox1.Controls.Add(this.txtFilePath);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(3, 8);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1131, 65);
            this.uiGroupBox1.TabIndex = 320;
            this.uiGroupBox1.Text = "Đường dẫn file Excel cần nhập";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
            this.btnSelectFile.ImageIndex = 4;
            this.btnSelectFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectFile.Location = new System.Drawing.Point(616, 24);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(113, 31);
            this.btnSelectFile.TabIndex = 16;
            this.btnSelectFile.Text = "Chọn File";
            this.btnSelectFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Image = ((System.Drawing.Image)(resources.GetObject("btnReadFile.Image")));
            this.btnReadFile.ImageIndex = 4;
            this.btnReadFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReadFile.Location = new System.Drawing.Point(735, 24);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(113, 31);
            this.btnReadFile.TabIndex = 18;
            this.btnReadFile.Text = "Đọc File";
            this.btnReadFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(10, 26);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(596, 27);
            this.txtFilePath.TabIndex = 15;
            // 
            // ReadExcelCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1137, 602);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11);
            this.Name = "ReadExcelCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đọc hàng hoá từ File Excel";
            this.Load += new System.EventHandler(this.ReadExcelCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListInValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.EditControls.UIButton btnExport;
        private Janus.Windows.EditControls.UIButton btnConfirm;
        private Janus.Windows.EditControls.UIButton btnClose;
        private System.Windows.Forms.LinkLabel linkFileExcel;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIButton btnSelectFile;
        private Janus.Windows.EditControls.UIButton btnReadFile;
        private Janus.Windows.GridEX.EditControls.EditBox txtFilePath;
        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.GridEX.GridEX dgListInValid;

    }
}