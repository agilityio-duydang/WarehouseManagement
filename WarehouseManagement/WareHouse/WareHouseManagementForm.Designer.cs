namespace WarehouseManagement.WareHouse
{
    partial class WareHouseManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseManagementForm));
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtTenKho = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKho = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.btnExportReceipts = new Janus.Windows.EditControls.UIButton();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.txtTenKho);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.txtMaKho);
            this.uiGroupBox1.Controls.Add(this.label35);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(986, 112);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "Thông tin tìm kiếm";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(111, 65);
            this.txtTenKho.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(534, 27);
            this.txtTenKho.TabIndex = 7;
            this.txtTenKho.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtTenKho.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên kho : ";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(111, 28);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(534, 27);
            this.txtMaKho.TabIndex = 5;
            this.txtMaKho.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtMaKho.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 32);
            this.label35.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(76, 19);
            this.label35.TabIndex = 6;
            this.label35.Text = "Mã kho : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(655, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(738, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(860, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.AutoScroll = true;
            this.uiGroupBox3.Controls.Add(this.btnExportReceipts);
            this.uiGroupBox3.Controls.Add(this.label11);
            this.uiGroupBox3.Controls.Add(this.btnClose);
            this.uiGroupBox3.Controls.Add(this.btnDelete);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 490);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(986, 55);
            this.uiGroupBox3.TabIndex = 8;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dgList
            // 
            this.dgList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GroupByBoxVisible = false;
            this.dgList.Location = new System.Drawing.Point(0, 112);
            this.dgList.Margin = new System.Windows.Forms.Padding(5);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(986, 378);
            this.dgList.TabIndex = 10;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgList_RowDoubleClick);
            // 
            // btnExportReceipts
            // 
            this.btnExportReceipts.Image = ((System.Drawing.Image)(resources.GetObject("btnExportReceipts.Image")));
            this.btnExportReceipts.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExportReceipts.Location = new System.Drawing.Point(16, 16);
            this.btnExportReceipts.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportReceipts.Name = "btnExportReceipts";
            this.btnExportReceipts.Size = new System.Drawing.Size(113, 31);
            this.btnExportReceipts.TabIndex = 94;
            this.btnExportReceipts.Text = "Xuất Excel";
            this.btnExportReceipts.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExportReceipts.Click += new System.EventHandler(this.btnExportReceipts_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(137, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 19);
            this.label11.TabIndex = 93;
            this.label11.Text = "Hướng dẫn: Kích đôi để xem chi tiết";
            // 
            // WareHouseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WareHouseManagementForm";
            this.Text = "Theo dõi danh sách kho";
            this.Load += new System.EventHandler(this.WareHouseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.GridEX.EditControls.EditBox txtTenKho;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox txtMaKho;
        private System.Windows.Forms.Label label35;
        private Janus.Windows.EditControls.UIButton btnExportReceipts;
        private System.Windows.Forms.Label label11;
    }
}