﻿using System;
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
    public partial class room_Occupied : UserControl
    {
        public room_Occupied()
        {
            InitializeComponent();
        }
        private void tryagain_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void room_Occupied_Load(object sender, EventArgs e)
        {
        }
    }
}
