using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPattern:\n ");

            PrintPattern pattern = new PrintPattern();
            pattern.PrintRectangle(num);

            Console.ReadLine();
        }
    }
}
