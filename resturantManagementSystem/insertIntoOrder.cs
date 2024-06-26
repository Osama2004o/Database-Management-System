﻿using System;
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO [Order] (OrderID, OrderDate, UserID, OrderStatus, price) VALUES (@OrderID, @OrderDate, @UserID, @OrderStatus, @Price)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", tbOrderId.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Parse(tbOrderDate.Text));
                    cmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
                    cmd.Parameters.AddWithValue("@OrderStatus", tbOrderStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(tbPrice.Text));

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been saved");
        }
    }
}
