using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Student_Mark
    {
        static void Main(string[] args)
        {
            int roll;
            Console.WriteLine("Enter the roll number");
            roll = Convert.ToInt32(Console.ReadLine());
            string name;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            double mark1, mark2, mark3, marks, percentage;
            Console.WriteLine("Enter the mark of maths");
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the English");
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Physics");
            mark3 = Convert.ToDouble(Console.ReadLine());
            marks = mark3 + mark2 + mark1;
            percentage = (marks / 300) * 100;
            Console.WriteLine("Roll Number = {0} \n Name = {1} \n Marks = {2} {3} {4} \n Total Marks = {5} \n Percentage = {6}", roll, name, mark1, mark2, mark3, marks, percentage);
            Console.ReadLine();
        }
    

        }
}
