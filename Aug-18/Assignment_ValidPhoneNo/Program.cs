using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_ValidPhoneNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter phone number");
            string phoneNo = Console.ReadLine();
            ValidatePhoneNo checkObj = new ValidatePhoneNo();
            checkObj.Check(phoneNo);
            Console.ReadLine();
        }

    }
}
