using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class pgm4
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            while(i<array.Length)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
