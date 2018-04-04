namespace Doughnut_Factory
{
    partial class AddCustomer
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
            this.name = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.comanyName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.addCustomor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(72, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(72, 90);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(61, 13);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Last Name ";
            // 
            // comanyName
            // 
            this.comanyName.AutoSize = true;
            this.comanyName.Location = new System.Drawing.Point(72, 144);
            this.comanyName.Name = "comanyName";
            this.comanyName.Size = new System.Drawing.Size(82, 13);
            this.comanyName.TabIndex = 0;
            this.comanyName.Text = "Company Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(209, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(209, 141);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // addCustomor
            // 
            this.addCustomor.Location = new System.Drawing.Point(396, 141);
            this.addCustomor.Name = "addCustomor";
            this.addCustomor.Size = new System.Drawing.Size(169, 23);
            this.addCustomor.TabIndex = 2;
            this.addCustomor.Text = "Save";
            this.addCustomor.UseVisualStyleBackColor = true;
            this.addCustomor.Click += new System.EventHandler(this.addCustomor_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCustomor);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comanyName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.name);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label comanyName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button addCustomor;
    }
}