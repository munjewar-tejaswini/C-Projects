using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Tuple
{
    class ClassTupleWith3Items
    {
        public void MethodTupleWith3Items()
        {
            Tuple<string, string, string> varTuple = new Tuple<string, string, string> ( "Tejaswini", "Chhatrapal", "Munjewar");
            Console.WriteLine("{0},{1},{2}",varTuple.Item1, varTuple.Item2, varTuple.Item3);
        }
    }
}
