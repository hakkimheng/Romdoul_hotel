using Hotel.alert;
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

namespace Hotel.CH_in
{
    public partial class room_choose : UserControl
    {
        private room_Occupied room_Occupied1;

        public string roomName = "Select Room";
        function func = new function();

        public room_choose()
        {
            InitializeComponent();
            room_choose_status();
        }
        public void room_choose_status()
        {
            bool isRoomS01Free = func.IsRoomFree("S-01");
            BS_01.Visible = isRoomS01Free;
            s_01.Visible = !isRoomS01Free;
            bool isRoomS02Free = func.IsRoomFree("S-02");
            BS_02.Visible = isRoomS02Free;
            bool isRoomS03Free = func.IsRoomFree("S-03");
            BS_03.Visible = isRoomS03Free;
            bool isRoomS04Free = func.IsRoomFree("S-04");
            BS_04.Visible = isRoomS04Free;
            bool isRoomS05Free = func.IsRoomFree("S-05");
            BS_05.Visible = isRoomS05Free;
            bool isRoomS06Free = func.IsRoomFree("S-06");
            BS_06.Visible = isRoomS06Free;
            bool isRoomf01Free = func.IsRoomFree("F-01");
            BF_01.Visible = isRoomf01Free;
            bool isRoomf02Free = func.IsRoomFree("F-02");
            BF_02.Visible = isRoomf02Free;
            bool isRoomf03Free = func.IsRoomFree("F-03");
            BF_03.Visible = isRoomf03Free;
            bool isRoomf04Free = func.IsRoomFree("F-04");
            BF_04.Visible = isRoomf04Free;
            bool isRoomf05Free = func.IsRoomFree("F-05");
            BF_05.Visible = isRoomf05Free;
            bool isRoomf06Free = func.IsRoomFree("F-06");
            BF_06.Visible = isRoomf06Free;
        }
        private void family1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }
        public room_choose(string roomName)
        {
            this.roomName = roomName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_01_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "F-01";
        }

        private void F_02_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "F-02";
        }

        private void F_03_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "F-03";
        }

        private void F_04_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "F-04";
        }

        private void F_05_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "F-05";
        }

        private void F_06_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "F-06";
        }

        private void S_05_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "S-05";
        }

        private void S_06_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "S-06";
        }

        private void S_04_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "S-04";
        }

        private void S_03_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "S-03";
        }

        private void S_02_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "S-02";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "S-01";
        }

        private void room_choose_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_2(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BS_01_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BS_03_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BS_05_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BS_06_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BF_01_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BF_02_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BF_03_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BF_06_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void BF_05_Click(object sender, EventArgs e)
        {
            room_Occupied2.Visible = true;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomName = "Select Room";
        }
    }
}
