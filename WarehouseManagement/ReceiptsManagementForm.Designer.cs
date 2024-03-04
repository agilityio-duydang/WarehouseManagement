namespace WarehouseManagement
{
    partial class ReceiptsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptsManagementForm));
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.lbltongThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbbLoaiThu = new Janus.Windows.EditControls.UIComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDenNgay = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.dateTuNgay = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new Janus.Windows.EditControls.UIButton();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnSendEmailReport = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgList
            // 
            this.dgList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GroupByBoxVisible = false;
            this.dgList.Location = new System.Drawing.Point(0, 181);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(986, 304);
            this.dgList.TabIndex = 16;
            this.dgList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgList_RowDoubleClick);
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.Controls.Add(this.lbltongThu);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 115);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(986, 66);
            this.uiGroupBox2.TabIndex = 15;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // lbltongThu
            // 
            this.lbltongThu.AutoSize = true;
            this.lbltongThu.ForeColor = System.Drawing.Color.Red;
            this.lbltongThu.Location = new System.Drawing.Point(116, 25);
            this.lbltongThu.Name = "lbltongThu";
            this.lbltongThu.Size = new System.Drawing.Size(18, 19);
            this.lbltongThu.TabIndex = 14;
            this.lbltongThu.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng thu :";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.cbbLoaiThu);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.dateDenNgay);
            this.uiGroupBox1.Controls.Add(this.dateTuNgay);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(986, 115);
            this.uiGroupBox1.TabIndex = 13;
            this.uiGroupBox1.Text = "Thông tin tìm kiếm";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // cbbLoaiThu
            // 
            this.cbbLoaiThu.Location = new System.Drawing.Point(176, 23);
            this.cbbLoaiThu.Margin = new System.Windows.Forms.Padding(6);
            this.cbbLoaiThu.Name = "cbbLoaiThu";
            this.cbbLoaiThu.Size = new System.Drawing.Size(420, 27);
            this.cbbLoaiThu.TabIndex = 10;
            this.cbbLoaiThu.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbLoaiThu.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loại thu :";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateDenNgay.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
            // 
            // 
            // 
            this.dateDenNgay.DropDownCalendar.Name = "";
            this.dateDenNgay.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateDenNgay.Location = new System.Drawing.Point(462, 68);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(134, 27);
            this.dateDenNgay.TabIndex = 3;
            this.dateDenNgay.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateDenNgay.ValueChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTuNgay.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
            // 
            // 
            // 
            this.dateTuNgay.DropDownCalendar.Name = "";
            this.dateTuNgay.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateTuNgay.Location = new System.Drawing.Point(176, 68);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(128, 27);
            this.dateTuNgay.TabIndex = 2;
            this.dateTuNgay.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateTuNgay.ValueChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đến ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ ngày :";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(617, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.AutoScroll = true;
            this.uiGroupBox3.Controls.Add(this.label1);
            this.uiGroupBox3.Controls.Add(this.btnExport);
            this.uiGroupBox3.Controls.Add(this.btnClose);
            this.uiGroupBox3.Controls.Add(this.btnSendEmailReport);
            this.uiGroupBox3.Controls.Add(this.btnDelete);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 485);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(986, 60);
            this.uiGroupBox3.TabIndex = 14;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(384, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hướng dẫn: Kích đôi để xem chi tiết";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(263, 18);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 31);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(860, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendEmailReport
            // 
            this.btnSendEmailReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSendEmailReport.Image")));
            this.btnSendEmailReport.Location = new System.Drawing.Point(8, 18);
            this.btnSendEmailReport.Name = "btnSendEmailReport";
            this.btnSendEmailReport.Size = new System.Drawing.Size(247, 31);
            this.btnSendEmailReport.TabIndex = 11;
            this.btnSendEmailReport.Text = "Gửi Email báo cáo";
            this.btnSendEmailReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSendEmailReport.Click += new System.EventHandler(this.btnSendEmailReport_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(740, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ReceiptsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReceiptsManagementForm";
            this.Text = "Theo dõi phiếu thu";
            this.Load += new System.EventHandler(this.ReceiptsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label lbltongThu;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIComboBox cbbLoaiThu;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.CalendarCombo.CalendarCombo dateDenNgay;
        private Janus.Windows.CalendarCombo.CalendarCombo dateTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIButton btnSendEmailReport;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIButton btnExport;
        private System.Windows.Forms.Label label1;
    }
}