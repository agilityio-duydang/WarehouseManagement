namespace WarehouseManagement
{
    partial class SQLQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLQueryForm));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnTabDelete = new Janus.Windows.EditControls.UIButton();
            this.btnTabNew = new Janus.Windows.EditControls.UIButton();
            this.btnQuery = new Janus.Windows.EditControls.UIButton();
            this.btnSelect = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.btnInsert = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.cbbTable = new Janus.Windows.EditControls.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabQuery = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMessage = new Janus.Windows.GridEX.EditControls.EditBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabQuery)).BeginInit();
            this.tabQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.uiTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.AutoScroll = true;
            this.uiGroupBox1.Controls.Add(this.uiGroupBox5);
            this.uiGroupBox1.Controls.Add(this.cbbTable);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1023, 150);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Thông tin tìm kiếm";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.AutoScroll = true;
            this.uiGroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.uiGroupBox5.Controls.Add(this.btnTabDelete);
            this.uiGroupBox5.Controls.Add(this.btnTabNew);
            this.uiGroupBox5.Controls.Add(this.btnQuery);
            this.uiGroupBox5.Controls.Add(this.btnSelect);
            this.uiGroupBox5.Controls.Add(this.btnDelete);
            this.uiGroupBox5.Controls.Add(this.btnInsert);
            this.uiGroupBox5.Controls.Add(this.btnUpdate);
            this.uiGroupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox5.Location = new System.Drawing.Point(3, 78);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(1017, 69);
            this.uiGroupBox5.TabIndex = 9;
            this.uiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnTabDelete
            // 
            this.btnTabDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnTabDelete.Image")));
            this.btnTabDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTabDelete.Location = new System.Drawing.Point(121, 17);
            this.btnTabDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTabDelete.Name = "btnTabDelete";
            this.btnTabDelete.Size = new System.Drawing.Size(95, 30);
            this.btnTabDelete.TabIndex = 8;
            this.btnTabDelete.Text = "Tab -";
            this.btnTabDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnTabDelete.Click += new System.EventHandler(this.btnTabDelete_Click);
            // 
            // btnTabNew
            // 
            this.btnTabNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabNew.Image = ((System.Drawing.Image)(resources.GetObject("btnTabNew.Image")));
            this.btnTabNew.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTabNew.Location = new System.Drawing.Point(18, 17);
            this.btnTabNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTabNew.Name = "btnTabNew";
            this.btnTabNew.Size = new System.Drawing.Size(95, 30);
            this.btnTabNew.TabIndex = 8;
            this.btnTabNew.Text = "Tab +";
            this.btnTabNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnTabNew.Click += new System.EventHandler(this.btnTabNew_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQuery.Location = new System.Drawing.Point(224, 17);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(113, 30);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "Execute";
            this.btnQuery.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelect.Location = new System.Drawing.Point(345, 17);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 30);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Select";
            this.btnSelect.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(665, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInsert.Location = new System.Drawing.Point(446, 17);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 30);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(548, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbbTable
            // 
            this.cbbTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTable.Location = new System.Drawing.Point(91, 24);
            this.cbbTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(315, 27);
            this.cbbTable.TabIndex = 1;
            this.cbbTable.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            // 
            // tabQuery
            // 
            this.tabQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabQuery.Location = new System.Drawing.Point(0, 150);
            this.tabQuery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabQuery.Size = new System.Drawing.Size(1023, 254);
            this.tabQuery.TabIndex = 2;
            this.tabQuery.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1});
            this.tabQuery.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            this.tabQuery.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabQuery_KeyUp);
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1021, 226);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "SQL QUERY 1";
            this.uiTabPage1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabQuery_KeyUp);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.AutoScroll = true;
            this.uiGroupBox4.BackColor = System.Drawing.Color.White;
            this.uiGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox4.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(794, 242);
            this.uiGroupBox4.TabIndex = 3;
            this.uiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.Location = new System.Drawing.Point(0, 404);
            this.uiTab1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uiTab1.Size = new System.Drawing.Size(1023, 177);
            this.uiTab1.TabIndex = 3;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3});
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.grdResult);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1021, 149);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "Kết quả";
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdResult.Location = new System.Drawing.Point(0, 0);
            this.grdResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(1021, 149);
            this.grdResult.TabIndex = 0;
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.txtMessage);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 27);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(1021, 149);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "Thông báo";
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1021, 149);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // SQLQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1023, 581);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.tabQuery);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SQLQueryForm";
            this.Text = "Thực hiện truy vấn SQL";
            this.Load += new System.EventHandler(this.SQLQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabQuery)).EndInit();
            this.tabQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIComboBox cbbTable;
        private Janus.Windows.EditControls.UIButton btnQuery;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.EditControls.UIButton btnInsert;
        private Janus.Windows.EditControls.UIButton btnSelect;
        private Janus.Windows.UI.Tab.UITab tabQuery;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private Janus.Windows.EditControls.UIButton btnTabDelete;
        private Janus.Windows.EditControls.UIButton btnTabNew;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.DataGridView grdResult;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.GridEX.EditControls.EditBox txtMessage;
    }
}