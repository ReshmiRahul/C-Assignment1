using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class Substring_Present
    {
        static void Main(string[] args)
        {
            String s1,s3;
            int count = 0;
            Console.WriteLine("Enter the string");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter the substring");
            s3 = Console.ReadLine();
            String[] s2 = s1.Split();
            foreach (string st in s2)
            {

                if(st==s3)

                {
                    count=count+1;
                    break;
                }   
               
            }
            if(count==0)
            {
                Console.WriteLine("It's not the Substring");
            }
            else
            {
                Console.WriteLine("It's the Substring");
            }
            //Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
