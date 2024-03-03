namespace WarehouseManagement
{
    partial class ReceiptsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptsForm));
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtMaPhieu = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiGian = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.txtNguoiThu = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtGhiChu = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtGiaTri = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.cbbLoaiThu = new Janus.Windows.EditControls.UIComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.btnCancel = new Janus.Windows.EditControls.UIButton();
            this.btnSaveAndNew = new Janus.Windows.EditControls.UIButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.Controls.Add(this.txtMaPhieu);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.txtThoiGian);
            this.uiGroupBox2.Controls.Add(this.txtNguoiThu);
            this.uiGroupBox2.Controls.Add(this.txtGhiChu);
            this.uiGroupBox2.Controls.Add(this.txtGiaTri);
            this.uiGroupBox2.Controls.Add(this.cbbLoaiThu);
            this.uiGroupBox2.Controls.Add(this.label54);
            this.uiGroupBox2.Controls.Add(this.label56);
            this.uiGroupBox2.Controls.Add(this.lblDiaChi);
            this.uiGroupBox2.Controls.Add(this.label58);
            this.uiGroupBox2.Controls.Add(this.label59);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(847, 342);
            this.uiGroupBox2.TabIndex = 8;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(165, 60);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(270, 27);
            this.txtMaPhieu.TabIndex = 18;
            this.txtMaPhieu.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã phiếu : ";
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
            // txtNguoiThu
            // 
            this.txtNguoiThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiThu.Location = new System.Drawing.Point(165, 138);
            this.txtNguoiThu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNguoiThu.Name = "txtNguoiThu";
            this.txtNguoiThu.Size = new System.Drawing.Size(605, 27);
            this.txtNguoiThu.TabIndex = 4;
            this.txtNguoiThu.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(165, 214);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(605, 106);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTri.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtGiaTri.Location = new System.Drawing.Point(165, 176);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(6);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(270, 27);
            this.txtGiaTri.TabIndex = 5;
            this.txtGiaTri.Text = "0 ₫";
            this.txtGiaTri.Value = ((long)(0));
            this.txtGiaTri.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtGiaTri.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cbbLoaiThu
            // 
            this.cbbLoaiThu.Location = new System.Drawing.Point(165, 100);
            this.cbbLoaiThu.Margin = new System.Windows.Forms.Padding(6);
            this.cbbLoaiThu.Name = "cbbLoaiThu";
            this.cbbLoaiThu.Size = new System.Drawing.Size(270, 27);
            this.cbbLoaiThu.TabIndex = 2;
            this.cbbLoaiThu.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(30, 179);
            this.label54.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 20);
            this.label54.TabIndex = 11;
            this.label54.Text = "Giá trị :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(30, 103);
            this.label56.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(78, 20);
            this.label56.TabIndex = 14;
            this.label56.Text = "Loại thu : ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(30, 22);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(81, 20);
            this.lblDiaChi.TabIndex = 17;
            this.lblDiaChi.Text = "Thời gian :";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(30, 141);
            this.label58.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(85, 20);
            this.label58.TabIndex = 16;
            this.label58.Text = "Người thu :";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(30, 217);
            this.label59.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(72, 20);
            this.label59.TabIndex = 15;
            this.label59.Text = "Ghi chú :";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.btnSave);
            this.uiGroupBox1.Controls.Add(this.btnCancel);
            this.uiGroupBox1.Controls.Add(this.btnSaveAndNew);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 342);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(847, 50);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(425, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(719, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndNew.Image")));
            this.btnSaveAndNew.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveAndNew.Location = new System.Drawing.Point(550, 12);
            this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(157, 31);
            this.btnSaveAndNew.TabIndex = 7;
            this.btnSaveAndNew.Text = "Lưu && Thêm mới";
            this.btnSaveAndNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // ReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(847, 392);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReceiptsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu thu";
            this.Load += new System.EventHandler(this.ReceiptsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.GridEX.EditControls.EditBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.CalendarCombo.CalendarCombo txtThoiGian;
        private Janus.Windows.GridEX.EditControls.EditBox txtNguoiThu;
        private Janus.Windows.GridEX.EditControls.EditBox txtGhiChu;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtGiaTri;
        private Janus.Windows.EditControls.UIComboBox cbbLoaiThu;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIButton btnSave;
        private Janus.Windows.EditControls.UIButton btnCancel;
        private Janus.Windows.EditControls.UIButton btnSaveAndNew;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}