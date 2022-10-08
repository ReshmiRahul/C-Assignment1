using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class pattern3
    {
        static void Main(string[] args)
        {

            int limit;
            int a=1;

            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());
            int num = (limit + (limit - 1));
            for (int i = limit; i >= 1;i--)
            {

                for (int j = num; j >a-1 ; j--)
                {

                    Console.Write("*");
                 

                }
                Console.WriteLine();
                
                a = a +2;
               
 


            }
            Console.ReadKey();

        }
    }
}
