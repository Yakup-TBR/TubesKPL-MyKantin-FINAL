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
    public partial class pilihKantin : Form
    {
        public pilihKantin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (true)
            {
                new Home().Show();
                this.Hide();

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
                new Home().Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (true)
            {
                new Home().Show();
                this.Hide();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Home().Show();
                this.Hide();
            }
        }
    }
}
