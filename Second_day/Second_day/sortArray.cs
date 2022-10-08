using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class sortArray
    {
        static void Main(string[] args)
        {

            int[] array = new int[4];
            //int[] array1 = new int[4];
            //int count = 0, count1 = 0;
            Console.WriteLine("Enter the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("\nSorted Array is.......\n");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                //array1[i] = Array.Sort(array);

                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
           
       
    }

}
