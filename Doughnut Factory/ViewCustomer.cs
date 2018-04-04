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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\Desktop\klientuSaraksts.mdb";
            connection.Open();

            OleDbCommand loadDataCommand = new OleDbCommand();
            loadDataCommand.Connection = connection;

            loadDataCommand.CommandText = "SELECT * FROM costumerList WHERE ID > 0";

            OleDbDataReader readData = loadDataCommand.ExecuteReader();

            while (readData.Read())
            {
                ListViewItem clientRecord = new ListViewItem(readData[2].ToString());
                clientRecord.SubItems.Add(readData[2].ToString());
                clientRecord.SubItems.Add(readData[3].ToString());

                listViewCosutmer.Items.Add(clientRecord);

            }

            connection.Close();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }
    }
}
