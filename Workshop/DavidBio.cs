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
    public partial class DavidBio : Form
    {
        public DavidBio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcStdDev c = new CalcStdDev();
            MessageBox.Show(Convert.ToString(c.calcStdDev(Convert.ToInt32(textBox2.Text))));
        }
    }
}
