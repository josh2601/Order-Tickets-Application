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
    public partial class Account_Creation : Form
    {
        public Account_Creation()
        {
            InitializeComponent();
        }

        private bool DuplicateEmail()
        {
            string[] emailAddresses;
            emailAddresses = File.ReadAllLines("Customer Info.txt");
            
            foreach (string currentEmailAddress in emailAddresses)
            {
                var splitline = currentEmailAddress.Split(',');
                string email = splitline[2];
                
                if (email == CustomerInfo.Email)
                {
                    return true;                    
                }                              
            }
            return false;
        }

        private bool EmailErrorCheck()
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(CustomerInfo.Email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool CorrectAge()
        {
            try
            {
                int Age = int.Parse(txtAge.Text);

                if (Age <= 16)
                {
                    return false;                    
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerInfo.Name = txtName.Text;
            CustomerInfo.Email = txtEMail.Text;

            EmailErrorCheck();

            if (EmailErrorCheck() == true)
            {
                DuplicateEmail();

                if (DuplicateEmail() == false)
                {
                    CorrectAge();

                    if (CorrectAge() == true)
                    {
                        CustomerInfo.Name = txtName.Text;
                        CustomerInfo.Age = int.Parse(txtAge.Text);
                        CustomerInfo.Email = txtEMail.Text;

                        string[] customerInfo = new string[4];

                        customerInfo[0] = CustomerInfo.Name;
                        customerInfo[1] = CustomerInfo.Age.ToString();
                        customerInfo[2] = CustomerInfo.Email;
                        customerInfo[3] = txtPassword.Text;

                        string allCustomerInfo = string.Join(",", customerInfo);

                        File.AppendAllText("Customer Info.txt", allCustomerInfo + Environment.NewLine);

                        Tickets ticket = new Tickets();
                        ticket.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        try
                        {
                            int age = int.Parse(txtAge.Text);
                            MessageBox.Show("Error. You must be at least 16 years old to purchase tickets.");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Error. Your age must be numeric");
                            txtAge.Text = "";
                            txtPassword.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email address " + CustomerInfo.Email + " already exists. Please use a different e-mail address for this order.");
                    txtEMail.Text = "";
                    txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error. Email must be in correct format");
                txtEMail.Text = "";
                txtPassword.Text = "";
            }            
        }
    }
}
