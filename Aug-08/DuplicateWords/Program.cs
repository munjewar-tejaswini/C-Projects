using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWords
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any Statement: ");
            string Str = Console.ReadLine();

            RemoveDuplicate remove = new RemoveDuplicate();

            if(Str=="")
            {
                Console.WriteLine("Empty statement");
            }
            else
            {
                Console.WriteLine("\nStatement after removing duplicates:");
                remove.RemoveDuplicates(Str);
            }
           

            Console.ReadLine();
        }
    }
}
