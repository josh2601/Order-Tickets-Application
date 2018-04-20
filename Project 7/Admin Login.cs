using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_7
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "BACS287";

           if (username == txtAdminUsername.Text && password == txtAdminPassword.Text)
            {
                Admin admin = new Admin();               
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error. Wrong username or password.");
            }
            
        }
    }
}
