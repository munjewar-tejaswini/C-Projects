using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram1
{
    public class Calculator
    {
        public void Sum()
        {
            Console.WriteLine("No value Provided");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum of {0} and {1} = {2}", a, b, (a + b));
        }


        public void Sum(float a, float b)
        {
            Console.WriteLine("Sum of {0} and {1} = {2}", a, b, (a + b));
        }

     
        public void Sum(string s)
        {
            Console.WriteLine(s);
        }
    }
}
