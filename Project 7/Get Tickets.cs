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
    public partial class getTickets : Form
    {
        public getTickets()
        {
            InitializeComponent();
        }

        
        private void btnGetTickets_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();  
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            Admin_Login adminLogin = new Admin_Login();
            adminLogin.ShowDialog();
        }
    }
}
