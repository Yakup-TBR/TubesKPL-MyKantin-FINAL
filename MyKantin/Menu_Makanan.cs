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
    public partial class Menu_Makanan : Form
    {
        public Menu_Makanan()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new pilihKantin().Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Minuman().Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Detail_Makanan().Show();
                this.Hide();

            }
        }
    }
}
