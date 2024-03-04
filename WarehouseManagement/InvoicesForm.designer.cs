namespace WarehouseManagement
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblTongTien = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.lblTriGiaGiam = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.lblGiamGia = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.lblToTalTax = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.lblTax = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox7 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThoiGianTao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.btnPrint = new Janus.Windows.EditControls.UIButton();
            this.btnExport = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox7)).BeginInit();
            this.uiGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.AutoScroll = true;
            this.uiGroupBox5.Controls.Add(this.lblTongTien);
            this.uiGroupBox5.Controls.Add(this.lblTriGiaGiam);
            this.uiGroupBox5.Controls.Add(this.lblGiamGia);
            this.uiGroupBox5.Controls.Add(this.lblToTalTax);
            this.uiGroupBox5.Controls.Add(this.lblTax);
            this.uiGroupBox5.Controls.Add(this.label2);
            this.uiGroupBox5.Controls.Add(this.label6);
            this.uiGroupBox5.Controls.Add(this.label4);
            this.uiGroupBox5.Controls.Add(this.label8);
            this.uiGroupBox5.Controls.Add(this.lblDiaChi);
            this.uiGroupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox5.Location = new System.Drawing.Point(3, 8);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(775, 172);
            this.uiGroupBox5.TabIndex = 28;
            this.uiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblTongTien.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.lblTongTien.Location = new System.Drawing.Point(624, 135);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.ReadOnly = true;
            this.lblTongTien.Size = new System.Drawing.Size(141, 27);
            this.lblTongTien.TabIndex = 54;
            this.lblTongTien.Text = "0 ₫";
            this.lblTongTien.Value = ((long)(0));
            this.lblTongTien.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.lblTongTien.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTriGiaGiam
            // 
            this.lblTriGiaGiam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTriGiaGiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTriGiaGiam.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.lblTriGiaGiam.Location = new System.Drawing.Point(624, 105);
            this.lblTriGiaGiam.Margin = new System.Windows.Forms.Padding(2);
            this.lblTriGiaGiam.Name = "lblTriGiaGiam";
            this.lblTriGiaGiam.ReadOnly = true;
            this.lblTriGiaGiam.Size = new System.Drawing.Size(141, 27);
            this.lblTriGiaGiam.TabIndex = 53;
            this.lblTriGiaGiam.Text = "0 ₫";
            this.lblTriGiaGiam.Value = ((long)(0));
            this.lblTriGiaGiam.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.lblTriGiaGiam.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblGiamGia.Location = new System.Drawing.Point(704, 75);
            this.lblGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.ReadOnly = true;
            this.lblGiamGia.Size = new System.Drawing.Size(61, 27);
            this.lblGiamGia.TabIndex = 52;
            this.lblGiamGia.Text = "0";
            this.lblGiamGia.Value = 0;
            this.lblGiamGia.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.lblGiamGia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblToTalTax
            // 
            this.lblToTalTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToTalTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lblToTalTax.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.lblToTalTax.Location = new System.Drawing.Point(624, 15);
            this.lblToTalTax.Margin = new System.Windows.Forms.Padding(2);
            this.lblToTalTax.Name = "lblToTalTax";
            this.lblToTalTax.ReadOnly = true;
            this.lblToTalTax.Size = new System.Drawing.Size(141, 27);
            this.lblToTalTax.TabIndex = 51;
            this.lblToTalTax.Text = "0 ₫";
            this.lblToTalTax.Value = ((long)(0));
            this.lblToTalTax.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.lblToTalTax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTax.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.lblTax.Location = new System.Drawing.Point(624, 45);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2);
            this.lblTax.Name = "lblTax";
            this.lblTax.ReadOnly = true;
            this.lblTax.Size = new System.Drawing.Size(141, 27);
            this.lblTax.TabIndex = 50;
            this.lblTax.Text = "0 ₫";
            this.lblTax.Value = ((long)(0));
            this.lblTax.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.lblTax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Giảm giá (%) : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Trị giá giảm :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tổng tiền hàng :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tiền thuế : ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(486, 138);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(134, 20);
            this.lblDiaChi.TabIndex = 29;
            this.lblDiaChi.Text = "Tổng thanh toán :";
            // 
            // dgList
            // 
            this.dgList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GroupByBoxVisible = false;
            this.dgList.Location = new System.Drawing.Point(0, 102);
            this.dgList.Margin = new System.Windows.Forms.Padding(5);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.dgList.Size = new System.Drawing.Size(781, 276);
            this.dgList.TabIndex = 15;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            // 
            // uiGroupBox7
            // 
            this.uiGroupBox7.AutoScroll = true;
            this.uiGroupBox7.Controls.Add(this.lblTenKhachHang);
            this.uiGroupBox7.Controls.Add(this.label5);
            this.uiGroupBox7.Controls.Add(this.lblThoiGianTao);
            this.uiGroupBox7.Controls.Add(this.label3);
            this.uiGroupBox7.Controls.Add(this.lblTenNhanVien);
            this.uiGroupBox7.Controls.Add(this.label1);
            this.uiGroupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox7.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox7.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox7.Name = "uiGroupBox7";
            this.uiGroupBox7.Size = new System.Drawing.Size(781, 102);
            this.uiGroupBox7.TabIndex = 14;
            this.uiGroupBox7.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(150, 73);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(0, 19);
            this.lblTenKhachHang.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tên khách hàng : ";
            // 
            // lblThoiGianTao
            // 
            this.lblThoiGianTao.AutoSize = true;
            this.lblThoiGianTao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianTao.Location = new System.Drawing.Point(146, 43);
            this.lblThoiGianTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiGianTao.Name = "lblThoiGianTao";
            this.lblThoiGianTao.Size = new System.Drawing.Size(0, 19);
            this.lblThoiGianTao.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Thời gian : ";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(146, 16);
            this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(0, 19);
            this.lblTenNhanVien.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên nhân viên : ";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.btnExport);
            this.uiGroupBox3.Controls.Add(this.btnClose);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox5);
            this.uiGroupBox3.Controls.Add(this.btnPrint);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 378);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(781, 231);
            this.uiGroupBox3.TabIndex = 13;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(655, 187);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(438, 187);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(208, 32);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In hoá đơn";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(15, 188);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 31);
            this.btnExport.TabIndex = 30;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(781, 609);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.uiGroupBox7);
            this.Controls.Add(this.uiGroupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin hoá đơn";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox7)).EndInit();
            this.uiGroupBox7.ResumeLayout(false);
            this.uiGroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private System.Windows.Forms.Label lblDiaChi;
        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox7;
        private System.Windows.Forms.Label lblThoiGianTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIButton btnPrint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.EditControls.UIButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.GridEX.EditControls.NumericEditBox lblTongTien;
        private Janus.Windows.GridEX.EditControls.NumericEditBox lblTriGiaGiam;
        private Janus.Windows.GridEX.EditControls.NumericEditBox lblGiamGia;
        private Janus.Windows.GridEX.EditControls.NumericEditBox lblToTalTax;
        private Janus.Windows.GridEX.EditControls.NumericEditBox lblTax;
        private Janus.Windows.EditControls.UIButton btnExport;
    }
}