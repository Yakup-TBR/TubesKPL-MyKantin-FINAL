﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKantin
{
    public partial class Detail_Makanan : Form
    {
        public Detail_Makanan()
        {
            InitializeComponent();
        }

        private void Detail_Makanan_Load(object sender, EventArgs e)
        {

        }

        private void labelPilihPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Home().Show();
                this.Hide();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }
    }
}
