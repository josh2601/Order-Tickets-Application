namespace Project_7
{
    partial class Account_Creation
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.Window;
            this.lblAge.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(57, 107);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 35);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEMail.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMail.Location = new System.Drawing.Point(57, 172);
            this.lblEMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(63, 35);
            this.lblEMail.TabIndex = 0;
            this.lblEMail.Text = "E-Mail:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lblPassword.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(57, 246);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 35);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(161, 120);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(233, 22);
            this.txtAge.TabIndex = 1;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(161, 185);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(233, 22);
            this.txtEMail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 259);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Location = new System.Drawing.Point(205, 308);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(151, 50);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Account_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(767, 505);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Account_Creation";
            this.Text = "Account Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreate;
    }
}