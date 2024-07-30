using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.alert;
using Hotel.room_status;
using static Hotel.CH_in.room_choose;

namespace Hotel.CH_in
{

    public partial class checkin_form : UserControl
    {
        
        private string roomName;
        public checkin_form()
        {
            InitializeComponent();
        }

        private void next_in_Click(object sender, EventArgs e)
        {
            if (txt_firstname.Text != "" && lastname_txt.Text != "" && txt_phonenumber.Text != "" && txt_datein.Text != "")
            {

                string status = "OCCUPIED";
                string roomname = room_choose1.roomName;
                string lastname = lastname_txt.Text;
                string firstname = txt_firstname.Text;
                string phonenumber = txt_phonenumber.Text;
                DateTime datein = DateTime.Parse(txt_datein.Text);
                DateTime dateout = DateTime.Parse(txt_dateout.Text);

                string query = "INSERT INTO Room (\"First Name\", \"Last Name\", \"Phone\", \"Room\", \"Check In\", \"Check Out\", \"status\") values ('" + firstname + "','" + lastname + "','" + phonenumber + "','" + roomname + "','" + datein + "','" + dateout + "','" + status + "')";
                function function1 = new function();
                function1.setData(query);
                clearAll();
                completed_alert1.Visible = true;
                room_choose1.room_choose_status();
                status_room status_Room = new status_room();
                status_Room.roomstatusview();
            }
            else
            {
                error_alert1.Visible = true;
                clearAll();
            }
        }
        public void clearAll()
        {
            button1.Text = "Select Room";
            txt_firstname.Clear();
            lastname_txt.Clear();
            txt_phonenumber.Clear();
        }

        private void room_choose1_Load(object sender, EventArgs e)
        {

        }

        private void txt_phonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void txt_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }
        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkin_form_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            room_choose1.Visible = true;
            room_choose1.room_choose_status();

        }

        private void bg_Paint(object sender, PaintEventArgs e)
        {
            button1.Text = room_choose1.roomName;

        }

        private void room_choose1_Load_1(object sender, EventArgs e)
        {

        }

        private void completed_alert1_Load(object sender, EventArgs e)
        {

        }
    }
}
