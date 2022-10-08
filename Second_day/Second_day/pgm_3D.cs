using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class pgm_3D
    {
        static void Main(string[] args)
        {
            int[,,] array3D = new int[2, 2, 3]
            {
                { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } }
            };
            Console.WriteLine(array3D[0, 1, 0]);
            Console.ReadLine();
        }
    }
}
