﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class pgm3
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
    }
}
