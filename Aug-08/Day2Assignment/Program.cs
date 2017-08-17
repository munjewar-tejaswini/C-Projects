using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter no. of levels: ");
            int n=int.Parse(Console.ReadLine());
            PrintPattern pr = new PrintPattern();
            pr.PrintStar(n);
            */

            Console.Write("Enter A String : ");
            string Str = Console.ReadLine();
            CheckPalindrome check = new CheckPalindrome();
            if(Str=="")
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                check.palindrome(Str);
            }
            
            Console.ReadKey();


        }
    }
}
