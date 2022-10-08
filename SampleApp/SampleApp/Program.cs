using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            if(a%5==0)
            {
                Console.WriteLine("Divisible by 5");

            }
            else
            {
                Console.WriteLine("Not Divisible");


            }
            Console.ReadLine();
        }
    }
}
