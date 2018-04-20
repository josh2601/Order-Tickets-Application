namespace Project_7
{
    partial class getTickets
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
            this.btnGetTickets = new System.Windows.Forms.Button();
            this.lblBandName = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetTickets
            // 
            this.btnGetTickets.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetTickets.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTickets.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetTickets.Location = new System.Drawing.Point(201, 337);
            this.btnGetTickets.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetTickets.Name = "btnGetTickets";
            this.btnGetTickets.Size = new System.Drawing.Size(256, 84);
            this.btnGetTickets.TabIndex = 0;
            this.btnGetTickets.Text = "Get Tickets";
            this.btnGetTickets.UseVisualStyleBackColor = false;
            this.btnGetTickets.Click += new System.EventHandler(this.btnGetTickets_Click);
            // 
            // lblBandName
            // 
            this.lblBandName.AutoSize = true;
            this.lblBandName.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandName.Location = new System.Drawing.Point(86, 123);
            this.lblBandName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBandName.Name = "lblBandName";
            this.lblBandName.Size = new System.Drawing.Size(474, 85);
            this.lblBandName.TabIndex = 1;
            this.lblBandName.Text = "The Unending Beginning";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(17, 16);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(46, 17);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // getTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(673, 492);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblBandName);
            this.Controls.Add(this.btnGetTickets);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "getTickets";
            this.Text = "Get Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTickets;
        private System.Windows.Forms.Label lblBandName;
        private System.Windows.Forms.Label lblAdmin;
    }
}

