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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string serverName = "OSAMA-LABTOP"; // enter your server name
                string dataBaseName = "MyDb"; // enter your database name
                string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string reservationID = tb_delete.Text;
                string query = "DELETE FROM TableReservation\r\nWHERE ReservationID = "+reservationID+"";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("data has been deleted");
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
