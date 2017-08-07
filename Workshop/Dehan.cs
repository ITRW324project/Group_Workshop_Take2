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
            try
            {
                int test = Int32.Parse(textBox1.Text);

                Except exc = new Except();
                if (exc.BetweenTest(Convert.ToInt32(textBox1.Text)) == true)
                    MessageBox.Show("The entered number is between 5 and 20");
                else
                    MessageBox.Show("Not between 5 and 20");
                DehanSum num = new DehanSum();
                MessageBox.Show(Convert.ToString(num.generate_number(Convert.ToInt32(textBox1.Text))));
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox1.Text + " is not an integer.  Try again!!");
            }
        }

        private void Dehan_Load(object sender, EventArgs e)
        {

        }
    }
}
