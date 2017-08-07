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
            Random n = new Random();
            int usernumber = Convert.ToInt32(textBox2.Text);
            int[] array = new int[usernumber];
            int sum = 0;
            int count = 0;
            int smallest = 50;
            for (int i = 0; i < usernumber ; i++)
            {
                count += i;
                sum += array[i];
                array[i] = n.Next(10, 50);
                smallest = array[i];
                MessageBox.Show(Convert.ToString(array[i]));
                if(array[i]< smallest)
                {
                    smallest = array[i];
                }
            }
            double mean = sum / count;
            double volg = 0;
            for(int i = 0; i < usernumber; i++)
            {
                count += i;
                volg += Math.Sqrt(array[i] - mean);
            }
            double stndDev = volg / count;
            MessageBox.Show("hallo " + Convert.ToString(smallest));
            MessageBox.Show("Die is die stdDev " + Convert.ToString(stndDev));
            
        }
    }
}
