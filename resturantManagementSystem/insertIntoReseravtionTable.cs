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
    public partial class insertIntoReseravtionTable : Form
    {
        public insertIntoReseravtionTable()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string serverName = "OSAMA-LABTOP"; // enter your server name
            string dataBaseName = "MyDb"; // enter your database name
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string reservationID = tbReservationID.Text;
                string userID = tbUserID.Text;
                string reservationDate = tbReservationDate.Text;
                string status = tbStatus.Text;
                string peopleNo = tbPeopleNo.Text;

                string query = @"INSERT INTO TableReservation (ReservationID, UserID, ReservationDate, [status], peopleno) 
                     VALUES (@reservationID, @userID, @reservationDate, @status, @peopleNo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reservationID", reservationID);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@reservationDate", DateTime.Parse(reservationDate));
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@peopleNo", int.Parse(peopleNo));

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been saved");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
