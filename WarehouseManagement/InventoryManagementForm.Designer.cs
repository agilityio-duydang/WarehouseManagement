namespace WarehouseManagement
{
    partial class InventoryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementForm));
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtThanhTienTon = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtThanhTienBan = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtThanhTienNhap = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuongTon = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtLuongBan = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtLuongNhap = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbbCategory = new Janus.Windows.EditControls.UIComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.txtTenHangHoa = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtMaHangHoa = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.dgList);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 121);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(1348, 338);
            this.uiGroupBox2.TabIndex = 9;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dgList
            // 
            this.dgList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GroupByBoxVisible = false;
            this.dgList.Location = new System.Drawing.Point(3, 8);
            this.dgList.Margin = new System.Windows.Forms.Padding(6);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(1342, 327);
            this.dgList.TabIndex = 7;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.AutoScroll = true;
            this.uiGroupBox3.Controls.Add(this.txtThanhTienTon);
            this.uiGroupBox3.Controls.Add(this.txtThanhTienBan);
            this.uiGroupBox3.Controls.Add(this.txtThanhTienNhap);
            this.uiGroupBox3.Controls.Add(this.label3);
            this.uiGroupBox3.Controls.Add(this.label5);
            this.uiGroupBox3.Controls.Add(this.label7);
            this.uiGroupBox3.Controls.Add(this.txtLuongTon);
            this.uiGroupBox3.Controls.Add(this.txtLuongBan);
            this.uiGroupBox3.Controls.Add(this.txtLuongNhap);
            this.uiGroupBox3.Controls.Add(this.label6);
            this.uiGroupBox3.Controls.Add(this.label4);
            this.uiGroupBox3.Controls.Add(this.lblDiaChi);
            this.uiGroupBox3.Controls.Add(this.btnClose);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 459);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(1348, 144);
            this.uiGroupBox3.TabIndex = 8;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtThanhTienTon
            // 
            this.txtThanhTienTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtThanhTienTon.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtThanhTienTon.Location = new System.Drawing.Point(475, 90);
            this.txtThanhTienTon.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTienTon.Name = "txtThanhTienTon";
            this.txtThanhTienTon.ReadOnly = true;
            this.txtThanhTienTon.Size = new System.Drawing.Size(216, 27);
            this.txtThanhTienTon.TabIndex = 66;
            this.txtThanhTienTon.Text = "0 ₫";
            this.txtThanhTienTon.Value = ((long)(0));
            this.txtThanhTienTon.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtThanhTienTon.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtThanhTienBan
            // 
            this.txtThanhTienBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtThanhTienBan.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtThanhTienBan.Location = new System.Drawing.Point(475, 59);
            this.txtThanhTienBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTienBan.Name = "txtThanhTienBan";
            this.txtThanhTienBan.ReadOnly = true;
            this.txtThanhTienBan.Size = new System.Drawing.Size(216, 27);
            this.txtThanhTienBan.TabIndex = 65;
            this.txtThanhTienBan.Text = "0 ₫";
            this.txtThanhTienBan.Value = ((long)(0));
            this.txtThanhTienBan.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtThanhTienBan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtThanhTienNhap
            // 
            this.txtThanhTienNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.txtThanhTienNhap.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtThanhTienNhap.Location = new System.Drawing.Point(475, 28);
            this.txtThanhTienNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTienNhap.Name = "txtThanhTienNhap";
            this.txtThanhTienNhap.ReadOnly = true;
            this.txtThanhTienNhap.Size = new System.Drawing.Size(216, 27);
            this.txtThanhTienNhap.TabIndex = 64;
            this.txtThanhTienNhap.Text = "0 ₫";
            this.txtThanhTienNhap.Value = ((long)(0));
            this.txtThanhTienNhap.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtThanhTienNhap.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Thành tiền bán : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Thành tiền nhập : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Thành tiền tồn : ";
            // 
            // txtLuongTon
            // 
            this.txtLuongTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtLuongTon.Location = new System.Drawing.Point(151, 90);
            this.txtLuongTon.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuongTon.Name = "txtLuongTon";
            this.txtLuongTon.ReadOnly = true;
            this.txtLuongTon.Size = new System.Drawing.Size(141, 27);
            this.txtLuongTon.TabIndex = 60;
            this.txtLuongTon.Text = "0,00";
            this.txtLuongTon.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtLuongTon.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtLuongBan
            // 
            this.txtLuongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtLuongBan.Location = new System.Drawing.Point(151, 59);
            this.txtLuongBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuongBan.Name = "txtLuongBan";
            this.txtLuongBan.ReadOnly = true;
            this.txtLuongBan.Size = new System.Drawing.Size(141, 27);
            this.txtLuongBan.TabIndex = 59;
            this.txtLuongBan.Text = "0,00";
            this.txtLuongBan.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtLuongBan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtLuongNhap
            // 
            this.txtLuongNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.txtLuongNhap.Location = new System.Drawing.Point(151, 28);
            this.txtLuongNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuongNhap.Name = "txtLuongNhap";
            this.txtLuongNhap.ReadOnly = true;
            this.txtLuongNhap.Size = new System.Drawing.Size(141, 27);
            this.txtLuongNhap.TabIndex = 58;
            this.txtLuongNhap.Text = "0,00";
            this.txtLuongNhap.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtLuongNhap.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Lượng bán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Lượng nhập :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(42, 93);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(89, 20);
            this.lblDiaChi.TabIndex = 55;
            this.lblDiaChi.Text = "Lượng tồn :";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1222, 100);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.cbbCategory);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Controls.Add(this.txtTenHangHoa);
            this.uiGroupBox1.Controls.Add(this.txtMaHangHoa);
            this.uiGroupBox1.Controls.Add(this.label35);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1348, 121);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "Tìm kiếm hàng hoá";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // cbbCategory
            // 
            this.cbbCategory.Location = new System.Drawing.Point(657, 29);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(6);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(242, 27);
            this.cbbCategory.TabIndex = 4;
            this.cbbCategory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhóm hàng hoá :";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(911, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(152, 75);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(347, 27);
            this.txtTenHangHoa.TabIndex = 2;
            this.txtTenHangHoa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtTenHangHoa.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(151, 29);
            this.txtMaHangHoa.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(348, 27);
            this.txtMaHangHoa.TabIndex = 1;
            this.txtMaHangHoa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtMaHangHoa.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(22, 79);
            this.label35.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(118, 19);
            this.label35.TabIndex = 0;
            this.label35.Text = "Tên hàng hoá :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hoá :";
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1348, 603);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoryManagementForm";
            this.Text = "Theo dõi";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIButton btnClose;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIComboBox cbbCategory;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.GridEX.EditControls.EditBox txtTenHangHoa;
        private Janus.Windows.GridEX.EditControls.EditBox txtMaHangHoa;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtLuongTon;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtLuongBan;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtLuongNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiaChi;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtThanhTienTon;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtThanhTienBan;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtThanhTienNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}