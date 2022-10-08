using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class Sum_Array
    {
        static void Main(string[] args)
        {

            int[] array = new int[4];
            // int count = 0, count1 = 0;
            int sum = 0;
            Console.WriteLine("Enter the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}