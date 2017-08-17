using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            
            SumOfDigits sumObj = new SumOfDigits();

            Console.WriteLine("Sum: {0}", sumObj.FindSum(num));
          
            Console.ReadLine();

        }
    }
}
