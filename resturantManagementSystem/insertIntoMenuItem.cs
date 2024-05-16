using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturantManagementSystem
{
    public partial class insertIntoMenuItem : Form
    {
        public insertIntoMenuItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string serverName = "OSAMA-LABTOP"; // enter your server name
            string dataBaseName = "MyDb"; // enter your database name
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string itemID = tbItemID.Text;
            string name = tbName.Text;
            string price = tbPrice.Text;
            string userID = tbUserID.Text;
            string query = "insert into MenuItem (ItemID,[Name],Price,UserID) values ("+itemID+","+name+","+price+","+userID+")";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data has been saved");
        }
    }
}
