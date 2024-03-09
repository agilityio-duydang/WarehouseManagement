namespace WarehouseManagement.Administration
{
    partial class ManagementUserGroupForm
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
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementUserGroupForm));
            this.dgList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.cmdMain = new Janus.Windows.UI.CommandBars.UICommandManager(this.components);
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.uiCommandBar1 = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.cmdAdd1 = new Janus.Windows.UI.CommandBars.UICommand("cmdAdd");
            this.cmdRole1 = new Janus.Windows.UI.CommandBars.UICommand("cmdRole");
            this.cmdAdd = new Janus.Windows.UI.CommandBars.UICommand("cmdAdd");
            this.cmdRole = new Janus.Windows.UI.CommandBars.UICommand("cmdRole");
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
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
            this.dgList.Location = new System.Drawing.Point(0, 32);
            this.dgList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgList.Name = "dgList";
            this.dgList.RecordNavigator = true;
            this.dgList.Size = new System.Drawing.Size(901, 382);
            this.dgList.TabIndex = 7;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.DeletingRecord += new Janus.Windows.GridEX.RowActionCancelEventHandler(this.dgList_DeletingRecord);
            this.dgList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.dgList_RowDoubleClick);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.btnClose);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.btnDelete);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 414);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(901, 48);
            this.uiGroupBox1.TabIndex = 6;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(775, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click đôi để xem chi tiết về tài khoản";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(658, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmdMain
            // 
            this.cmdMain.AllowCustomize = Janus.Windows.UI.InheritableBoolean.False;
            this.cmdMain.AllowMerge = false;
            this.cmdMain.BottomRebar = this.BottomRebar1;
            this.cmdMain.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar1});
            this.cmdMain.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdAdd,
            this.cmdRole});
            this.cmdMain.ContainerControl = this;
            this.cmdMain.Id = new System.Guid("4cd020b0-632b-4558-9770-ff9eeedbbba1");
            this.cmdMain.LeftRebar = this.LeftRebar1;
            this.cmdMain.LockCommandBars = true;
            this.cmdMain.RightRebar = this.RightRebar1;
            this.cmdMain.TopRebar = this.TopRebar1;
            this.cmdMain.View = Janus.Windows.UI.CommandBars.View.LargeIcons;
            this.cmdMain.CommandClick += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdMain_CommandClick);
            // 
            // BottomRebar1
            // 
            this.BottomRebar1.CommandManager = this.cmdMain;
            this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRebar1.Location = new System.Drawing.Point(0, 0);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(0, 0);
            // 
            // uiCommandBar1
            // 
            this.uiCommandBar1.CommandManager = this.cmdMain;
            this.uiCommandBar1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdAdd1,
            this.cmdRole1});
            this.uiCommandBar1.Key = "CommandBar1";
            this.uiCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.uiCommandBar1.Margin = new System.Windows.Forms.Padding(2);
            this.uiCommandBar1.Name = "uiCommandBar1";
            this.uiCommandBar1.RowIndex = 0;
            this.uiCommandBar1.Size = new System.Drawing.Size(245, 32);
            this.uiCommandBar1.Text = "CommandBar1";
            // 
            // cmdAdd1
            // 
            this.cmdAdd1.Key = "cmdAdd";
            this.cmdAdd1.Name = "cmdAdd1";
            // 
            // cmdRole1
            // 
            this.cmdRole1.Key = "cmdRole";
            this.cmdRole1.Name = "cmdRole1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
            this.cmdAdd.Key = "cmdAdd";
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Text = "Tạo mới";
            // 
            // cmdRole
            // 
            this.cmdRole.Image = ((System.Drawing.Image)(resources.GetObject("cmdRole.Image")));
            this.cmdRole.Key = "cmdRole";
            this.cmdRole.Name = "cmdRole";
            this.cmdRole.Text = "Phân quyền";
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.cmdMain;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 0);
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.cmdMain;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(0, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 0);
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar1});
            this.TopRebar1.CommandManager = this.cmdMain;
            this.TopRebar1.Controls.Add(this.uiCommandBar1);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Margin = new System.Windows.Forms.Padding(2);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(901, 32);
            // 
            // ManagementUserGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(901, 462);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.TopRebar1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagementUserGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhóm người dùng";
            this.Load += new System.EventHandler(this.ManagementUserGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.UI.CommandBars.UICommandManager cmdMain;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        private Janus.Windows.UI.CommandBars.UICommandBar uiCommandBar1;
        private Janus.Windows.UI.CommandBars.UICommand cmdAdd1;
        private Janus.Windows.UI.CommandBars.UICommand cmdRole1;
        private Janus.Windows.UI.CommandBars.UICommand cmdAdd;
        private Janus.Windows.UI.CommandBars.UICommand cmdRole;
        private Janus.Windows.EditControls.UIButton btnClose;
    }
}