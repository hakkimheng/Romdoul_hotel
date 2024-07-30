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
    

    public partial class verify : UserControl
    {
       
        public string room { get; set; }
        private function databaseFunctions = new function();
        public verify()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkin_txt_Click(object sender, EventArgs e)
        {

        }
        public void showdata()
        {
            function func = new function();
            func.ShowDataInLabels(room, fiest_txt, last_txt, room_txt, phone_txt, checkin_txt, checkout_txt);
        }

        private void verify_Load(object sender, EventArgs e)
        {
        }

        private void fiest_txt_Click(object sender, EventArgs e)
        {

        }

        private void F_01_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void payment1_Load(object sender, EventArgs e)
        {

        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment pay = new payment();
            pay.showpayment();
            check_out out1 = new check_out();
        }
    }
}
