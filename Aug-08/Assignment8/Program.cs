using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Year: ");
            int num = int.Parse(Console.ReadLine());

            LeapYear year = new LeapYear();
            year.FindLeapYear(num);
            Console.ReadLine();

        }
    }
}
