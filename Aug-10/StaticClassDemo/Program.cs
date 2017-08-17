using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            f = TemperatureConverter.CelsiusToFahrenheit("45");
            Console.WriteLine("CtoF: {0}", f);
            c = TemperatureConverter.FahrenheitToCelsius("113");
            Console.WriteLine("FtoC: {0}", c);
            Console.ReadLine();
        }
    }
}
