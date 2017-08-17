using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuple with 3 items:");
            ClassTupleWith3Items t1 = new ClassTupleWith3Items();
            t1.MethodTupleWith3Items();

            Console.WriteLine("\nTuple with 7 items:");
            ClassTupleMoreThan7Items t2 = new ClassTupleMoreThan7Items();
            t2.MethodTupleMoreThan7Items();

            Console.ReadLine();
        }
    }
}
