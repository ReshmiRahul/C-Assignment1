using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class Word_count
    {
        static void Main(string[] args)
        {
            String s1;
            int count=0;
            Console.WriteLine("Enter the string");
            s1 = Console.ReadLine();
            String[] s2 = s1.Split();
            foreach (string st in s2)
            {
                count = count + 1;

            }            
                Console.WriteLine(count);
            Console.ReadLine();
        }
        
    }
}
