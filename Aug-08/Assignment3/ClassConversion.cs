using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class ClassConversion
    {
        public void Temperature(double celsius)
        {
           
            double fahrenheit = ((9.0/5.0)* celsius) + 32.0;
            Console.WriteLine("Temperature in fahrenheit= {0}",fahrenheit);
        }
    }
}
