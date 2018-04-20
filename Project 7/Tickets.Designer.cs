namespace Project_7
{
    partial class Tickets
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
            this.groupBoxTickets = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.comboBoxUpperDeck = new System.Windows.Forms.ComboBox();
            this.comboBoxClubLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxLowerLevel = new System.Windows.Forms.ComboBox();
            this.lblUpperDeck = new System.Windows.Forms.Label();
            this.lblClubLevel = new System.Windows.Forms.Label();
            this.lblLowerLevel = new System.Windows.Forms.Label();
            this.groupBoxTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTickets
            // 
            this.groupBoxTickets.Controls.Add(this.lblQuantity);
            this.groupBoxTickets.Controls.Add(this.btnBuy);
            this.groupBoxTickets.Controls.Add(this.comboBoxUpperDeck);
            this.groupBoxTickets.Controls.Add(this.comboBoxClubLevel);
            this.groupBoxTickets.Controls.Add(this.comboBoxLowerLevel);
            this.groupBoxTickets.Controls.Add(this.lblUpperDeck);
            this.groupBoxTickets.Controls.Add(this.lblClubLevel);
            this.groupBoxTickets.Controls.Add(this.lblLowerLevel);
            this.groupBoxTickets.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTickets.Name = "groupBoxTickets";
            this.groupBoxTickets.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTickets.Size = new System.Drawing.Size(620, 402);
            this.groupBoxTickets.TabIndex = 4;
            this.groupBoxTickets.TabStop = false;
            this.groupBoxTickets.Text = "Tickets";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(367, 37);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 35);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuy.Location = new System.Drawing.Point(285, 310);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(212, 57);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // comboBoxUpperDeck
            // 
            this.comboBoxUpperDeck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpperDeck.FormattingEnabled = true;
            this.comboBoxUpperDeck.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxUpperDeck.Location = new System.Drawing.Point(336, 233);
            this.comboBoxUpperDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUpperDeck.Name = "comboBoxUpperDeck";
            this.comboBoxUpperDeck.Size = new System.Drawing.Size(160, 24);
            this.comboBoxUpperDeck.TabIndex = 8;
            // 
            // comboBoxClubLevel
            // 
            this.comboBoxClubLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClubLevel.FormattingEnabled = true;
            this.comboBoxClubLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxClubLevel.Location = new System.Drawing.Point(336, 166);
            this.comboBoxClubLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxClubLevel.Name = "comboBoxClubLevel";
            this.comboBoxClubLevel.Size = new System.Drawing.Size(160, 24);
            this.comboBoxClubLevel.TabIndex = 9;
            // 
            // comboBoxLowerLevel
            // 
            this.comboBoxLowerLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLowerLevel.FormattingEnabled = true;
            this.comboBoxLowerLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxLowerLevel.Location = new System.Drawing.Point(336, 102);
            this.comboBoxLowerLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLowerLevel.Name = "comboBoxLowerLevel";
            this.comboBoxLowerLevel.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLowerLevel.TabIndex = 10;
            // 
            // lblUpperDeck
            // 
            this.lblUpperDeck.AutoSize = true;
            this.lblUpperDeck.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperDeck.Location = new System.Drawing.Point(123, 233);
            this.lblUpperDeck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpperDeck.Name = "lblUpperDeck";
            this.lblUpperDeck.Size = new System.Drawing.Size(165, 35);
            this.lblUpperDeck.TabIndex = 5;
            this.lblUpperDeck.Text = "Upper Deck: $50.00";
            // 
            // lblClubLevel
            // 
            this.lblClubLevel.AutoSize = true;
            this.lblClubLevel.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubLevel.Location = new System.Drawing.Point(123, 166);
            this.lblClubLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubLevel.Name = "lblClubLevel";
            this.lblClubLevel.Size = new System.Drawing.Size(155, 35);
            this.lblClubLevel.TabIndex = 6;
            this.lblClubLevel.Text = "Club Level: $75.00";
            // 
            // lblLowerLevel
            // 
            this.lblLowerLevel.AutoSize = true;
            this.lblLowerLevel.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerLevel.Location = new System.Drawing.Point(123, 102);
            this.lblLowerLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowerLevel.Name = "lblLowerLevel";
            this.lblLowerLevel.Size = new System.Drawing.Size(178, 35);
            this.lblLowerLevel.TabIndex = 7;
            this.lblLowerLevel.Text = "Lower Lever: $125.00";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(744, 466);
            this.Controls.Add(this.groupBoxTickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.groupBoxTickets.ResumeLayout(false);
            this.groupBoxTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTickets;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox comboBoxUpperDeck;
        private System.Windows.Forms.ComboBox comboBoxClubLevel;
        private System.Windows.Forms.ComboBox comboBoxLowerLevel;
        private System.Windows.Forms.Label lblUpperDeck;
        private System.Windows.Forms.Label lblClubLevel;
        private System.Windows.Forms.Label lblLowerLevel;
    }
}