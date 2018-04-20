using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_7
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCreatAccount_Click(object sender, EventArgs e)
        {
            Account_Creation createAccount = new Account_Creation();
            createAccount.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmailError();

            if (EmailError() == false)
            {
                CheckEmailPassword();

                if (CheckEmailPassword() == true)
                {
                    CustomerInfo.Email = txtEmail.Text;

                    Tickets tickets = new Tickets();
                    tickets.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error. Incorrect username and or password.");
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                }                
            }
            else
            {
                MessageBox.Show("Error. Email must be in correct format");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        }

        private bool CheckEmailPassword()
        {
            string[] customerInfo = File.ReadAllLines("Customer Info.txt");
            foreach (string accountInfo in customerInfo)
            {
                var splitLine = accountInfo.Split(',');
                string email = splitLine[2];
                string password = splitLine[3];

                if (txtEmail.Text == email && txtPassword.Text == password)
                {
                    return true;
                }
            }
            return false;
        }

        private bool EmailError()
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(txtEmail.Text);
                return false;
            }
            catch
            {
                return true;                               
            }
        }
    }
}
