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
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string reservationID = tbReservationID.Text;
            string userID = tbUserID.Text;
            string reservationDate = tbReservationDate.Text;
            string status = tbStatus.Text;
            string peopleNo = tbPeopleNo.Text;
            string query = "insert into TableReservation(ReservationID,UserID,ReservationDate,[status],peopleno) values ("+reservationID+","+userID+","+reservationDate+","+status+","+peopleNo+")";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data has been saved");
        }
    }
}
