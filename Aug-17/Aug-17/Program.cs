using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_17
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassSwap<int> intObj = new ClassSwap<int>();
            Console.WriteLine("Enter two values: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            intObj.SwapMethod(num1, num2);

            ClassSwap<string> stringObj = new ClassSwap<string>();
            Console.WriteLine("Enter two string values: ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            stringObj.SwapMethod(str1, str2);
            Console.ReadLine();
        }
    }
}
