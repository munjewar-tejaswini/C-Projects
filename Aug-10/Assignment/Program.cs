using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            SwapNumberClass swObj = new SwapNumberClass();

            Console.WriteLine("Before swapping: {0}, {1}", num1, num2);
            swObj.Swap(num1, num2);

            Console.ReadLine();
        }
    }
}
