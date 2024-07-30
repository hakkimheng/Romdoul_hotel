using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.CH_in;

namespace Hotel
{
    public partial class checkin : Form
    {
        public checkin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Romdoul form1 = new Romdoul();
            form1.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            status_room1.Visible = false;
            check_out1.Visible = false;
            data_board1.Visible = false;
            checkin_form1.Show();
            checkin_form1.clearAll();

        }

        private void next_in_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            status_room1.Visible = true;
            check_out1.Visible = false;
            checkin_form1.Visible = false;
            data_board1.Visible = false;
            status_room1.roomstatusview();
            


        }

        private void checkin_Load(object sender, EventArgs e)
        {
            btn_checkin1.PerformClick();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            check_out1.Visible = true;
            checkin_form1.Visible = false;
            status_room1.Visible = false;
            data_board1.Visible = false;

        }

        private void check_out1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            data_board1.Visible = true;
            checkin_form1.Visible = false;
            check_out1.Visible = false;
            status_room1.Visible = false;
            data_board1.datarefresh();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkin_form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
