using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class LargestNum
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("{0} is the largest number", a);

            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("{0} is the largest number",b);
            }
            else
            {
                Console.WriteLine("{0} is the largest number", c);
            }

            Console.ReadLine();
        }
    }
}
