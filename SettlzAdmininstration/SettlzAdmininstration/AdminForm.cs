using System;
using SettlzAdmininstration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SettlzAdmininstration.masterDataSet3TableAdapters;
using Microsoft.Reporting.WinForms;
using System.Net;

namespace SettlzAdmininstration
{
    //comment
    //another
    public partial class AdminForm : Form
    {
        PollsTableAdapter pollsTableAdapter1 = new PollsTableAdapter();
        UsersTableAdapter userTableAdapter1 = new UsersTableAdapter();
        masterDataSet3.PollsDataTable pollRecord = new masterDataSet3.PollsDataTable();
        masterDataSet3.UsersDataTable userRecord = new masterDataSet3.UsersDataTable();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pollRecord.Clear();
                dataGridView1.DataSource = null;

                if (comboBox1.SelectedItem.ToString() == "All Polls")
                {
                    pollsTableAdapter1.FillByAll(pollRecord);
                }
                else if (comboBox1.SelectedItem.ToString() == "Expired Polls")
                {
                    pollsTableAdapter1.FillByExpiry(pollRecord);
                }
                else if (comboBox1.SelectedItem.ToString() == "Reported Polls")
                {
                    pollsTableAdapter1.FillByReported(pollRecord);
                }

                dataGridView1.DataSource = pollRecord;
            }
            catch (SqlException ex)
            {

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                pollsTableAdapter1.Update(pollRecord);
                String msg = "Row(s) Updated";
                System.Windows.Forms.MessageBox.Show(msg);
            }
            catch (Exception ex) { }
        }

        private void updatebtn2_Click(object sender, EventArgs e)
        {
            try
            {
                usersTableAdapter1.Update(userRecord);
                String msg = "Row(s) Updated";
                System.Windows.Forms.MessageBox.Show(msg);
            }
            catch (Exception ex) { }
        }

        private void deletebtn1_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                object delete = dataGridView1.Rows[i].Cells[0].Value;

                // if the checkbox cell is checked

                if (delete == "true")
                {
                    DataGridViewRow rowToRemove = dataGridView1.Rows[i];

                    dataGridView1.Rows.Remove(rowToRemove);
                }
            }
          pollsTableAdapter1.Update(pollRecord);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                object delete = dataGridView2.Rows[i].Cells["Selected"].Value;

                // if the checkbox cell is checked

                if (delete == "true")
                {
                    DataGridViewRow rowToRemove = dataGridView2.Rows[i];

                    dataGridView2.Rows.Remove(rowToRemove);
                }
            }
            usersTableAdapter1.Update(userRecord);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                userRecord.Clear();
                dataGridView2.DataSource = null;

                if (comboBox2.SelectedItem.ToString() == "All Users")
                {
                    usersTableAdapter1.FillByAll(userRecord);
                }
                else if (comboBox2.SelectedItem.ToString() == "Banned Users")
                {
                    usersTableAdapter1.FillByBanned(userRecord);
                }
                else if (comboBox2.SelectedItem.ToString() == "Active Users")
                {
                    usersTableAdapter1.FillByActive(userRecord);
                }

                dataGridView2.DataSource = userRecord;
            }
            catch (SqlException ex)
            {

            }
        }
   
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {         
            ServerReport serverReport = reportViewer1.ServerReport;
            serverReport.ReportServerUrl = new Uri("http://142.55.49.224/ReportServer");

            //Passing credentials for the server to login to avoid 401 unathorized msg
            System.Net.NetworkCredential myCred = new
               NetworkCredential("csadmin", "$PleaseChangeMe2015$", "");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                myCred;

            if (comboBox3.SelectedItem.ToString() == "SharingReport")
            {                                
                serverReport.ReportPath =
                    "/NewReports/SharingReport";              
            }
            else if (comboBox3.SelectedItem.ToString() == "CategoryReport")
            {                                        
                serverReport.ReportPath =
                    "/NewReports/CategoryReport";
            }
            else if (comboBox3.SelectedItem.ToString() == "test3")
            {                                     
                serverReport.ReportPath =
                    "/NewReports/test3";
            }
            reportViewer1.RefreshReport();
        }  
}
}
