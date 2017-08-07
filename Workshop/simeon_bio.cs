using System;
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
    public partial class simeon_bio : Form
    {
        public simeon_bio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcMin c = new CalcMin();
            MessageBox.Show(Convert.ToString(c.calcMinimum(Convert.ToInt32(textBox2.Text))));

        }
    }
}
