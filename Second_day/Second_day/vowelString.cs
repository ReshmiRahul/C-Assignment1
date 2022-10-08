using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class vowelString
    {
        static void Main(string[] args)
        {
            String s1;
            int count = 0;
            int len;
            Console.WriteLine("Enter the string");
            s1 = Console.ReadLine();
           String s2 = s1.ToLower();
            //String[] s2 = s1.Split();
            len = s2.Length;

            Console.WriteLine("length:{0}\n",len);
            for(int i = 0; i < len; i++)
            {
                if (s2[i] == 'a' || s2[i] == 'e' || s2[i] == 'i' || s2[i] == 'u' || s2[i] == 'o')
                { 
                    count = count + 1; 
                }


            }
            Console.WriteLine("Vowel: {0}",count);
            Console.ReadLine();
        }
    }
}
