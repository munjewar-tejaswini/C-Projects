using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celsius: ");
            int temp = int.Parse(Console.ReadLine());

            FindWeather find = new FindWeather();

            find.GetWeather(temp);

            Console.ReadLine();
        }
    }
}
