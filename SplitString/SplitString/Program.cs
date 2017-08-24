using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitEvenOdd split = new SplitEvenOdd();
            string str = Console.ReadLine();
            split.SeperateString(str);
            Console.ReadLine();
        }
    }

    public class SplitEvenOdd
    { 
        public void SeperateString(string str)
        {
            char[] characters = str.ToCharArray();

            List<string> odd = new List<string>();
            List<string> even = new List<string>();

            for (int i=0;i<str.Length;i++)
            {
                if(i%2 == 0)
                {
                    even.Add(characters[i].ToString());
                }
                else
                {
                    odd.Add(characters[i].ToString());
                }
            }
            
            foreach(var item in even)
            {
                Console.Write(item); 
            }

            Console.Write(" ");
            foreach (var item in odd)
            {
                Console.Write(item);
            }

        }
    }
}
