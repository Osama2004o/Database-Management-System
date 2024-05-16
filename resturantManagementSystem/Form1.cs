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
            insertIntoOrder user = new insertIntoOrder();
            user.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertIntoUser user = new insertIntoUser();
            user.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            insertIntoMenuItem item = new insertIntoMenuItem();
            item.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertIntoReseravtionTable table = new insertIntoReseravtionTable();
            table.Show();
        }
    }
}
