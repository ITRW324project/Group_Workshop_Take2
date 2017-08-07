using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Workshop
{
    class CalcCount
    {
        public int count(int i)
        {
            Random n = new Random();

            int[] array = new int[i];

            for (int j = 0; j < i; j++)
            {
                array[j] = n.Next(1, 50);
            }

            return array[i];
        }
    }
}
