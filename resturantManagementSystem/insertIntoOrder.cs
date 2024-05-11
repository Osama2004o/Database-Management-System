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
    public partial class insertIntoOrder : Form
    {
        public insertIntoOrder()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string serverName = "OSAMA-LABTOP"; // enter your server name
            string dataBaseName = "MyDb"; // enter your database name
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string orderID = tbOrderId.Text;
            string orderDate = tbOrderDate.Text;
            string userId = tbUserID.Text;
            string orderStatus = tbOrderStatus.Text;
            string price = tbPrice.Text;
            string query = "insert into [Order] (OrderID,OrderDate,UserID,OrderStatus,price) values ("+orderID+","+orderDate+","+userId+","+orderStatus+","+price+")";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data has been saved");
        }
    }
}
