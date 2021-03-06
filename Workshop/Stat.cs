﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class Stat
    {
        public double generate_number_Max(int i)
        {
            Random ran = new Random();
            int[] amount = new int[50];
            for (int j = 0; j < i; j++)
                amount[j] = ran.Next(1, 50);
            return amount.Max();
        }

        public double generate_number_Avg(int i)
        {
            Random ran = new Random();
            int[] amount = new int[50];
            for (int j = 0; j < i; j++)
                amount[j] = ran.Next(1, 50);
            return amount.Average();
        }

        public double calcMedian(int i)
        {
            Random n = new Random();
            int[] array = new int[i];

            for (int j = 0; j < i; j++)
            {
                array[j] = n.Next(1, 50);
            }

            return array[i / 2];
        }


        public double calcStdDev(int i)
        {
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
