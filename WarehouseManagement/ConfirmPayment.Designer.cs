namespace WarehouseManagement
{
    partial class ConfirmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPayment));
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnPrint = new Janus.Windows.EditControls.UIButton();
            this.btnCash = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtPercent = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.cbbKhachHang = new Janus.Windows.EditControls.UIComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.lblDeptOrReturn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbGiamGia = new Janus.Windows.EditControls.UIComboBox();
            this.txtKhachThanhToan = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtKhachCanTra = new System.Windows.Forms.Label();
            this.txtTriGia = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienThue = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.btnPrint);
            this.uiGroupBox3.Controls.Add(this.btnCash);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 574);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(1020, 55);
            this.uiGroupBox3.TabIndex = 2;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(655, 13);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 32);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In tạm tính";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCash
            // 
            this.btnCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCash.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCash.Location = new System.Drawing.Point(834, 14);
            this.btnCash.Margin = new System.Windows.Forms.Padding(5);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(170, 32);
            this.btnCash.TabIndex = 6;
            this.btnCash.Text = "Thanh toán";
            this.btnCash.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.AutoScroll = true;
            this.uiGroupBox5.Controls.Add(this.txtPercent);
            this.uiGroupBox5.Controls.Add(this.cbbKhachHang);
            this.uiGroupBox5.Controls.Add(this.label7);
            this.uiGroupBox5.Controls.Add(this.lblTienThua);
            this.uiGroupBox5.Controls.Add(this.lblDeptOrReturn);
            this.uiGroupBox5.Controls.Add(this.label5);
            this.uiGroupBox5.Controls.Add(this.cbbGiamGia);
            this.uiGroupBox5.Controls.Add(this.txtKhachThanhToan);
            this.uiGroupBox5.Controls.Add(this.txtKhachCanTra);
            this.uiGroupBox5.Controls.Add(this.txtTriGia);
            this.uiGroupBox5.Controls.Add(this.label3);
            this.uiGroupBox5.Controls.Add(this.label2);
            this.uiGroupBox5.Controls.Add(this.label1);
            this.uiGroupBox5.Controls.Add(this.txtTienThue);
            this.uiGroupBox5.Controls.Add(this.label8);
            this.uiGroupBox5.Controls.Add(this.lblTongTien);
            this.uiGroupBox5.Controls.Add(this.lblDiaChi);
            this.uiGroupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiGroupBox5.Location = new System.Drawing.Point(655, 0);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(365, 574);
            this.uiGroupBox5.TabIndex = 36;
            this.uiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(288, 105);
            this.txtPercent.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(61, 27);
            this.txtPercent.TabIndex = 49;
            this.txtPercent.Text = "0";
            this.txtPercent.Value = 0;
            this.txtPercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.txtPercent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtPercent.TextChanged += new System.EventHandler(this.txtPercent_TextChanged);
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.Enabled = false;
            this.cbbKhachHang.Location = new System.Drawing.Point(149, 29);
            this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(202, 27);
            this.cbbKhachHang.TabIndex = 48;
            this.cbbKhachHang.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Khách hàng : ";
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblTienThua.Location = new System.Drawing.Point(284, 289);
            this.lblTienThua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(29, 19);
            this.lblTienThua.TabIndex = 46;
            this.lblTienThua.Text = "{}";
            // 
            // lblDeptOrReturn
            // 
            this.lblDeptOrReturn.AutoSize = true;
            this.lblDeptOrReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptOrReturn.Location = new System.Drawing.Point(19, 289);
            this.lblDeptOrReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeptOrReturn.Name = "lblDeptOrReturn";
            this.lblDeptOrReturn.Size = new System.Drawing.Size(161, 20);
            this.lblDeptOrReturn.TabIndex = 45;
            this.lblDeptOrReturn.Text = "Tiền thừa trả khách  : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Trị giá giảm : ";
            // 
            // cbbGiamGia
            // 
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "Phần trăm";
            uiComboBoxItem5.Value = "0";
            uiComboBoxItem6.FormatStyle.Alpha = 0;
            uiComboBoxItem6.IsSeparator = false;
            uiComboBoxItem6.Text = "Số tiền";
            uiComboBoxItem6.Value = "1";
            this.cbbGiamGia.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem5,
            uiComboBoxItem6});
            this.cbbGiamGia.Location = new System.Drawing.Point(149, 105);
            this.cbbGiamGia.Margin = new System.Windows.Forms.Padding(5);
            this.cbbGiamGia.Name = "cbbGiamGia";
            this.cbbGiamGia.Size = new System.Drawing.Size(132, 27);
            this.cbbGiamGia.TabIndex = 43;
            this.cbbGiamGia.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbGiamGia.SelectedIndexChanged += new System.EventHandler(this.cbbGiamGia_SelectedIndexChanged);
            // 
            // txtKhachThanhToan
            // 
            this.txtKhachThanhToan.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtKhachThanhToan.Location = new System.Drawing.Point(179, 248);
            this.txtKhachThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachThanhToan.Name = "txtKhachThanhToan";
            this.txtKhachThanhToan.Size = new System.Drawing.Size(172, 27);
            this.txtKhachThanhToan.TabIndex = 42;
            this.txtKhachThanhToan.Text = "0 ₫";
            this.txtKhachThanhToan.Value = 0;
            this.txtKhachThanhToan.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.txtKhachThanhToan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtKhachThanhToan.TextChanged += new System.EventHandler(this.txtKhachThanhToan_TextChanged);
            // 
            // txtKhachCanTra
            // 
            this.txtKhachCanTra.AutoSize = true;
            this.txtKhachCanTra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachCanTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtKhachCanTra.Location = new System.Drawing.Point(284, 216);
            this.txtKhachCanTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtKhachCanTra.Name = "txtKhachCanTra";
            this.txtKhachCanTra.Size = new System.Drawing.Size(29, 19);
            this.txtKhachCanTra.TabIndex = 41;
            this.txtKhachCanTra.Text = "{}";
            // 
            // txtTriGia
            // 
            this.txtTriGia.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTriGia.Location = new System.Drawing.Point(149, 140);
            this.txtTriGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(202, 27);
            this.txtTriGia.TabIndex = 40;
            this.txtTriGia.Text = "0 ₫";
            this.txtTriGia.Value = ((long)(0));
            this.txtTriGia.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTriGia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtTriGia.TextChanged += new System.EventHandler(this.txtTriGia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Khách thanh toán  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Khách cần trả : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Loại giảm giá :";
            // 
            // txtTienThue
            // 
            this.txtTienThue.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTienThue.Location = new System.Drawing.Point(149, 177);
            this.txtTienThue.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.ReadOnly = true;
            this.txtTienThue.Size = new System.Drawing.Size(202, 27);
            this.txtTienThue.TabIndex = 36;
            this.txtTienThue.Text = "0 ₫";
            this.txtTienThue.Value = ((long)(0));
            this.txtTienThue.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTienThue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtTienThue.TextChanged += new System.EventHandler(this.txtTienThue_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tiền thuế : ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lblTongTien.Location = new System.Drawing.Point(284, 69);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(29, 19);
            this.lblTongTien.TabIndex = 34;
            this.lblTongTien.Text = "{}";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(19, 69);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(123, 20);
            this.lblDiaChi.TabIndex = 33;
            this.lblDiaChi.Text = "Tổng tiền hàng :";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.dgList);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(655, 574);
            this.uiGroupBox1.TabIndex = 37;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.dgList.Location = new System.Drawing.Point(3, 8);
            this.dgList.Margin = new System.Windows.Forms.Padding(5);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.dgList.Size = new System.Drawing.Size(649, 563);
            this.dgList.TabIndex = 13;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            // 
            // ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1020, 629);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox5);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfirmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác nhận thanh toán";
            this.Load += new System.EventHandler(this.ConfirmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIButton btnPrint;
        private Janus.Windows.EditControls.UIButton btnCash;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTienThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDiaChi;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.GridEX.GridEX dgList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtKhachThanhToan;
        private System.Windows.Forms.Label txtKhachCanTra;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTriGia;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.EditControls.UIComboBox cbbGiamGia;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.Label lblDeptOrReturn;
        private Janus.Windows.EditControls.UIComboBox cbbKhachHang;
        private System.Windows.Forms.Label label7;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtPercent;
    }
}