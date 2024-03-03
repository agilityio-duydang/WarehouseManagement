namespace WarehouseManagement
{
    partial class CashierForm
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
            Janus.Windows.GridEX.GridEXLayout dgListProducts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgListProducts = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbbCategory = new Janus.Windows.EditControls.UIComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new Janus.Windows.GridEX.EditControls.EditBox();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox8 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.txtDonGia = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtSoLuong = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uiGroupBox7 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtGhiChu = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbKhachHang = new Janus.Windows.EditControls.UIComboBox();
            this.lblThoiGianTao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtThueGTGT = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnPrint = new Janus.Windows.EditControls.UIButton();
            this.btnCash = new Janus.Windows.EditControls.UIButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox8)).BeginInit();
            this.uiGroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox7)).BeginInit();
            this.uiGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiTab1);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(472, 627);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.Location = new System.Drawing.Point(3, 101);
            this.uiTab1.Margin = new System.Windows.Forms.Padding(5);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Size = new System.Drawing.Size(466, 523);
            this.uiTab1.TabIndex = 3;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2});
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.dgListProducts);
            this.uiTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.Image")));
            this.uiTabPage2.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(464, 495);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "Hàng hoá";
            // 
            // dgListProducts
            // 
            this.dgListProducts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgListProducts.ColumnAutoResize = true;
            dgListProducts_DesignTimeLayout.LayoutString = resources.GetString("dgListProducts_DesignTimeLayout.LayoutString");
            this.dgListProducts.DesignTimeLayout = dgListProducts_DesignTimeLayout;
            this.dgListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListProducts.GroupByBoxVisible = false;
            this.dgListProducts.Location = new System.Drawing.Point(0, 0);
            this.dgListProducts.Margin = new System.Windows.Forms.Padding(5);
            this.dgListProducts.Name = "dgListProducts";
            this.dgListProducts.RecordNavigator = true;
            this.dgListProducts.Size = new System.Drawing.Size(464, 495);
            this.dgListProducts.TabIndex = 9;
            this.dgListProducts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgListProducts.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgListProducts_RowDoubleClick);
            this.dgListProducts.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgListProducts_LoadingRow);
            this.dgListProducts.Click += new System.EventHandler(this.dgListProducts_SelectionChanged);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.AutoScroll = true;
            this.uiGroupBox4.Controls.Add(this.cbbCategory);
            this.uiGroupBox4.Controls.Add(this.label6);
            this.uiGroupBox4.Controls.Add(this.label7);
            this.uiGroupBox4.Controls.Add(this.txtTenHangHoa);
            this.uiGroupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox4.Location = new System.Drawing.Point(3, 8);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(466, 93);
            this.uiGroupBox4.TabIndex = 2;
            this.uiGroupBox4.Text = "Tìm hàng hoá";
            this.uiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategory.Location = new System.Drawing.Point(133, 54);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(5);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(295, 27);
            this.cbbCategory.TabIndex = 2;
            this.cbbCategory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbCategory.SelectedValueChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Danh mục : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tên hàng hoá : ";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHangHoa.Location = new System.Drawing.Point(133, 19);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(295, 27);
            this.txtTenHangHoa.TabIndex = 1;
            this.txtTenHangHoa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtTenHangHoa.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.dgList);
            this.uiGroupBox2.Controls.Add(this.uiGroupBox8);
            this.uiGroupBox2.Controls.Add(this.uiGroupBox7);
            this.uiGroupBox2.Controls.Add(this.uiGroupBox3);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(472, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(805, 627);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.dgList.Location = new System.Drawing.Point(3, 170);
            this.dgList.Margin = new System.Windows.Forms.Padding(5);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.dgList.Size = new System.Drawing.Size(799, 347);
            this.dgList.TabIndex = 12;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgList_RowDoubleClick);
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgList_LoadingRow);
            this.dgList.Click += new System.EventHandler(this.dgList_Click);
            // 
            // uiGroupBox8
            // 
            this.uiGroupBox8.AutoScroll = true;
            this.uiGroupBox8.Controls.Add(this.btnUpdate);
            this.uiGroupBox8.Controls.Add(this.txtDonGia);
            this.uiGroupBox8.Controls.Add(this.txtSoLuong);
            this.uiGroupBox8.Controls.Add(this.label10);
            this.uiGroupBox8.Controls.Add(this.label12);
            this.uiGroupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox8.Location = new System.Drawing.Point(3, 112);
            this.uiGroupBox8.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox8.Name = "uiGroupBox8";
            this.uiGroupBox8.Size = new System.Drawing.Size(799, 58);
            this.uiGroupBox8.TabIndex = 11;
            this.uiGroupBox8.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(475, 13);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 28);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtDonGia.Location = new System.Drawing.Point(350, 14);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(115, 27);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.Text = "0 ₫";
            this.txtDonGia.Value = ((long)(0));
            this.txtDonGia.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.txtDonGia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(127, 14);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(115, 27);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.Text = "0,00";
            this.txtSoLuong.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtSoLuong.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Đơn giá : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Số lượng : ";
            // 
            // uiGroupBox7
            // 
            this.uiGroupBox7.AutoScroll = true;
            this.uiGroupBox7.Controls.Add(this.txtGhiChu);
            this.uiGroupBox7.Controls.Add(this.label4);
            this.uiGroupBox7.Controls.Add(this.cbbKhachHang);
            this.uiGroupBox7.Controls.Add(this.lblThoiGianTao);
            this.uiGroupBox7.Controls.Add(this.label3);
            this.uiGroupBox7.Controls.Add(this.label2);
            this.uiGroupBox7.Controls.Add(this.lblTenNhanVien);
            this.uiGroupBox7.Controls.Add(this.label1);
            this.uiGroupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox7.Location = new System.Drawing.Point(3, 8);
            this.uiGroupBox7.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox7.Name = "uiGroupBox7";
            this.uiGroupBox7.Size = new System.Drawing.Size(799, 104);
            this.uiGroupBox7.TabIndex = 9;
            this.uiGroupBox7.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(472, 14);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(312, 82);
            this.txtGhiChu.TabIndex = 38;
            this.txtGhiChu.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ghi chú : ";
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.Location = new System.Drawing.Point(127, 69);
            this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(338, 27);
            this.cbbKhachHang.TabIndex = 36;
            this.cbbKhachHang.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbbKhachHang_SelectedIndexChanged);
            // 
            // lblThoiGianTao
            // 
            this.lblThoiGianTao.AutoSize = true;
            this.lblThoiGianTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianTao.Location = new System.Drawing.Point(131, 45);
            this.lblThoiGianTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiGianTao.Name = "lblThoiGianTao";
            this.lblThoiGianTao.Size = new System.Drawing.Size(0, 20);
            this.lblThoiGianTao.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Thời gian : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Khách hàng : ";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(131, 18);
            this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(0, 20);
            this.lblTenNhanVien.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nhân viên : ";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiGroupBox5);
            this.uiGroupBox3.Controls.Add(this.btnPrint);
            this.uiGroupBox3.Controls.Add(this.btnCash);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.Location = new System.Drawing.Point(3, 517);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(799, 107);
            this.uiGroupBox3.TabIndex = 1;
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.AutoScroll = true;
            this.uiGroupBox5.Controls.Add(this.txtThueGTGT);
            this.uiGroupBox5.Controls.Add(this.label8);
            this.uiGroupBox5.Controls.Add(this.btnDelete);
            this.uiGroupBox5.Controls.Add(this.lblTongTien);
            this.uiGroupBox5.Controls.Add(this.lblDiaChi);
            this.uiGroupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox5.Location = new System.Drawing.Point(3, 8);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(793, 52);
            this.uiGroupBox5.TabIndex = 28;
            this.uiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtThueGTGT
            // 
            this.txtThueGTGT.Location = new System.Drawing.Point(398, 17);
            this.txtThueGTGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtThueGTGT.Name = "txtThueGTGT";
            this.txtThueGTGT.Size = new System.Drawing.Size(99, 27);
            this.txtThueGTGT.TabIndex = 32;
            this.txtThueGTGT.Text = "0";
            this.txtThueGTGT.Value = 0;
            this.txtThueGTGT.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.txtThueGTGT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtThueGTGT.TextChanged += new System.EventHandler(this.txtThueGTGT_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Thuế suất  (%) :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(689, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(98, 20);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 20);
            this.lblTongTien.TabIndex = 30;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(11, 20);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(83, 20);
            this.lblDiaChi.TabIndex = 29;
            this.lblDiaChi.Text = "Tổng tiền :";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(360, 66);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(208, 32);
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
            this.btnCash.Location = new System.Drawing.Point(577, 66);
            this.btnCash.Margin = new System.Windows.Forms.Padding(5);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(208, 32);
            this.btnCash.TabIndex = 6;
            this.btnCash.Text = "Thanh toán";
            this.btnCash.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1277, 627);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CashierForm";
            this.Text = "Màn hình Thu Ngân";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox8)).EndInit();
            this.uiGroupBox8.ResumeLayout(false);
            this.uiGroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox7)).EndInit();
            this.uiGroupBox7.ResumeLayout(false);
            this.uiGroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Janus.Windows.GridEX.EditControls.EditBox txtTenHangHoa;
        private Janus.Windows.EditControls.UIButton btnPrint;
        private Janus.Windows.EditControls.UIButton btnCash;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDiaChi;
        private Janus.Windows.GridEX.GridEX dgListProducts;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox7;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThoiGianTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Janus.Windows.EditControls.UIComboBox cbbCategory;
        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox8;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtDonGia;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtThueGTGT;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.EditControls.UIComboBox cbbKhachHang;
        private Janus.Windows.GridEX.EditControls.EditBox txtGhiChu;
        private System.Windows.Forms.Label label4;
    }
}