using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4.Division \n5.Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            SwitchCase obj = new SwitchCase();
        }
    }
}
