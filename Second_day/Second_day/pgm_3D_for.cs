using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class pgm_3D_for
    {
        static void Main(string[] args)
        {
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine("3D Array......\n\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("a[{0},{1},{2}]={3}", i, j,k, array3D[i, j,k]);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
