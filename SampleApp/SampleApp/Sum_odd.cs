using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Sum_odd
    {
        static void Main(string[] args)
        {
           
            int limit, sum=0,num;
            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the odd Numbers");
            
            for(int i = 1; i <= limit; i++)
            {
               
                num = Convert.ToInt32(Console.ReadLine());
                if(num %2 == 0)
                {
                    Console.WriteLine("Its not an odd Number\n Try again!!!!!");
                    continue;
                }
                sum = sum + num;

            }
            Console.WriteLine("Sum of Odd Numbers is {0}", sum);
            Console.ReadKey();
        }
    }
}
