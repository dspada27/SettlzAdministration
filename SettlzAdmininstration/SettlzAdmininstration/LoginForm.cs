using System;
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
    public partial class Settlz : Form
    {
        public Settlz()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String username = "sa";
            String password = "Devtech1$";
            if(userTextBox.Text == username && passTextBox.Text == password)
            {
                AdminForm f2 = new AdminForm();
                f2.Show();
            }
            else
            {
                String errmsg = "incorrect Username or password please enter valid credentials";
                System.Windows.Forms.MessageBox.Show(errmsg);
            }
        }
    }
}
