using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            CheckAlphabet check = new CheckAlphabet();

            check.getVovel(ch);

            Console.ReadLine();

        }
    }
}
