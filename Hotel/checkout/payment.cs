using Hotel.CH_in;
using Hotel.room_status;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.checkout
{
    public partial class payment : UserControl
    {
        public string room { get; set; }
        public string phone { get; set; }

        public payment()
        {
            InitializeComponent();

        }


        private void payment_Load(object sender, EventArgs e)
        {
            check_out out1 = new check_out();
            showpayment();

        }
        public void showpayment()
        {
            if (room == "S-01" || room == "S-02" || room == "S-03" || room == "S-04" || room == "S-05" || room == "S-06")
            {
                roomshow_txt.Text = room;
                tax_txt.Text = "2.00$";
                price_txt.Text = "20.00$";
                totel_txt.Text = "22.00$";
            }
            else
            {
                roomshow_txt.Text = room;
                tax_txt.Text = "4.00$";
                price_txt.Text = "40.00$";
                totel_txt.Text = "44.00$";
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            function func = new function();
            func.CheckOut(room, phone);
            status_room status_Room = new status_room();
            status_Room.roomstatusview();
            room_choose room_Choose = new room_choose();
            room_Choose.room_choose_status();
            this.Hide();
        }

        private void completed_alert1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;
            panel2.Visible = false; 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            panel2.Visible = false;
        }
    }
}
