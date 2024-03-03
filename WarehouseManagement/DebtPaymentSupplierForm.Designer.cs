namespace WarehouseManagement
{
    partial class DebtPaymentSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtPaymentSupplierForm));
            Janus.Windows.GridEX.GridEXLayout dgListDebt_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbbLoaiChi = new Janus.Windows.EditControls.UIComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoHienTai = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTraNCC = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiGian = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.txtGhiChu = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtNoSau = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label54 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.btnCancel = new Janus.Windows.EditControls.UIButton();
            this.dgListDebt = new Janus.Windows.GridEX.GridEX();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.Controls.Add(this.cbbLoaiChi);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.txtNoHienTai);
            this.uiGroupBox2.Controls.Add(this.label2);
            this.uiGroupBox2.Controls.Add(this.txtTraNCC);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.txtThoiGian);
            this.uiGroupBox2.Controls.Add(this.txtGhiChu);
            this.uiGroupBox2.Controls.Add(this.txtNoSau);
            this.uiGroupBox2.Controls.Add(this.label54);
            this.uiGroupBox2.Controls.Add(this.lblDiaChi);
            this.uiGroupBox2.Controls.Add(this.label59);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(857, 354);
            this.uiGroupBox2.TabIndex = 18;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // cbbLoaiChi
            // 
            this.cbbLoaiChi.Location = new System.Drawing.Point(165, 55);
            this.cbbLoaiChi.Margin = new System.Windows.Forms.Padding(6);
            this.cbbLoaiChi.Name = "cbbLoaiChi";
            this.cbbLoaiChi.Size = new System.Drawing.Size(198, 27);
            this.cbbLoaiChi.TabIndex = 23;
            this.cbbLoaiChi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại chi :";
            // 
            // txtNoHienTai
            // 
            this.txtNoHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoHienTai.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtNoHienTai.Location = new System.Drawing.Point(165, 91);
            this.txtNoHienTai.Margin = new System.Windows.Forms.Padding(6);
            this.txtNoHienTai.Name = "txtNoHienTai";
            this.txtNoHienTai.ReadOnly = true;
            this.txtNoHienTai.Size = new System.Drawing.Size(675, 27);
            this.txtNoHienTai.TabIndex = 20;
            this.txtNoHienTai.Text = "0 ₫";
            this.txtNoHienTai.Value = ((long)(0));
            this.txtNoHienTai.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtNoHienTai.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nợ hiện tại : ";
            // 
            // txtTraNCC
            // 
            this.txtTraNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraNCC.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtTraNCC.Location = new System.Drawing.Point(165, 130);
            this.txtTraNCC.Margin = new System.Windows.Forms.Padding(6);
            this.txtTraNCC.Name = "txtTraNCC";
            this.txtTraNCC.Size = new System.Drawing.Size(675, 27);
            this.txtTraNCC.TabIndex = 18;
            this.txtTraNCC.Text = "0 ₫";
            this.txtTraNCC.Value = ((long)(0));
            this.txtTraNCC.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtTraNCC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtTraNCC.TextChanged += new System.EventHandler(this.txtThuTuKhach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Trả cho NCC : ";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.txtThoiGian.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
            // 
            // 
            // 
            this.txtThoiGian.DropDownCalendar.Name = "";
            this.txtThoiGian.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.txtThoiGian.Location = new System.Drawing.Point(165, 19);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(198, 27);
            this.txtThoiGian.TabIndex = 1;
            this.txtThoiGian.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(165, 207);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(675, 137);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNoSau
            // 
            this.txtNoSau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoSau.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtNoSau.Location = new System.Drawing.Point(165, 169);
            this.txtNoSau.Margin = new System.Windows.Forms.Padding(6);
            this.txtNoSau.Name = "txtNoSau";
            this.txtNoSau.ReadOnly = true;
            this.txtNoSau.Size = new System.Drawing.Size(675, 27);
            this.txtNoSau.TabIndex = 5;
            this.txtNoSau.Text = "0 ₫";
            this.txtNoSau.Value = ((long)(0));
            this.txtNoSau.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtNoSau.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(34, 172);
            this.label54.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(71, 20);
            this.label54.TabIndex = 11;
            this.label54.Text = "Nợ sau : ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(34, 22);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(81, 20);
            this.lblDiaChi.TabIndex = 17;
            this.lblDiaChi.Text = "Thời gian :";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(34, 210);
            this.label59.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(72, 20);
            this.label59.TabIndex = 15;
            this.label59.Text = "Ghi chú :";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.label8);
            this.uiGroupBox1.Controls.Add(this.btnSave);
            this.uiGroupBox1.Controls.Add(this.btnCancel);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 542);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(857, 50);
            this.uiGroupBox1.TabIndex = 17;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(575, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Tạo phiếu chi";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(729, 13);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgListDebt
            // 
            this.dgListDebt.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgListDebt.ColumnAutoResize = true;
            dgListDebt_DesignTimeLayout.LayoutString = resources.GetString("dgListDebt_DesignTimeLayout.LayoutString");
            this.dgListDebt.DesignTimeLayout = dgListDebt_DesignTimeLayout;
            this.dgListDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListDebt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListDebt.GroupByBoxVisible = false;
            this.dgListDebt.Location = new System.Drawing.Point(0, 354);
            this.dgListDebt.Margin = new System.Windows.Forms.Padding(5);
            this.dgListDebt.Name = "dgListDebt";
            this.dgListDebt.RecordNavigator = true;
            this.dgListDebt.Size = new System.Drawing.Size(857, 188);
            this.dgListDebt.TabIndex = 22;
            this.dgListDebt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgListDebt.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgListDebt_RowDoubleClick);
            this.dgListDebt.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgListDebt_LoadingRow);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 19);
            this.label8.TabIndex = 74;
            this.label8.Text = "Hướng dẫn: Kích đôi để xem chi tiết";
            // 
            // DebtPaymentSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(857, 592);
            this.Controls.Add(this.dgListDebt);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DebtPaymentSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.DebtPaymentSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.EditControls.UIComboBox cbbLoaiChi;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtNoHienTai;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtTraNCC;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.CalendarCombo.CalendarCombo txtThoiGian;
        private Janus.Windows.GridEX.EditControls.EditBox txtGhiChu;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtNoSau;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label59;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIButton btnSave;
        private Janus.Windows.EditControls.UIButton btnCancel;
        private Janus.Windows.GridEX.GridEX dgListDebt;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label8;
    }
}