namespace WarehouseManagement
{
    partial class CashFlowManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashFlowManagementForm));
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbbNhanVien = new Janus.Windows.EditControls.UIComboBox();
            this.cbbKhachHang = new Janus.Windows.EditControls.UIComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDenNgay = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.dateTuNgay = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExport = new Janus.Windows.EditControls.UIButton();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnSendEmailReport = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblTonQuy = new System.Windows.Forms.Label();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblQuyDauKy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.cbbNhanVien);
            this.uiGroupBox1.Controls.Add(this.cbbKhachHang);
            this.uiGroupBox1.Controls.Add(this.label8);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.dateDenNgay);
            this.uiGroupBox1.Controls.Add(this.dateTuNgay);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1194, 133);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "Thông tin tìm kiếm";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.Location = new System.Drawing.Point(138, 21);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(338, 27);
            this.cbbNhanVien.TabIndex = 39;
            this.cbbNhanVien.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.Location = new System.Drawing.Point(138, 58);
            this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(338, 27);
            this.cbbKhachHang.TabIndex = 38;
            this.cbbKhachHang.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbKhachHang.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Khách hàng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nhân viên :";
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
            this.dateDenNgay.Location = new System.Drawing.Point(351, 92);
            this.dateDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(125, 27);
            this.dateDenNgay.TabIndex = 3;
            this.dateDenNgay.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateDenNgay.TextChanged += new System.EventHandler(this.btnSearch_Click);
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
            this.dateTuNgay.Location = new System.Drawing.Point(138, 92);
            this.dateTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(118, 27);
            this.dateTuNgay.TabIndex = 2;
            this.dateTuNgay.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateTuNgay.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đến ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ ngày :";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(482, 92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.label9);
            this.uiGroupBox3.Controls.Add(this.btnExport);
            this.uiGroupBox3.Controls.Add(this.btnClose);
            this.uiGroupBox3.Controls.Add(this.btnSendEmailReport);
            this.uiGroupBox3.Controls.Add(this.btnDelete);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 597);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(1194, 48);
            this.uiGroupBox3.TabIndex = 5;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(340, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Hướng dẫn: Kích đôi để xem chi tiết";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(219, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 31);
            this.btnExport.TabIndex = 31;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1068, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendEmailReport
            // 
            this.btnSendEmailReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSendEmailReport.Image")));
            this.btnSendEmailReport.Location = new System.Drawing.Point(10, 12);
            this.btnSendEmailReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendEmailReport.Name = "btnSendEmailReport";
            this.btnSendEmailReport.Size = new System.Drawing.Size(202, 31);
            this.btnSendEmailReport.TabIndex = 10;
            this.btnSendEmailReport.Text = "Gửi Email báo cáo";
            this.btnSendEmailReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSendEmailReport.Click += new System.EventHandler(this.btnSendEmailReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(949, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.Controls.Add(this.lblTonQuy);
            this.uiGroupBox2.Controls.Add(this.lblTongChi);
            this.uiGroupBox2.Controls.Add(this.lblTongThu);
            this.uiGroupBox2.Controls.Add(this.lblQuyDauKy);
            this.uiGroupBox2.Controls.Add(this.label7);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.label6);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 133);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(1194, 151);
            this.uiGroupBox2.TabIndex = 7;
            this.uiGroupBox2.Text = "Thông tin tồn quỹ";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // lblTonQuy
            // 
            this.lblTonQuy.AutoSize = true;
            this.lblTonQuy.ForeColor = System.Drawing.Color.Green;
            this.lblTonQuy.Location = new System.Drawing.Point(131, 117);
            this.lblTonQuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTonQuy.Name = "lblTonQuy";
            this.lblTonQuy.Size = new System.Drawing.Size(18, 19);
            this.lblTonQuy.TabIndex = 15;
            this.lblTonQuy.Text = "0";
            // 
            // lblTongChi
            // 
            this.lblTongChi.AutoSize = true;
            this.lblTongChi.ForeColor = System.Drawing.Color.Red;
            this.lblTongChi.Location = new System.Drawing.Point(131, 86);
            this.lblTongChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(18, 19);
            this.lblTongChi.TabIndex = 14;
            this.lblTongChi.Text = "0";
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.ForeColor = System.Drawing.Color.Blue;
            this.lblTongThu.Location = new System.Drawing.Point(131, 56);
            this.lblTongThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(18, 19);
            this.lblTongThu.TabIndex = 13;
            this.lblTongThu.Text = "0";
            // 
            // lblQuyDauKy
            // 
            this.lblQuyDauKy.AutoSize = true;
            this.lblQuyDauKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblQuyDauKy.Location = new System.Drawing.Point(131, 27);
            this.lblQuyDauKy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuyDauKy.Name = "lblQuyDauKy";
            this.lblQuyDauKy.Size = new System.Drawing.Size(18, 19);
            this.lblQuyDauKy.TabIndex = 12;
            this.lblQuyDauKy.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tồn quỹ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng chi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quỹ đầu kỳ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng thu :";
            // 
            // dgList
            // 
            this.dgList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GroupByBoxVisible = false;
            this.dgList.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.dgList.Location = new System.Drawing.Point(0, 284);
            this.dgList.Margin = new System.Windows.Forms.Padding(2);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(1194, 313);
            this.dgList.TabIndex = 8;
            this.dgList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgList_RowDoubleClick);
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            // 
            // CashFlowManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1194, 645);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CashFlowManagementForm";
            this.Text = "Sổ quỹ";
            this.Load += new System.EventHandler(this.CashFlowManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.CalendarCombo.CalendarCombo dateTuNgay;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.CalendarCombo.CalendarCombo dateDenNgay;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label lblQuyDauKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.GridEX.GridEX dgList;
        private System.Windows.Forms.Label lblTonQuy;
        private System.Windows.Forms.Label lblTongChi;
        private System.Windows.Forms.Label lblTongThu;
        private Janus.Windows.EditControls.UIButton btnSendEmailReport;
        private Janus.Windows.EditControls.UIComboBox cbbKhachHang;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.EditControls.UIComboBox cbbNhanVien;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIButton btnExport;
        private System.Windows.Forms.Label label9;
    }
}