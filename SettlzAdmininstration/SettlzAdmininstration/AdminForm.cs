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
        masterDataSet3.PollsDataTable dtRecord = new masterDataSet3.PollsDataTable();
        String sqlconn = "data source=142.55.49.224;initial catalog=master;persist security info=True;user id=sa;Password=Devtech1$;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtRecord.Clear();
                dataGridView1.DataSource = null;

                if (comboBox1.SelectedItem.ToString() == "All Polls")
                {
                    pollsTableAdapter1.Fill(dtRecord);
                }
                else if (comboBox1.SelectedItem.ToString() == "Expired Polls")
                {
                    pollsTableAdapter1.FillByExpiry(dtRecord);
                }
                else if (comboBox1.SelectedItem.ToString() == "Reported Polls")
                {
                    pollsTableAdapter1.FillBy(dtRecord);
                }
                SqlConnection con = new SqlConnection(sqlconn);
                con.Open();

                dataGridView1.DataSource = dtRecord;
                con.Close();
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
                pollsTableAdapter1.Update(dtRecord);
                String msg = "Row(s) Updated";
                System.Windows.Forms.MessageBox.Show(msg);
            }
            catch (Exception ex) { }
        }

        private void updatebtn2_Click(object sender, EventArgs e)
        {
       
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
            this.pollsTableAdapter.Update(this.masterDataSet.Polls);
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
            this.usersTableAdapter1.Update(this.masterDataSet3.Users);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                try
                {
                    dataGridView2.DataSource = null;

                    String query = null;

                    if (comboBox2.SelectedItem.ToString() == "All Users")
                    {
                        query = "SELECT UserId, banned, email FROM Users";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Banned Users")
                    {
                        query = "SELECT UserId, banned, email FROM Users WHERE banned = 1";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Active Users")
                    {
                        query = "SELECT UserId, banned, email FROM Users WHERE banned = 0";
                    }
                    String sqlconn = "data source=142.55.49.224;initial catalog=master;persist security info=True;user id=sa;Password=Devtech1$;MultipleActiveResultSets=True;App=EntityFramework&quot;";
                    SqlConnection con = new SqlConnection(sqlconn);
                    con.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = con;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = query;
                    Console.WriteLine(query);

                    SqlDataAdapter usersTableAdapter = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    usersTableAdapter.Fill(dtRecord);
                    dataGridView2.DataSource = dtRecord;
                    con.Close();
                }
                catch (SqlException ex)
                {

                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            if (comboBox3.SelectedItem.ToString() == "test1")
            {                                
                serverReport.ReportPath =
                    "/NewReports/test1";              
            }
            else if (comboBox3.SelectedItem.ToString() == "test2")
            {                                        
                serverReport.ReportPath =
                    "/NewReports/test2";
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
