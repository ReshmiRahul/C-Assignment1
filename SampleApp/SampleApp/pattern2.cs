using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class pattern2
    {
        static void Main(string[] args)
        {

            int limit;

            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j);
                    //Console.WriteLine("");
                    // j = j +1;

                }
                Console.WriteLine();
                
            }
            Console.ReadKey();

        }
    }
}
