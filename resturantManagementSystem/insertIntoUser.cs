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
    public partial class insertIntoUser : Form
    {
        public insertIntoUser()
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

                string userid = tbUserId.Text;
                string email = tbEmail.Text;
                string role = tbRole.Text;
                string fname = tbFname.Text;
                string lname = tbLname.Text;
                string password = tbPassword.Text;
                string username = tbUserName.Text;
                string phone = tbPhone.Text;

                string query = "INSERT INTO [User] (UserID, Email, [Role], Fname, Lname, [Password], UserName, Phone) " +
                               "VALUES (@userid, @Email, @Role, @Fname, @Lname, @Password, @UserName, @Phone)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Fname", fname);
                    cmd.Parameters.AddWithValue("@Lname", lname);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data has been saved");
        }
    }
}
