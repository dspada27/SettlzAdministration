using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SettlzAdmininstration
{
    public partial class Settlz : Form
    {
        String username = "";
        String password = "";
        public Settlz()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(userTextBox.Text != "" && passTextBox.Text != "")
            {
                String sqlconn = "data source=142.55.49.224;initial catalog=master;persist security info=True;user id="+userTextBox.Text+";Password="+passTextBox.Text+";MultipleActiveResultSets=True;App=EntityFramework&quot;";
                SqlConnection con = new SqlConnection(sqlconn);
                try {
                    con.Open();
                    con.Close();
                    username = userTextBox.Text;
                    password = passTextBox.Text;
                    AdminForm f2 = new AdminForm();
                    
                    f2.Show();
                }
                catch (Exception ex)
                {
                    String errmsg = "incorrect Username or password please enter valid credentials";
                    System.Windows.Forms.MessageBox.Show(errmsg);
                }
            }
            else
            {
                String errmsg = "incorrect Username or password please enter valid credentials";
                System.Windows.Forms.MessageBox.Show(errmsg);
            }
        }
    }
}
