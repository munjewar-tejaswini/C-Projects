using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Pattern:");
            PrintFour prObj = new PrintFour();
            prObj.CheckNumber(num);

            Console.ReadLine();
        }
    }
}
