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
    public partial class update_user : Form
    {
        public update_user()
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

                string userID = tbUserId.Text;
                string email = tbEmail.Text;
                string fname = tbFname.Text;

                string query = @"UPDATE [User]
                     SET Email = @Email, Fname = @Fname
                     WHERE UserID = @UserID;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Fname", fname);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been updated");
        }
    }
}
