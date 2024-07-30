using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.room_status
{
    public partial class F_room : UserControl
    {
        function func = new function();
        public F_room()
        {
            InitializeComponent();
            family_room_status();
        }
        public void family_room_status()
        {
            bool isRoomS01Free = func.IsRoomFree("F-01");
            if (isRoomS01Free == true)
            {
                panel_F1.BackColor = Color.Maroon;
                label_F1.Text = "OCCUPIED";
                label_F1.Location = new Point(30, 16);
            }
            else
            {
                panel_F3.BackColor = Color.DarkGreen;
                label_F3.Text = "F-01";
                label_F3.Location = new Point(64, 16);

            }
            bool isRoomS02Free = func.IsRoomFree("F-02");
            if (isRoomS02Free == true)
            {
                panel_F2.BackColor = Color.Maroon;
                label_F2.Text = "OCCUPIED";
                label_F2.Location = new Point(30, 16);
            }
            else
            {
                panel_F3.BackColor = Color.DarkGreen;
                label_F3.Text = "F-02";
                label_F3.Location = new Point(64, 16);

            }

            bool isRoomS03Free = func.IsRoomFree("F-03");
            if (isRoomS03Free == true)
            {
                panel_F3.BackColor = Color.Maroon;
                label_F3.Text = "OCCUPIED";
                label_F3.Location = new Point(30, 16);
            }
            else
            {
                panel_F3.BackColor = Color.DarkGreen;
                label_F3.Text = "F-03";
                label_F3.Location = new Point(64, 16);

            }

            bool isRoomS04Free = func.IsRoomFree("F-04");
            if (isRoomS04Free == true)
            {
                panel_F4.BackColor = Color.Maroon;
                label_F4.Text = "OCCUPIED";
                label_F4.Location = new Point(30, 16);
            }
            else
            {
                panel_F3.BackColor = Color.DarkGreen;
                label_F3.Text = "F-04";
                label_F3.Location = new Point(64, 16);

            }

            bool isRoomS05Free = func.IsRoomFree("F-05");
            if (isRoomS05Free == true)
            {
                panel_F5.BackColor = Color.Maroon;
                label_F5.Text = "OCCUPIED";
                label_F5.Location = new Point(30, 16);
            }
            else
            {
                panel_F3.BackColor = Color.DarkGreen;
                label_F3.Text = "F-05";
                label_F3.Location = new Point(64, 16);

            }

            bool isRoomS06Free = func.IsRoomFree("F-06");
            if (isRoomS06Free == true)
            {
                panel_F6.BackColor = Color.Maroon;
                label_F6.Text = "OCCUPIED";
                label_F6.Location = new Point(30, 16);
            }
            else
            {
                panel_F3.BackColor = Color.DarkGreen;
                label_F3.Text = "F-06";
                label_F3.Location = new Point(64, 16);

            }
        }

        private void F_room_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void status_room1_Load(object sender, EventArgs e)
        {

        }

        private void panel_F1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
