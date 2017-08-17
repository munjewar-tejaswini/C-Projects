using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The statement: ");
            string Str=Console.ReadLine();

            LargestString large = new LargestString();

            if(Str=="")
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                large.FindLargest(Str);
            }
           
            
            Console.ReadLine();

        }
    }
}
