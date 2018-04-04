namespace Doughnut_Factory
{
    partial class ViewCustomer
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
            this.listViewCosutmer = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCosutmer
            // 
            this.listViewCosutmer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmLastName,
            this.clmCompanyName});
            this.listViewCosutmer.Location = new System.Drawing.Point(64, 60);
            this.listViewCosutmer.Name = "listViewCosutmer";
            this.listViewCosutmer.Size = new System.Drawing.Size(667, 345);
            this.listViewCosutmer.TabIndex = 0;
            this.listViewCosutmer.UseCompatibleStateImageBehavior = false;
            this.listViewCosutmer.View = System.Windows.Forms.View.Details;
            this.listViewCosutmer.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.Text = "Company Name";
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(64, 23);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(26, 13);
            this.listLabel.TabIndex = 1;
            this.listLabel.Text = "List:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(669, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.listViewCosutmer);
            this.Name = "ViewCustomer";
            this.Text = "ViewCustomer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCosutmer;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmCompanyName;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Button backButton;
    }
}