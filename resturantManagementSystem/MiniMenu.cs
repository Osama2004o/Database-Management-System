using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturantManagementSystem
{
    public partial class MiniMenu : Form
    {
        public MiniMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void MiniMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_Data show_Data = new show_Data();
            show_Data.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number_of__orders_per_date opd = new Number_of__orders_per_date();
            opd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void whatToDo_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }
    }
}
