﻿namespace SettlzAdmininstration
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
            this.combolbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new SettlzAdmininstration.masterDataSet();
            this.pollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollsTableAdapter = new SettlzAdmininstration.masterDataSetTableAdapters.PollsTableAdapter();
            this.updatebtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet1 = new SettlzAdmininstration.masterDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new SettlzAdmininstration.masterDataSet1TableAdapters.UsersTableAdapter();
            this.updatebtn2 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.deletebtn1 = new System.Windows.Forms.Button();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebookAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twitterAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pollIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionOptionsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twitterTwitterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebookFacebookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
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
            this.tabPage1.Size = new System.Drawing.Size(1003, 367);
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1003, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.optionOptionsIdDataGridViewTextBoxColumn,
            this.twitterTwitterIdDataGridViewTextBoxColumn,
            this.facebookFacebookIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pollsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pollsBindingSource
            // 
            this.pollsBindingSource.DataMember = "Polls";
            this.pollsBindingSource.DataSource = this.masterDataSet;
            // 
            // pollsTableAdapter
            // 
            this.pollsTableAdapter.ClearBeforeFill = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.userIdDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.facebookAccountDataGridViewTextBoxColumn,
            this.twitterAccountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.usersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(169, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(665, 304);
            this.dataGridView2.TabIndex = 0;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet1";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.masterDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // updatebtn2
            // 
            this.updatebtn2.Location = new System.Drawing.Point(169, 89);
            this.updatebtn2.Name = "updatebtn2";
            this.updatebtn2.Size = new System.Drawing.Size(75, 23);
            this.updatebtn2.TabIndex = 1;
            this.updatebtn2.Text = "Update";
            this.updatebtn2.UseVisualStyleBackColor = true;
            this.updatebtn2.Click += new System.EventHandler(this.updatebtn2_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(269, 89);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
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
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // facebookAccountDataGridViewTextBoxColumn
            // 
            this.facebookAccountDataGridViewTextBoxColumn.DataPropertyName = "FacebookAccount";
            this.facebookAccountDataGridViewTextBoxColumn.HeaderText = "FacebookAccount";
            this.facebookAccountDataGridViewTextBoxColumn.Name = "facebookAccountDataGridViewTextBoxColumn";
            // 
            // twitterAccountDataGridViewTextBoxColumn
            // 
            this.twitterAccountDataGridViewTextBoxColumn.DataPropertyName = "TwitterAccount";
            this.twitterAccountDataGridViewTextBoxColumn.HeaderText = "TwitterAccount";
            this.twitterAccountDataGridViewTextBoxColumn.Name = "twitterAccountDataGridViewTextBoxColumn";
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
            // optionOptionsIdDataGridViewTextBoxColumn
            // 
            this.optionOptionsIdDataGridViewTextBoxColumn.DataPropertyName = "Option_OptionsId";
            this.optionOptionsIdDataGridViewTextBoxColumn.HeaderText = "Option_OptionsId";
            this.optionOptionsIdDataGridViewTextBoxColumn.Name = "optionOptionsIdDataGridViewTextBoxColumn";
            // 
            // twitterTwitterIdDataGridViewTextBoxColumn
            // 
            this.twitterTwitterIdDataGridViewTextBoxColumn.DataPropertyName = "Twitter_TwitterId";
            this.twitterTwitterIdDataGridViewTextBoxColumn.HeaderText = "Twitter_TwitterId";
            this.twitterTwitterIdDataGridViewTextBoxColumn.Name = "twitterTwitterIdDataGridViewTextBoxColumn";
            // 
            // facebookFacebookIdDataGridViewTextBoxColumn
            // 
            this.facebookFacebookIdDataGridViewTextBoxColumn.DataPropertyName = "Facebook_FacebookId";
            this.facebookFacebookIdDataGridViewTextBoxColumn.HeaderText = "Facebook_FacebookId";
            this.facebookFacebookIdDataGridViewTextBoxColumn.Name = "facebookFacebookIdDataGridViewTextBoxColumn";
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet1 masterDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private masterDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button updatebtn2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button deletebtn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pollStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionOptionsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twitterTwitterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebookFacebookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebookAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twitterAccountDataGridViewTextBoxColumn;
    }
}