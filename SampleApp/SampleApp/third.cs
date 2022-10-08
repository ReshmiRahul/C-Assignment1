using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class third
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 67, 88 };
            foreach (int lst in arr) 
                Console.WriteLine(lst);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
