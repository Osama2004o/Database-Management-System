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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace resturantManagementSystem
{
    public partial class update_reservation : Form
    {
        public update_reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = "OSAMA-LABTOP"; // enter your server name
            string dataBaseName = "MyDb"; // enter your database name
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string reservationID = tbReservationId.Text;
                string reservationDate = tbReservationDate.Text;
                string status = tbSatus.Text;

                string query = @"UPDATE TableReservation
                     SET ReservationDate = @reservationDate, [status] = @status
                     WHERE ReservationID = @reservationID;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reservationID", reservationID);
                    cmd.Parameters.AddWithValue("@reservationDate", DateTime.Parse(reservationDate));
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been updated");
        }
    }
}
