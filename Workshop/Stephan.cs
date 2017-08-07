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
    public partial class Stephan : Form
    {
        public Stephan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcMed c = new CalcMed();
            MessageBox.Show(Convert.ToString(c.calc(Convert.ToInt32(textBox2.Text))));
        }
    }
}
