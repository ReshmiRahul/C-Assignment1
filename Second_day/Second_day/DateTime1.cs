using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_day
{
     class DateTime1
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime();
            DateTime dt3 = DateTime.Now;
            Console.WriteLine(DateTime.Now);

            DateTime date1 = new DateTime(2022, 10, 07);
            Console.WriteLine("Date1:{0}", date1);

            Console.WriteLine("Day:{0}", dt3.Day);
            Console.ReadKey();
        }
    }
}
