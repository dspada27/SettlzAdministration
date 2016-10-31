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
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.masterDataSet3.Users);
            // TODO: This line of code loads data into the 'masterDataSet.Polls' table. You can move, or remove it, as needed.
            this.pollsTableAdapter.Fill(this.masterDataSet.Polls);
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
    }
}
