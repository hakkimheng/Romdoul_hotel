using Hotel.CH_in;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.alert
{
    public partial class completed_alert : UserControl
    {
        public completed_alert()
        {
            InitializeComponent();
        }

        private void tryagain_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
