using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Values: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            FindLargest large = new FindLargest();

            Console.WriteLine("Largest No.: {0}", large.FindLargestNumber(num1, num2, num3));

            Console.ReadLine();
        }
    }
}
