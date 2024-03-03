namespace WarehouseManagement
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            Janus.Windows.GridEX.GridEXLayout dgList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.txtUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtPasswordNew = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtRePassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHint = new Janus.Windows.GridEX.EditControls.EditBox();
            this.s = new Janus.Windows.EditControls.UIGroupBox();
            this.txtSoDienThoai = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.txtDiaChi = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtEmail = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbAdd = new Janus.Windows.EditControls.UIGroupBox();
            this.chkIsAdmin = new Janus.Windows.EditControls.UICheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.dgList = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAdd)).BeginInit();
            this.grbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(296, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(159, 157);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(314, 27);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(159, 20);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(314, 27);
            this.txtPasswordNew.TabIndex = 6;
            this.txtPasswordNew.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(159, 65);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(314, 27);
            this.txtRePassword.TabIndex = 7;
            this.txtRePassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ và tên :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(159, 22);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(314, 27);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Từ gợi ý :";
            // 
            // txtHint
            // 
            this.txtHint.Location = new System.Drawing.Point(159, 101);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(314, 27);
            this.txtHint.TabIndex = 8;
            this.txtHint.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // s
            // 
            this.s.AutoScroll = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Controls.Add(this.txtSoDienThoai);
            this.s.Controls.Add(this.txtDiaChi);
            this.s.Controls.Add(this.txtEmail);
            this.s.Controls.Add(this.txtUserName);
            this.s.Controls.Add(this.label9);
            this.s.Controls.Add(this.label2);
            this.s.Controls.Add(this.label8);
            this.s.Controls.Add(this.label1);
            this.s.Controls.Add(this.txtFullName);
            this.s.Controls.Add(this.label5);
            this.s.Dock = System.Windows.Forms.DockStyle.Top;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(542, 192);
            this.s.TabIndex = 3;
            this.s.Text = "Thông tin";
            this.s.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(159, 55);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Numeric = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(314, 27);
            this.txtSoDienThoai.TabIndex = 2;
            this.txtSoDienThoai.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(159, 88);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(314, 27);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số điện thoại :";
            // 
            // grbAdd
            // 
            this.grbAdd.AutoScroll = true;
            this.grbAdd.Controls.Add(this.txtPasswordNew);
            this.grbAdd.Controls.Add(this.label4);
            this.grbAdd.Controls.Add(this.label3);
            this.grbAdd.Controls.Add(this.txtRePassword);
            this.grbAdd.Controls.Add(this.txtHint);
            this.grbAdd.Controls.Add(this.label6);
            this.grbAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbAdd.Location = new System.Drawing.Point(0, 192);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(542, 143);
            this.grbAdd.TabIndex = 5;
            this.grbAdd.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.Location = new System.Drawing.Point(159, 19);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(104, 23);
            this.chkIsAdmin.TabIndex = 9;
            this.chkIsAdmin.Text = "    Quản trị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phân quyền :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.btnClose);
            this.uiGroupBox1.Controls.Add(this.btnUpdate);
            this.uiGroupBox1.Controls.Add(this.chkIsAdmin);
            this.uiGroupBox1.Controls.Add(this.label7);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 582);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(542, 49);
            this.uiGroupBox1.TabIndex = 11;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(416, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 31);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.AutoScroll = true;
            this.uiGroupBox2.Controls.Add(this.dgList);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 335);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(542, 247);
            this.uiGroupBox2.TabIndex = 12;
            this.uiGroupBox2.Text = "Danh sách nhóm người dùng";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dgList
            // 
            this.dgList.AlternatingColors = true;
            this.dgList.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>Hiển t" +
                "hị theo nhóm.</GroupByBoxInfo></LocalizableData>";
            this.dgList.ColumnAutoResize = true;
            dgList_DesignTimeLayout.LayoutString = resources.GetString("dgList_DesignTimeLayout.LayoutString");
            this.dgList.DesignTimeLayout = dgList_DesignTimeLayout;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgList.GroupByBoxVisible = false;
            this.dgList.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgList.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgList.Location = new System.Drawing.Point(3, 23);
            this.dgList.Name = "dgList";
            this.dgList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgList.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.dgList.Size = new System.Drawing.Size(536, 221);
            this.dgList.TabIndex = 1;
            this.dgList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.dgList.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgListGroup_LoadingRow);
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(542, 631);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.grbAdd);
            this.Controls.Add(this.s);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(558, 670);
            this.MinimumSize = new System.Drawing.Size(558, 670);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAdd)).EndInit();
            this.grbAdd.ResumeLayout(false);
            this.grbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.GridEX.EditControls.EditBox txtUserName;
        private Janus.Windows.GridEX.EditControls.EditBox txtPasswordNew;
        private Janus.Windows.GridEX.EditControls.EditBox txtRePassword;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox txtFullName;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.GridEX.EditControls.EditBox txtHint;
        private Janus.Windows.EditControls.UIGroupBox s;
        private Janus.Windows.EditControls.UICheckBox chkIsAdmin;
        private System.Windows.Forms.Label label7;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox txtSoDienThoai;
        private Janus.Windows.GridEX.EditControls.EditBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.EditControls.UIGroupBox grbAdd;
        private Janus.Windows.GridEX.EditControls.EditBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.GridEX.GridEX dgList;
        private Janus.Windows.EditControls.UIButton btnClose;
    }
}