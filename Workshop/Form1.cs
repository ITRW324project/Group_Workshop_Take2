﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simeon_bio frm = new simeon_bio();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stephan f = new Stephan();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DavidBio frm1 = new DavidBio();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Jennifer jen = new Jennifer();
            jen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dehan han = new Dehan();
            han.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Altus alt = new Altus();
            alt.Show();
        }
    }
}
