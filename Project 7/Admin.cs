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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadDataGrid();
            RemainingTickets();
        }

        private void RemainingTickets()
        {
            string[] customerInfo = File.ReadAllLines("Customer Data.txt");
            foreach (string data in customerInfo)
            {
                var splitInfo = data.Split(',');
                int lowerLevel = int.Parse(splitInfo[8]);
                int clubLevel = int.Parse(splitInfo[9]);
                int upperDeck = int.Parse(splitInfo[10]);

                Admin_Total_Tickets.LowerLevelTickets += lowerLevel;
                Admin_Total_Tickets.ClubLevelTickets += clubLevel;
                Admin_Total_Tickets.UpperDeckTickets += upperDeck;
            }

            int lowerLevelRemaining = 200 - Admin_Total_Tickets.LowerLevelTickets;
            int clubLevelRemaining = 75 - Admin_Total_Tickets.ClubLevelTickets;
            int upperDeckRemaining = 200 - Admin_Total_Tickets.UpperDeckTickets;

            int totalSales = (Admin_Total_Tickets.LowerLevelTickets * 125) + (Admin_Total_Tickets.ClubLevelTickets * 75) + (Admin_Total_Tickets.UpperDeckTickets * 50);

            lblLowerLevelText.Text = lowerLevelRemaining.ToString();
            lblClubLevelText.Text = clubLevelRemaining.ToString();
            lblUpperDeckText.Text = upperDeckRemaining.ToString();
            lblSales.Text = totalSales.ToString("C2");
        }
        private void LoadDataGrid()
        {
            string[] customerInfo = File.ReadAllLines("Customer Data.txt");
            foreach (string data in customerInfo)
            {
                var splitInfo = data.Split(',');

                string customer = splitInfo[0];
                string email = splitInfo[2];
                string totalCost = splitInfo[7];
                string confimationNumber = splitInfo[6];
                string lowerLevelSeats = splitInfo[8];
                string clubLevelSeats = splitInfo[9];
                string upperDeckSeats = splitInfo[10];

                dataGridViewAdmin.Rows.Add(customer, email, totalCost, confimationNumber, lowerLevelSeats, clubLevelSeats, upperDeckSeats);
            }
        }

        private bool SearchMethod()
        {
            string searchValue = txtConfirmationNumber.Text;
            
            foreach (DataGridViewRow row in dataGridViewAdmin.Rows)
            {
                if (row.Cells[3].Value.ToString().Equals(searchValue))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridViewAdmin.ClearSelection();
            SearchMethod();

            if (SearchMethod() == false)
            {
                MessageBox.Show("Confirmation number not found.");
            }
            else
            {
                string searchValue = txtConfirmationNumber.Text;
                int rowIndex = -1;

                foreach (DataGridViewRow row in dataGridViewAdmin.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridViewAdmin.Rows[rowIndex].Selected = true;
                        MessageBox.Show("Found confirmation number: " + txtConfirmationNumber.Text + Environment.NewLine
                            + "Name: " + row.Cells[0].Value.ToString() + Environment.NewLine
                            + "Total charge: $" + row.Cells[2].Value.ToString());
                    }
                }
            }
        }
    }
}
