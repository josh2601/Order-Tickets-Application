namespace Project_7
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.groupBoxSeatsRemaining = new System.Windows.Forms.GroupBox();
            this.lblUpperDeckText = new System.Windows.Forms.Label();
            this.lblClubLevelText = new System.Windows.Forms.Label();
            this.lblLowerLevelText = new System.Windows.Forms.Label();
            this.lblUpperDeck = new System.Windows.Forms.Label();
            this.lblClubLevel = new System.Windows.Forms.Label();
            this.lblLowerLevel = new System.Windows.Forms.Label();
            this.groupBoxGuestLookup = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtConfirmationNumber = new System.Windows.Forms.TextBox();
            this.lblConfirmationNumber = new System.Windows.Forms.Label();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerLevelSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubLevelSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperDeckSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxSeatsRemaining.SuspendLayout();
            this.groupBoxGuestLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSales.Location = new System.Drawing.Point(30, 27);
            this.lblTotalSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(99, 20);
            this.lblTotalSales.TabIndex = 0;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.Red;
            this.lblSales.Location = new System.Drawing.Point(209, 27);
            this.lblSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(54, 20);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "$0.00";
            // 
            // groupBoxSeatsRemaining
            // 
            this.groupBoxSeatsRemaining.Controls.Add(this.lblUpperDeckText);
            this.groupBoxSeatsRemaining.Controls.Add(this.lblClubLevelText);
            this.groupBoxSeatsRemaining.Controls.Add(this.lblLowerLevelText);
            this.groupBoxSeatsRemaining.Controls.Add(this.lblUpperDeck);
            this.groupBoxSeatsRemaining.Controls.Add(this.lblClubLevel);
            this.groupBoxSeatsRemaining.Controls.Add(this.lblLowerLevel);
            this.groupBoxSeatsRemaining.Location = new System.Drawing.Point(34, 76);
            this.groupBoxSeatsRemaining.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSeatsRemaining.Name = "groupBoxSeatsRemaining";
            this.groupBoxSeatsRemaining.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSeatsRemaining.Size = new System.Drawing.Size(334, 128);
            this.groupBoxSeatsRemaining.TabIndex = 2;
            this.groupBoxSeatsRemaining.TabStop = false;
            this.groupBoxSeatsRemaining.Text = "Seats Remaining";
            // 
            // lblUpperDeckText
            // 
            this.lblUpperDeckText.AutoSize = true;
            this.lblUpperDeckText.Location = new System.Drawing.Point(218, 63);
            this.lblUpperDeckText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpperDeckText.Name = "lblUpperDeckText";
            this.lblUpperDeckText.Size = new System.Drawing.Size(13, 13);
            this.lblUpperDeckText.TabIndex = 1;
            this.lblUpperDeckText.Text = "0";
            // 
            // lblClubLevelText
            // 
            this.lblClubLevelText.AutoSize = true;
            this.lblClubLevelText.Location = new System.Drawing.Point(115, 63);
            this.lblClubLevelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClubLevelText.Name = "lblClubLevelText";
            this.lblClubLevelText.Size = new System.Drawing.Size(13, 13);
            this.lblClubLevelText.TabIndex = 1;
            this.lblClubLevelText.Text = "0";
            // 
            // lblLowerLevelText
            // 
            this.lblLowerLevelText.AutoSize = true;
            this.lblLowerLevelText.Location = new System.Drawing.Point(19, 63);
            this.lblLowerLevelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowerLevelText.Name = "lblLowerLevelText";
            this.lblLowerLevelText.Size = new System.Drawing.Size(13, 13);
            this.lblLowerLevelText.TabIndex = 1;
            this.lblLowerLevelText.Text = "0";
            // 
            // lblUpperDeck
            // 
            this.lblUpperDeck.AutoSize = true;
            this.lblUpperDeck.Location = new System.Drawing.Point(218, 27);
            this.lblUpperDeck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpperDeck.Name = "lblUpperDeck";
            this.lblUpperDeck.Size = new System.Drawing.Size(68, 13);
            this.lblUpperDeck.TabIndex = 0;
            this.lblUpperDeck.Text = "Upper Deck:";
            // 
            // lblClubLevel
            // 
            this.lblClubLevel.AutoSize = true;
            this.lblClubLevel.Location = new System.Drawing.Point(115, 27);
            this.lblClubLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClubLevel.Name = "lblClubLevel";
            this.lblClubLevel.Size = new System.Drawing.Size(60, 13);
            this.lblClubLevel.TabIndex = 0;
            this.lblClubLevel.Text = "Club Level:";
            // 
            // lblLowerLevel
            // 
            this.lblLowerLevel.AutoSize = true;
            this.lblLowerLevel.Location = new System.Drawing.Point(16, 27);
            this.lblLowerLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowerLevel.Name = "lblLowerLevel";
            this.lblLowerLevel.Size = new System.Drawing.Size(68, 13);
            this.lblLowerLevel.TabIndex = 0;
            this.lblLowerLevel.Text = "Lower Level:";
            // 
            // groupBoxGuestLookup
            // 
            this.groupBoxGuestLookup.Controls.Add(this.btnFind);
            this.groupBoxGuestLookup.Controls.Add(this.txtConfirmationNumber);
            this.groupBoxGuestLookup.Controls.Add(this.lblConfirmationNumber);
            this.groupBoxGuestLookup.Location = new System.Drawing.Point(373, 76);
            this.groupBoxGuestLookup.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGuestLookup.Name = "groupBoxGuestLookup";
            this.groupBoxGuestLookup.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGuestLookup.Size = new System.Drawing.Size(232, 128);
            this.groupBoxGuestLookup.TabIndex = 3;
            this.groupBoxGuestLookup.TabStop = false;
            this.groupBoxGuestLookup.Text = "Guest Lookup";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Location = new System.Drawing.Point(86, 63);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 28);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtConfirmationNumber
            // 
            this.txtConfirmationNumber.Location = new System.Drawing.Point(130, 27);
            this.txtConfirmationNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmationNumber.Name = "txtConfirmationNumber";
            this.txtConfirmationNumber.Size = new System.Drawing.Size(76, 20);
            this.txtConfirmationNumber.TabIndex = 1;
            // 
            // lblConfirmationNumber
            // 
            this.lblConfirmationNumber.AutoSize = true;
            this.lblConfirmationNumber.Location = new System.Drawing.Point(16, 27);
            this.lblConfirmationNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmationNumber.Name = "lblConfirmationNumber";
            this.lblConfirmationNumber.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmationNumber.TabIndex = 0;
            this.lblConfirmationNumber.Text = "Confirmation Number:";
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.email,
            this.totalCost,
            this.confirmationNumber,
            this.lowerLevelSeats,
            this.clubLevelSeats,
            this.upperDeckSeats});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(34, 228);
            this.dataGridViewAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(756, 259);
            this.dataGridViewAdmin.TabIndex = 4;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // totalCost
            // 
            this.totalCost.HeaderText = "Total Cost";
            this.totalCost.Name = "totalCost";
            this.totalCost.ReadOnly = true;
            // 
            // confirmationNumber
            // 
            this.confirmationNumber.HeaderText = "Confirmation Number";
            this.confirmationNumber.Name = "confirmationNumber";
            this.confirmationNumber.ReadOnly = true;
            // 
            // lowerLevelSeats
            // 
            this.lowerLevelSeats.HeaderText = "Lower Level Seats";
            this.lowerLevelSeats.Name = "lowerLevelSeats";
            this.lowerLevelSeats.ReadOnly = true;
            // 
            // clubLevelSeats
            // 
            this.clubLevelSeats.HeaderText = "Club Level Seats";
            this.clubLevelSeats.Name = "clubLevelSeats";
            this.clubLevelSeats.ReadOnly = true;
            // 
            // upperDeckSeats
            // 
            this.upperDeckSeats.HeaderText = "Upper Deck Seats";
            this.upperDeckSeats.Name = "upperDeckSeats";
            this.upperDeckSeats.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Location = new System.Drawing.Point(678, 510);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.groupBoxGuestLookup);
            this.Controls.Add(this.groupBoxSeatsRemaining);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblTotalSales);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBoxSeatsRemaining.ResumeLayout(false);
            this.groupBoxSeatsRemaining.PerformLayout();
            this.groupBoxGuestLookup.ResumeLayout(false);
            this.groupBoxGuestLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.GroupBox groupBoxSeatsRemaining;
        private System.Windows.Forms.Label lblUpperDeckText;
        private System.Windows.Forms.Label lblClubLevelText;
        private System.Windows.Forms.Label lblLowerLevelText;
        private System.Windows.Forms.Label lblUpperDeck;
        private System.Windows.Forms.Label lblClubLevel;
        private System.Windows.Forms.Label lblLowerLevel;
        private System.Windows.Forms.GroupBox groupBoxGuestLookup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtConfirmationNumber;
        private System.Windows.Forms.Label lblConfirmationNumber;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerLevelSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubLevelSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperDeckSeats;
        private System.Windows.Forms.Button btnClose;
    }
}