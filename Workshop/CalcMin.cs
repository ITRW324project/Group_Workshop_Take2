using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class CalcMin
    {
        public double calcMinimum(int i)
        {
            Random n = new Random();
            int[] array = new int[i];
            int smallest = 50;
            for (int j = 0; j < i; j++)
            {
                array[j] = n.Next(10, 50);
                smallest = array[j];
                if (array[j] < smallest)
                {
                    smallest = array[j];
                }
            }
            return smallest;
           
        }
    }
}

