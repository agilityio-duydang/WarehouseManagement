namespace WarehouseManagement
{
    partial class PurchaseManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseManagementForm));
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbbMaKho = new Janus.Windows.EditControls.UIComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNhaCungCap = new Janus.Windows.EditControls.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.dateTuNgay = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtTongGiamGia = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongChiPhiNhap = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongConNo = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtTongThanhToan = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtTongTien = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
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
            this.dgList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgList.GroupByBoxVisible = false;
            this.dgList.Location = new System.Drawing.Point(0, 115);
            this.dgList.Margin = new System.Windows.Forms.Padding(5);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(1352, 315);
            this.dgList.TabIndex = 18;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgList_RowDoubleClick);
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.cbbMaKho);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.cbbNhaCungCap);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.dateDenNgay);
            this.uiGroupBox1.Controls.Add(this.dateTuNgay);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1352, 115);
            this.uiGroupBox1.TabIndex = 16;
            this.uiGroupBox1.Text = "Thông tin tìm kiếm";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // cbbMaKho
            // 
            this.cbbMaKho.Location = new System.Drawing.Point(553, 29);
            this.cbbMaKho.Margin = new System.Windows.Forms.Padding(5);
            this.cbbMaKho.Name = "cbbMaKho";
            this.cbbMaKho.Size = new System.Drawing.Size(338, 27);
            this.cbbMaKho.TabIndex = 70;
            this.cbbMaKho.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbMaKho.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Kho : ";
            // 
            // cbbNhaCungCap
            // 
            this.cbbNhaCungCap.Location = new System.Drawing.Point(148, 29);
            this.cbbNhaCungCap.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNhaCungCap.Name = "cbbNhaCungCap";
            this.cbbNhaCungCap.Size = new System.Drawing.Size(338, 27);
            this.cbbNhaCungCap.TabIndex = 37;
            this.cbbNhaCungCap.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhà cung cấp : ";
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
            this.dateDenNgay.Location = new System.Drawing.Point(371, 70);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(115, 27);
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
            this.dateTuNgay.Location = new System.Drawing.Point(148, 70);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(111, 27);
            this.dateTuNgay.TabIndex = 2;
            this.dateTuNgay.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dateTuNgay.ValueChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đến ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ ngày :";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(553, 66);
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
            this.uiGroupBox3.Controls.Add(this.txtTongGiamGia);
            this.uiGroupBox3.Controls.Add(this.label9);
            this.uiGroupBox3.Controls.Add(this.txtTongChiPhiNhap);
            this.uiGroupBox3.Controls.Add(this.label8);
            this.uiGroupBox3.Controls.Add(this.txtTongConNo);
            this.uiGroupBox3.Controls.Add(this.txtTongThanhToan);
            this.uiGroupBox3.Controls.Add(this.txtTongTien);
            this.uiGroupBox3.Controls.Add(this.label3);
            this.uiGroupBox3.Controls.Add(this.label2);
            this.uiGroupBox3.Controls.Add(this.label7);
            this.uiGroupBox3.Controls.Add(this.btnClose);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 430);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(1352, 172);
            this.uiGroupBox3.TabIndex = 17;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtTongGiamGia
            // 
            this.txtTongGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTongGiamGia.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTongGiamGia.Location = new System.Drawing.Point(179, 46);
            this.txtTongGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongGiamGia.Name = "txtTongGiamGia";
            this.txtTongGiamGia.ReadOnly = true;
            this.txtTongGiamGia.Size = new System.Drawing.Size(216, 27);
            this.txtTongGiamGia.TabIndex = 80;
            this.txtTongGiamGia.Text = "0 ₫";
            this.txtTongGiamGia.Value = ((long)(0));
            this.txtTongGiamGia.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTongGiamGia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 79;
            this.label9.Text = "Tổng giảm giá : ";
            // 
            // txtTongChiPhiNhap
            // 
            this.txtTongChiPhiNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTongChiPhiNhap.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTongChiPhiNhap.Location = new System.Drawing.Point(179, 76);
            this.txtTongChiPhiNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChiPhiNhap.Name = "txtTongChiPhiNhap";
            this.txtTongChiPhiNhap.ReadOnly = true;
            this.txtTongChiPhiNhap.Size = new System.Drawing.Size(216, 27);
            this.txtTongChiPhiNhap.TabIndex = 78;
            this.txtTongChiPhiNhap.Text = "0 ₫";
            this.txtTongChiPhiNhap.Value = ((long)(0));
            this.txtTongChiPhiNhap.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTongChiPhiNhap.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Tổng chi phí nhập : ";
            // 
            // txtTongConNo
            // 
            this.txtTongConNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtTongConNo.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTongConNo.Location = new System.Drawing.Point(179, 138);
            this.txtTongConNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongConNo.Name = "txtTongConNo";
            this.txtTongConNo.ReadOnly = true;
            this.txtTongConNo.Size = new System.Drawing.Size(216, 27);
            this.txtTongConNo.TabIndex = 72;
            this.txtTongConNo.Text = "0 ₫";
            this.txtTongConNo.Value = ((long)(0));
            this.txtTongConNo.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTongConNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTongThanhToan.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTongThanhToan.Location = new System.Drawing.Point(179, 107);
            this.txtTongThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.ReadOnly = true;
            this.txtTongThanhToan.Size = new System.Drawing.Size(216, 27);
            this.txtTongThanhToan.TabIndex = 71;
            this.txtTongThanhToan.Text = "0 ₫";
            this.txtTongThanhToan.Value = ((long)(0));
            this.txtTongThanhToan.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTongThanhToan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTongTien
            // 
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.txtTongTien.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTongTien.Location = new System.Drawing.Point(179, 15);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(216, 27);
            this.txtTongTien.TabIndex = 70;
            this.txtTongTien.Text = "0 ₫";
            this.txtTongTien.Value = ((long)(0));
            this.txtTongTien.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTongTien.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Tổng đã thanh toán : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tổng tiền :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tổng còn nợ : ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1226, 124);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PurchaseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1352, 602);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PurchaseManagementForm";
            this.Text = "Quản lý phiếu nhập kho";
            this.Load += new System.EventHandler(this.PurchaseManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIComboBox cbbNhaCungCap;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.CalendarCombo.CalendarCombo dateDenNgay;
        private Janus.Windows.CalendarCombo.CalendarCombo dateTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTongConNo;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTongThanhToan;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTongGiamGia;
        private System.Windows.Forms.Label label9;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTongChiPhiNhap;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.EditControls.UIComboBox cbbMaKho;
        private System.Windows.Forms.Label label6;
    }
}