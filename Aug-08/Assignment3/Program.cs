using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter celsius:");
            double celsius = double.Parse(Console.ReadLine());

            ClassConversion convert = new ClassConversion();

           convert.Temperature(celsius);

            Console.ReadLine();
        }
    }
}
