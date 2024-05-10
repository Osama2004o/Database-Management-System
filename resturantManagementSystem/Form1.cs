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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OSAMA-LABTOP;Initial Catalog=MyDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string firstName = label1.Text;
            string secondName = label2.Text;
            string age = label3.Text;
            string query = "insert into person values ('" + firstName + "','" + secondName + "'," + age + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data has been saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
