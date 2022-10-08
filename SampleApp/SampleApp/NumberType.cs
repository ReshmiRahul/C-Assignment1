using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class NumberType
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number");
            i = Convert.ToInt32(Console.ReadLine());
            if (i > 0)
                Console.WriteLine("Positive Number");
            else if (i < 0)
                Console.WriteLine("Negative Number");
            else if (i == 0)
                Console.WriteLine("It is Zero");
            else
                Console.WriteLine("It's an invalid number......");
            Console.ReadLine();
        }
    }
}
