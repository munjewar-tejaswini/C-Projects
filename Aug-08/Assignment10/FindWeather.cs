using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class FindWeather
    {
        public void GetWeather(int temp)
        {
            if (temp < 0)
                Console.WriteLine("Freezing weather");
            else if (temp >= 0 && temp < 10)
                Console.WriteLine("Very Cold weather");
            else if (temp >= 10 && temp < 20)
                Console.WriteLine("Cold weather");
            else if (temp >= 20 && temp < 30)
                Console.WriteLine("Normal Temperature");
            else if (temp >= 30 && temp < 40)
                Console.WriteLine("Its Hot");
            else if (temp >= 40)
                Console.WriteLine("Its Very Hot");

        }

    }
}
