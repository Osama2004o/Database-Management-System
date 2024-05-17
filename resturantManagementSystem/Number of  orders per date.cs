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
    public partial class Number_of__orders_per_date : Form
    {
        public Number_of__orders_per_date()
        {
            InitializeComponent();
        }

        private void Number_of__orders_per_date_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = "OSAMA-LABTOP"; // enter your server name
            string dataBaseName = "MyDb"; // enter your database name
            string connectionString = $"Data Source={serverName};Initial Catalog={dataBaseName};Integrated Security=True";

            string fromDate = tbFrom.Text;
            string toDate = tbTo.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    OrderDate AS order_date,
                    COUNT(OrderID) AS total_orders
                FROM 
                    [Order]
                WHERE 
                    OrderDate BETWEEN @fromDate AND @toDate 
                GROUP BY 
                    OrderDate";

                SqlDataAdapter sqlda = new SqlDataAdapter(query, conn);
                sqlda.SelectCommand.Parameters.AddWithValue("@fromDate", fromDate);
                sqlda.SelectCommand.Parameters.AddWithValue("@toDate", toDate);

                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dgView.DataSource = dtbl;
            }
        }
    }
}
