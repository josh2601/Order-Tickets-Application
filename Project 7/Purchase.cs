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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
            ChangeTotalCostLabel();
        }

        private void ChangeTotalCostLabel()
        {
            lblTotalCost.Text = "Total Cost:" + CustomerInfo.TotalCost.ToString("C2");
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {     
                CreditCardNumberError();

                if (CreditCardNumberError() == false)
                {
                    CsvError();

                    if (CsvError() == false)
                    {
                        CustomerInfo.NameOnCard = txtNameOnCard.Text;

                        if (MessageBox.Show("Can't wait to see you " + CustomerInfo.Name + "!" + Environment.NewLine
                            + "Summary:" + Environment.NewLine
                            + "Amount to be charged: $" + CustomerInfo.TotalCost + Environment.NewLine
                            + "Contact e-mail: " + CustomerInfo.Email + Environment.NewLine
                            + Environment.NewLine
                            + "Please click YES below to confirm your order",
                            "exit", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Random rnd = new Random();
                            CustomerInfo.ConfirmationNumber = rnd.Next(0, 9999);

                            string[] purchaseInfo = new string[11];
                            purchaseInfo[0] = CustomerInfo.Name;
                            purchaseInfo[1] = CustomerInfo.Age.ToString();
                            purchaseInfo[2] = CustomerInfo.Email;
                            purchaseInfo[3] = txtCreditCardNumber.Text;
                            purchaseInfo[4] = CustomerInfo.NameOnCard;
                            purchaseInfo[5] = txtCsv.Text;
                            purchaseInfo[6] = CustomerInfo.ConfirmationNumber.ToString();
                            purchaseInfo[7] = CustomerInfo.TotalCost.ToString();
                            purchaseInfo[8] = CustomerInfo.LowerLevel.ToString();
                            purchaseInfo[9] = CustomerInfo.ClubLevel.ToString();
                            purchaseInfo[10] = CustomerInfo.UpperDeck.ToString();

                            string purchaseRecord = string.Join(",", purchaseInfo);

                            File.AppendAllText("Customer Data.txt", purchaseRecord + Environment.NewLine);

                            //From here on Total_Tickets does not include newly purchased tickets

                            MessageBox.Show("Congrats!" + Environment.NewLine + "Your confirmation number is: " + CustomerInfo.ConfirmationNumber);

                            this.Close();
                        }
                        else if (MessageBox.Show("Can't wait to see you " + CustomerInfo.Name + "!" + Environment.NewLine
                            + "Summary:" + Environment.NewLine
                            + "Amount to be charged: $" + CustomerInfo.TotalCost + Environment.NewLine
                            + "Contact e-mail: " + CustomerInfo.Email + Environment.NewLine
                            + Environment.NewLine
                            + "Please click YES below to confirm your order",
                            "exit", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.No)
                        {
                            Tickets tickets = new Tickets();
                            tickets.ShowDialog();
                            this.Close();
                        }
                        else if (MessageBox.Show("Can't wait to see you " + CustomerInfo.Name + "!" + Environment.NewLine
                            + "Summary:" + Environment.NewLine
                            + "Amount to be charged: $" + CustomerInfo.TotalCost + Environment.NewLine
                            + "Contact e-mail: " + CustomerInfo.Email + Environment.NewLine
                            + Environment.NewLine
                            + "Please click YES below to confirm your order",
                            "exit", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        try
                        {
                            int csv = int.Parse(txtCsv.Text);

                            if (txtCsv.Text.Length != 3)
                            {
                                MessageBox.Show("Error. Csv must be 3 digits.");
                                txtCsv.Text = "";
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error. Csv must be numeric.");
                            txtCsv.Text = "";
                        }
                    }
                }
                else
                {
                    try
                    {
                        double creditcardnumber = double.Parse(txtCreditCardNumber.Text);

                        if (txtCreditCardNumber.Text.Length != 16)
                        {
                            MessageBox.Show("Error. Credit card number must be 16 digits.");
                            txtCreditCardNumber.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error. Credit Card must be numeric.");
                        txtCreditCardNumber.Text = "";
                    }
                }
        }

        private bool CreditCardNumberError()
        {
            try
            {
                double creditcardnumber = double.Parse(txtCreditCardNumber.Text);
                
                if (txtCreditCardNumber.Text.Length != 16)
                {
                    return true;                    
                }
                return false;
            }
            catch
            {
                return true;
            }
        }

        private bool CsvError()
        {
            try
            {
                int csv = int.Parse(txtCsv.Text);
                
                if (txtCsv.Text.Length != 3)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
