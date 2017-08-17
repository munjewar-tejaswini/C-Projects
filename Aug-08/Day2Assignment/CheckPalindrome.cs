using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class CheckPalindrome
    {
        public void palindrome(string Str)
        {
            string reversestring = "";
            int Length;
            Length = Str.Length - 1;

            //String reverse Logic
            while (Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }

            if(Str==reversestring)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
            
        }
    }
}
