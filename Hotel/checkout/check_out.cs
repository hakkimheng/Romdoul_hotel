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

namespace Hotel.checkout
{
    public partial class check_out : UserControl
    {
        public check_out()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void check_out_Load(object sender, EventArgs e)
        {
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            function databaseFunctions = new function();
            string compareRoom = check_room.Text;
            string comparePhone = checkpn.Text;
            verify1.room = compareRoom;
            payment1.phone = comparePhone;
            payment1.room = compareRoom;

            bool isEqual = databaseFunctions.ComparePhoneAndRoom(compareRoom, comparePhone);
            if (isEqual)
            {
               
                verify1.Visible = true;
                payment1.Visible = true;
                checkout_success1.Visible = true;
                verify1.showdata();
                checkpn.Clear();
                check_room.Clear();
            }
            else
            {
                verify1.Visible = false;
                error_alert1.Visible = true;
                checkpn.Clear();
                check_room.Clear();

            }
        }

        private void checkpn_TextChanged(object sender, EventArgs e)
        {

        }

        private void verify1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void next_01_Click(object sender, EventArgs e)
        {
            this.Hide();
            verify1.Hide();
            payment1.Visible = true;
        }

        private void payment1_Load(object sender, EventArgs e)
        {

        }
    }

}
