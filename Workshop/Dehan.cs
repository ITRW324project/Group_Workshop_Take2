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
    public partial class Dehan : Form
    {
        public Dehan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DehanSum num = new DehanSum();
            MessageBox.Show(Convert.ToString(num.generate_number(Convert.ToInt32(textBox1.Text))));
        }

        private void Dehan_Load(object sender, EventArgs e)
        {

        }
    }
}
