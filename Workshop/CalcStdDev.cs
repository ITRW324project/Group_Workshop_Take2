using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class CalcStdDev
    {

        public double calcStdDev(int i)
        {
            /*
                        Random n = new Random();
                        int[] array = new int[i];

                        for (int j = 0; j < i; j++)
                        {
                            array[j] = n.Next(1, 50);
                        }

                        return array[i / 2];
                    }*/

            Random n = new Random();
            int[] array = new int[i];
            int sum = 0;
            int count = 0;
            int smallest = 50;
            for (int j = 0; j < i; j++)
            {
                count += j;
                sum += array[j];
                array[j] = n.Next(10, 50);
                smallest = array[j];

                if (array[j] < smallest)
                {
                    smallest = array[j];
                }
            }
            double mean = sum / count;
            double volg = 0;
            for (int j = 0; j < i; j++)
            {
                count += j;
                volg += Math.Sqrt(array[j] - mean);
            }
            double stndDev = volg / count;
            return stndDev;



        }
    }
}
