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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
            NumberOfRemainingTickets();
            NotEnoughTicketsCheck();
            SetComboBoxes();
        }

        private void SetComboBoxes()
        {
            //set all combo boxes to 0 on form load to avoid errors
            comboBoxLowerLevel.SelectedIndex = 0;
            comboBoxClubLevel.SelectedIndex = 0;
            comboBoxUpperDeck.SelectedIndex = 0;
        }

        private void NumberOfRemainingTickets()
        {
            //reset counter if user comes back to this form
            Total_Tickets.LowerLevelTickets = 0;
            Total_Tickets.ClubLevelTickets = 0;
            Total_Tickets.UpperDeckTickets = 0;

            string[] customerData = File.ReadAllLines("Customer Data.txt");

            foreach (string data in customerData)
            {
                var splitInfo = data.Split(',');
                int lowerLevel = int.Parse(splitInfo[8]);
                int clubLevel = int.Parse(splitInfo[9]);
                int upperDeck = int.Parse(splitInfo[10]);
                                
                Total_Tickets.LowerLevelTickets += lowerLevel;
                Total_Tickets.ClubLevelTickets += clubLevel;
                Total_Tickets.UpperDeckTickets += upperDeck;
            }
        }

        private void NotEnoughTicketsCheck()
        {
            if (Total_Tickets.LowerLevelTickets >= 200)
            {
                lblLowerLevel.Text = "Sold Out";
                lblLowerLevel.ForeColor = Color.Red;
                comboBoxLowerLevel.Hide();
            }

            if (Total_Tickets.ClubLevelTickets >= 75)
            {
                lblClubLevel.Text = "Sold Out";
                lblClubLevel.ForeColor = Color.Red;
                comboBoxClubLevel.Hide();
            }

            if (Total_Tickets.UpperDeckTickets >= 200)
            {
                lblUpperDeck.Text = "Sold Out";
                lblUpperDeck.ForeColor = Color.Red;
                comboBoxUpperDeck.Hide();
            }
        }

        private bool PurchaseTooManyTickets()
        {
            if (CustomerInfo.LowerLevel > 200 - Total_Tickets.LowerLevelTickets)
            {
                return true;
            }
            else if (CustomerInfo.ClubLevel > 75 - Total_Tickets.ClubLevelTickets)
            {
                return true;
            }
            else if (CustomerInfo.UpperDeck > 200 - Total_Tickets.UpperDeckTickets)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
               
        private void btnBuy_Click(object sender, EventArgs e)
        {
                CustomerInfo.LowerLevel = int.Parse(comboBoxLowerLevel.Text);
                CustomerInfo.ClubLevel = int.Parse(comboBoxClubLevel.Text);
                CustomerInfo.UpperDeck = int.Parse(comboBoxUpperDeck.Text);

                PurchaseTooManyTickets();

                if (PurchaseTooManyTickets() == false)
                {
                    CustomerInfo.TotalCost = (CustomerInfo.LowerLevel * 125) + (CustomerInfo.ClubLevel * 75) + (CustomerInfo.UpperDeck * 50);

                    Purchase purchase = new Purchase();
                    purchase.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (CustomerInfo.LowerLevel > 200 - Total_Tickets.LowerLevelTickets)
                    {
                        int lowerLevelTickets = 200 - Total_Tickets.LowerLevelTickets;
                        MessageBox.Show("Only " + lowerLevelTickets.ToString() + " Lower Level ticket(s) remaining. Please reduce the number of tickets.");
                        comboBoxLowerLevel.SelectedIndex = 0;                        
                    }
                    if (CustomerInfo.ClubLevel > 75 - Total_Tickets.ClubLevelTickets)
                    {
                        int clubLevelTickets = 75 - Total_Tickets.ClubLevelTickets;
                        MessageBox.Show("Only " + clubLevelTickets.ToString() + " Club Level ticket(s) remaining. Please reduce the number of tickets.");
                        comboBoxClubLevel.SelectedIndex = 0;
                    }
                    if (CustomerInfo.UpperDeck > 200 - Total_Tickets.UpperDeckTickets)
                    {
                        int upperDeckTickets = 200 - Total_Tickets.UpperDeckTickets;
                        MessageBox.Show("Only " + upperDeckTickets.ToString() + " Upper Deck ticket(s) remaining. Please reduce the number of tickets.");
                        comboBoxUpperDeck.SelectedIndex = 0;
                    }
                }            
        }
    }
}
