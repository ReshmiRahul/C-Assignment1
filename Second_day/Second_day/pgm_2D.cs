using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class pgm_2D
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[3, 2]
            {
                {1,2 },{3,4 },{5,6 }
            };
            Console.WriteLine(intArray[0, 0]);
            Console.WriteLine(intArray[0,1]);
            Console.WriteLine(intArray[1,0]);
            Console.WriteLine(intArray[1,1]);
            Console.WriteLine(intArray[2, 0]);
            Console.WriteLine(intArray[2, 1]);

            Console.ReadKey();
        }
    }
}
