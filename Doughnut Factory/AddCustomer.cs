using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doughnut_Factory
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void addCustomor_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String lastName = txtLastName.Text;
            String companyName = txtCompanyName.Text;

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\Desktop\klientuSaraksts.mdb";
            connection.Open();

            OleDbCommand saveDataCommand = new OleDbCommand();
            saveDataCommand.Connection = connection;

            saveDataCommand.CommandText = "INSERT INTO costumerList (name, lastName, companyName) VALUES (@name, @lastName, @companyName)";
            saveDataCommand.Parameters.AddWithValue("@name", OleDbType.Char).Value = name;
            saveDataCommand.Parameters.AddWithValue("@lastName", OleDbType.Char).Value = lastName;
            saveDataCommand.Parameters.AddWithValue("@companyName", OleDbType.Char).Value = companyName;

            saveDataCommand.ExecuteNonQuery();
            MessageBox.Show("Saved");

            connection.Close();


            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.Show();
            
        }
    }
}
