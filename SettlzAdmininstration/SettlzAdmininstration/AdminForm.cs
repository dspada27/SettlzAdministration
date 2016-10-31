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

namespace SettlzAdmininstration
{
    //comment
    //another
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;

                String query = null;

                if (comboBox1.SelectedItem.ToString() == "All Polls")
                {
                    query = "SELECT PollId, Argument, ReportCount, PollStatus, ExpiryDate, CategoryCategoryId, User_UserId FROM Polls";
                }
                else if (comboBox1.SelectedItem.ToString() == "Expired Polls")
                {
                    query = "SELECT PollId, Argument, ReportCount, PollStatus, ExpiryDate, CategoryCategoryId, User_UserId FROM Polls WHERE ExpiryDate <= getDate();";
                }
                else if (comboBox1.SelectedItem.ToString() == "Reported Polls")
                {
                    query = "SELECT PollId, Argument, ReportCount, PollStatus, ExpiryDate, CategoryCategoryId, User_UserId FROM Polls WHERE ReportCount >= 1;";
                }
                String sqlconn = "data source=142.55.49.224;initial catalog=master;persist security info=True;user id=sa;Password=Devtech1$;MultipleActiveResultSets=True;App=EntityFramework&quot;";
                SqlConnection con = new SqlConnection(sqlconn);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query;
                Console.WriteLine(query);

                SqlDataAdapter pollsTableAdapter = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                pollsTableAdapter.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                con.Close();
            }
            catch (SqlException ex)
            {

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Polls' table. You can move, or remove it, as needed.
            this.pollsTableAdapter.Fill(this.masterDataSet.Polls);
            // TODO: This line of code loads data into the 'masterDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.masterDataSet3.Users);
            this.reportViewer1.RefreshReport();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            this.pollsTableAdapter.Update(this.masterDataSet.Polls);
        }

        private void updatebtn2_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter1.Update(this.masterDataSet3.Users);
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
        }
}
