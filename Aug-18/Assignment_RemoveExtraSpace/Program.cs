using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_RemoveExtraSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            RemoveExtraSpace rObj = new RemoveExtraSpace();
            rObj.MethodRemoveExtraSpace(str);
            Console.ReadLine();
        }
    }
}
