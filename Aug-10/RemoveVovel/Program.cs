using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveVovel
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRemoveVovel clObj = new ClassRemoveVovel();
            Console.WriteLine("Enter any word: ");
            string word = Console.ReadLine();
            clObj.MethodRemoveVovel(word);
            Console.ReadLine();
        }
    }
}
