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
    public partial class show_Data : Form
    {
        public show_Data()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = cbTables.Text;
        }

        private void show_Data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = "OSAMA-LABTOP"; // enter your server name
            string dataBaseName = "MyDb"; // enter your database name
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            using (SqlConnection conn2 = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select * from "+lblValue.Text+"";
                SqlDataAdapter sqlda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dgView.DataSource = dtbl;
            }
            conn.Close();
        }
    }
}
