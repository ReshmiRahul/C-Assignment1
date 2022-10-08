using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
    internal class defaultcons
    {
        int a, b;
        public defaultcons()
        {
            a = 1;
            b = 2;
        }
        static void Main(string[] args)
        {
            defaultcons obj=new defaultcons();
             Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.ReadKey();
        }



           
        }
    }

