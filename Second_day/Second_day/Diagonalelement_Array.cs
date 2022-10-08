using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class Diagonalelement_Array
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3,3];
            int sum = 0;
            //int[] array1 = new int[4];
            //int count = 0, count1 = 0;
            Console.WriteLine("Enter the array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i,j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                {
                    Console.WriteLine("Array[{0},{1}] = {2}", i, j, array[i,j]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum = sum + array[i, j];
                    }

                }
            }
                Console.WriteLine("Sum = {0}", sum);

                    Console.ReadKey();
        }
    }

}
