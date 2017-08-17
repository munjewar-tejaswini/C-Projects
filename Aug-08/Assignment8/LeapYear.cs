using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class LeapYear
    {
        public void FindLeapYear(int year)
        {
            Console.WriteLine((year % 4 == 0 && year % 100 != 0) ? "Leap Year" :
        (year % 400 == 0) ? "Leap Year" : "not Leap Year");
        }
    }
}
