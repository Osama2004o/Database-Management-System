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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_user user = new update_user();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_reservation reservation = new update_reservation();
            reservation.Show();
        }
    }
}
