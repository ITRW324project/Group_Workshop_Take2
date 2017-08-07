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
    public partial class Jennifer : Form
    {
        public Jennifer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Except exc = new Except();
            if (exc.BetweenTest(Convert.ToInt32(textBox1.Text)) == true)
                MessageBox.Show("Between 5 and 20");
            else
                MessageBox.Show("Not Between 5 and 20");

            JenSeSom num = new JenSeSom();
            MessageBox.Show("Average:  " + Convert.ToString(num.generate_number_J(Convert.ToInt32(textBox1.Text))));
        }

        private void Jennifer_Load(object sender, EventArgs e)
        {

        }
    }
}
