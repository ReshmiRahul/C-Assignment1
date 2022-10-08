using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class NN_SUM
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1;i<=10 ; i++)
            {
                sum += i; 
            }
            Console.WriteLine("Sum of Natural numbers is {0}", sum);
            Console.ReadLine();
        }
    }
}
