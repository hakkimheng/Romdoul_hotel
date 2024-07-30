using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.room_status
{
    public partial class status_room : UserControl
    {
        function func = new function();
        public status_room()
        {
            InitializeComponent();
        }
        public void roomstatusview()
        {
            bool isRoomS01Free = func.IsRoomFree("S-01");
            if (isRoomS01Free == true)
            {
                panel_S1.BackColor = Color.Maroon;
                label_S1.Text = "OCCUPIED";
                label_S1.Location = new Point(30, 16);
            }
            else
            {
                panel_S1.BackColor = Color.DarkGreen;
                label_S1.Text = "S-01";
                label_S1.Location = new Point(64, 16);

            }
            bool isRoomS02Free = func.IsRoomFree("S-02");
            if (isRoomS02Free == true)
            {
                panel_S2.BackColor = Color.Maroon;
                label_S2.Text = "OCCUPIED";
                label_S2.Location = new Point(30, 16);
            }
            else
            {
                panel_S2.BackColor = Color.DarkGreen;
                label_S2.Text = "S-02";
                label_S2.Location = new Point(64, 16);

            }

            bool isRoomS03Free = func.IsRoomFree("S-03");
            if (isRoomS03Free == true)
            {
                panel_S3.BackColor = Color.Maroon;
                label_S3.Text = "OCCUPIED";
                label_S3.Location = new Point(30, 16);
            }
            else
            {
                panel_S3.BackColor = Color.DarkGreen;
                label_S3.Text = "S-03";
                label_S3.Location = new Point(64, 16);

            }

            bool isRoomS04Free = func.IsRoomFree("S-04");
            if (isRoomS04Free == true)
            {
                panel_S4.BackColor = Color.Maroon;
                label_S4.Text = "OCCUPIED";
                label_S4.Location = new Point(30, 16);
            }
            else
            {
                panel_S4.BackColor = Color.DarkGreen;
                label_S4.Text = "S-04";
                label_S4.Location = new Point(64, 16);

            }

            bool isRoomS05Free = func.IsRoomFree("S-05");
            if (isRoomS05Free == true)
            {
                panel_S5.BackColor = Color.Maroon;
                label_S5.Text = "OCCUPIED";
                label_S5.Location = new Point(30, 16);
            }
            else
            {
                panel_S5.BackColor = Color.DarkGreen;
                label_S5.Text = "S-05";
                label_S5.Location = new Point(64, 16);

            }

            bool isRoomS06Free = func.IsRoomFree("S-06");
            if (isRoomS06Free == true)
            {
                panel_S6.BackColor = Color.Maroon;
                label_S6.Text = "OCCUPIED";
                label_S6.Location = new Point(30, 16);
            }
            else
            {
                panel_S6.BackColor = Color.DarkGreen;
                label_S6.Text = "S-06";
                label_S6.Location = new Point(64, 16);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void status_room_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            f_room1.Visible = true;
            f_room1.family_room_status();
        }

        private void f_room1_Load(object sender, EventArgs e)
        {

        }

        private void panel_S1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void f_room1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
