namespace Project_7
{
    partial class Purchase
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
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.lblCsv = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.txtCsv = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCost.Location = new System.Drawing.Point(248, 18);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(83, 29);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(51, 67);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(145, 29);
            this.lblCreditCardNumber.TabIndex = 1;
            this.lblCreditCardNumber.Text = "Credit Card Number:";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnCard.Location = new System.Drawing.Point(87, 114);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(106, 29);
            this.lblNameOnCard.TabIndex = 1;
            this.lblNameOnCard.Text = "Name on Card:";
            // 
            // lblCsv
            // 
            this.lblCsv.AutoSize = true;
            this.lblCsv.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsv.Location = new System.Drawing.Point(146, 157);
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Size = new System.Drawing.Size(40, 29);
            this.lblCsv.TabIndex = 1;
            this.lblCsv.Text = "CSV:";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(198, 78);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(211, 20);
            this.txtCreditCardNumber.TabIndex = 0;
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(198, 124);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(211, 20);
            this.txtNameOnCard.TabIndex = 1;
            // 
            // txtCsv
            // 
            this.txtCsv.Location = new System.Drawing.Point(198, 167);
            this.txtCsv.Name = "txtCsv";
            this.txtCsv.Size = new System.Drawing.Size(211, 20);
            this.txtCsv.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(252, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 51);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(577, 354);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCsv);
            this.Controls.Add(this.txtNameOnCard);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.lblCsv);
            this.Controls.Add(this.lblNameOnCard);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.lblTotalCost);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.TextBox txtCsv;
        private System.Windows.Forms.Button btnSubmit;
    }
}