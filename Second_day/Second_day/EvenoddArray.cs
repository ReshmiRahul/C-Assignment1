using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class EvenoddArray
    {
        static void Main(string[] args)
        {

            int[] array = new int[4];
            int count=0, count1=0;
            Console.WriteLine("Enter the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            
                for (int i = 0; i < array.Length; i++)
            {
                if((array[i]%2) == 0)
                {
                    count=count+1;
                }
                else
                {
                    count1=count1+1;
                }
            }
            Console.WriteLine("Even numbers : {0}\n", count);
            Console.WriteLine("Odd Numbers  : {0}\n", count1);
            Console.ReadLine();

        }
    }
}
