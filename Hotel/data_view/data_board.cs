﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.data_view
{
    public partial class data_board : UserControl
    {
        function function1 = new function();
        string query;
        public data_board()
        {
            InitializeComponent();
        }

        private void data_board_Load(object sender, EventArgs e)
        {
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BS_01_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void datarefresh()
        {
            query = "SELECT * FROM room";
            DataSet ds = function1.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
    }
}