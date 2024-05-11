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
            string connectionString = "Data Source="+serverName+";Initial Catalog="+dataBaseName+";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string userid = tbUserId.Text;
            string email = tbEmail.Text;
            string role = tbRole.Text;
            string fname = tbFname.Text;
            string lname = tbLname.Text;
            string password = tbPassword.Text;
            string username = tbUserName.Text;
            string phone = tbPhone.Text;
            string query = "insert into [User] (UserID, Email, [Role],Fname,Lname,[password],UserName,phone) values (" + userid + "," + email + "," + role + "," + fname + "," + lname + "," + password + "," + username + "," + phone + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data has been saved");
        }
    }
}
