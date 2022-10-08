using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class fourth
    {
        static void Main(string[] args)
        {
            //int i = 5228;
            int i;
            Console.WriteLine("Enter the number");
            i=Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int rem;
            while (i%10 !=0)
            {
               rem= i%10;
                a=a+rem;
                i = i / 10;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
