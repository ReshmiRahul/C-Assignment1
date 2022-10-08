using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class pattern1
    {
        static void Main(string[] args)
        {

            int limit;
            int a = 1;
            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit;i++ )
            {
               
                
                for (int j = 1; j <a+1; j++)
                {

                    Console.Write("*");
                    

                }

                Console.WriteLine();
                a = a + 2;
            }
                Console.ReadKey();
            
        }
        }
}
