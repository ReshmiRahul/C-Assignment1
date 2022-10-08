using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class copyelements_array
    {
        static void Main(string[] args)
        {

            int[] array = new int[4];
            int[] array1=new int[4];
            //int count = 0, count1 = 0;
            Console.WriteLine("Enter the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nNegative elements are.......\n");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array1[i] = array[i];

                    Console.WriteLine(array1[i]);
                }
            }
            Console.ReadKey();
        }
        }
               
}
