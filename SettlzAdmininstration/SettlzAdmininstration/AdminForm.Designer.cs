namespace SettlzAdmininstration
{
    partial class AdminForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deletebtn1 = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pollIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new SettlzAdmininstration.masterDataSet();
            this.combolbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet3 = new SettlzAdmininstration.masterDataSet3();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new SettlzAdmininstration.masterDataSet3TableAdapters.UsersTableAdapter();
            this.pollsTableAdapter = new SettlzAdmininstration.masterDataSetTableAdapters.PollsTableAdapter();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Location = new System.Drawing.Point(-1, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1062, 458);
            this.TabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deletebtn1);
            this.tabPage2.Controls.Add(this.updatebtn);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.combolbl);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deletebtn1
            // 
            this.deletebtn1.Location = new System.Drawing.Point(186, 94);
            this.deletebtn1.Name = "deletebtn1";
            this.deletebtn1.Size = new System.Drawing.Size(75, 23);
            this.deletebtn1.TabIndex = 5;
            this.deletebtn1.Text = "Delete";
            this.deletebtn1.UseVisualStyleBackColor = true;
            this.deletebtn1.Click += new System.EventHandler(this.deletebtn1_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(21, 95);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.pollIdDataGridViewTextBoxColumn,
            this.argumentDataGridViewTextBoxColumn,
            this.reportCountDataGridViewTextBoxColumn,
            this.pollStatusDataGridViewCheckBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.categoryCategoryIdDataGridViewTextBoxColumn,
            this.User_UserId});
            this.dataGridView1.DataSource = this.pollsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // Select
            // 
            this.Select.FalseValue = "false";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.TrueValue = "true";
            // 
            // pollIdDataGridViewTextBoxColumn
            // 
            this.pollIdDataGridViewTextBoxColumn.DataPropertyName = "PollId";
            this.pollIdDataGridViewTextBoxColumn.HeaderText = "PollId";
            this.pollIdDataGridViewTextBoxColumn.Name = "pollIdDataGridViewTextBoxColumn";
            this.pollIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argumentDataGridViewTextBoxColumn
            // 
            this.argumentDataGridViewTextBoxColumn.DataPropertyName = "Argument";
            this.argumentDataGridViewTextBoxColumn.HeaderText = "Argument";
            this.argumentDataGridViewTextBoxColumn.Name = "argumentDataGridViewTextBoxColumn";
            // 
            // reportCountDataGridViewTextBoxColumn
            // 
            this.reportCountDataGridViewTextBoxColumn.DataPropertyName = "ReportCount";
            this.reportCountDataGridViewTextBoxColumn.HeaderText = "ReportCount";
            this.reportCountDataGridViewTextBoxColumn.Name = "reportCountDataGridViewTextBoxColumn";
            // 
            // pollStatusDataGridViewCheckBoxColumn
            // 
            this.pollStatusDataGridViewCheckBoxColumn.DataPropertyName = "PollStatus";
            this.pollStatusDataGridViewCheckBoxColumn.HeaderText = "PollStatus";
            this.pollStatusDataGridViewCheckBoxColumn.Name = "pollStatusDataGridViewCheckBoxColumn";
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // categoryCategoryIdDataGridViewTextBoxColumn
            // 
            this.categoryCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryCategoryId";
            this.categoryCategoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryCategoryId";
            this.categoryCategoryIdDataGridViewTextBoxColumn.Name = "categoryCategoryIdDataGridViewTextBoxColumn";
            // 
            // User_UserId
            // 
            this.User_UserId.DataPropertyName = "User_UserId";
            this.User_UserId.HeaderText = "User_UserId";
            this.User_UserId.Name = "User_UserId";
            // 
            // pollsBindingSource
            // 
            this.pollsBindingSource.DataMember = "Polls";
            this.pollsBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combolbl
            // 
            this.combolbl.AutoSize = true;
            this.combolbl.Location = new System.Drawing.Point(18, 18);
            this.combolbl.Name = "combolbl";
            this.combolbl.Size = new System.Drawing.Size(204, 13);
            this.combolbl.TabIndex = 2;
            this.combolbl.Text = "Please select an option from the list below";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Expired Polls",
            "Reported Polls",
            "All Polls"});
            this.comboBox1.Location = new System.Drawing.Point(21, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deletebtn);
            this.tabPage3.Controls.Add(this.updatebtn2);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1054, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Users";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(606, 89);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn2
            // 
            this.updatebtn2.Location = new System.Drawing.Point(237, 89);
            this.updatebtn2.Name = "updatebtn2";
            this.updatebtn2.Size = new System.Drawing.Size(75, 23);
            this.updatebtn2.TabIndex = 1;
            this.updatebtn2.Text = "Update";
            this.updatebtn2.UseVisualStyleBackColor = true;
            this.updatebtn2.Click += new System.EventHandler(this.updatebtn2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.userIdDataGridViewTextBoxColumn,
            this.Banned,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.usersBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(237, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 304);
            this.dataGridView2.TabIndex = 0;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.masterDataSet3;
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1054, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(123, 125);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(685, 304);
            this.reportViewer1.TabIndex = 0;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // pollsTableAdapter
            // 
            this.pollsTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // Selected
            // 
            this.Selected.FalseValue = "false";
            this.Selected.HeaderText = "Select";
            this.Selected.IndeterminateValue = "";
            this.Selected.Name = "Selected";
            this.Selected.TrueValue = "true";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Banned
            // 
            this.Banned.DataPropertyName = "Banned";
            this.Banned.HeaderText = "Banned";
            this.Banned.Name = "Banned";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 456);
            this.Controls.Add(this.TabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label combolbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource pollsBindingSource;
        private masterDataSetTableAdapters.PollsTableAdapter pollsTableAdapter;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button updatebtn2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button deletebtn1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private masterDataSet3TableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pollStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_UserId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Banned;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}