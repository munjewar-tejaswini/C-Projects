using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_ValidPhoneNo
{
    class ValidatePhoneNo
    {
        public void Check(string phoneNo)
        {
            string pattern = @"^\d{3}-\d{4}$";
            Regex R = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);


            Match m = R.Match(phoneNo);
            if (m.Success)
            {
                Console.WriteLine("Correct Format of telephone number: {0}", phoneNo);
            }
            else
            {
                Console.WriteLine("Correct Format of telephone number: {0}", phoneNo);
            }

        }

    }
}
