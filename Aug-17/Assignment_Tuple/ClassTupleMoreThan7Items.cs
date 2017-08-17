using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Tuple
{
    class ClassTupleMoreThan7Items
    {
        public void MethodTupleMoreThan7Items()
        {
            var tuple7 = Tuple.Create("Jane", 90, 87, 93, 67, 100, 92);
            Console.WriteLine("Test scores for {0}: {1}, {2}, {3}, {4}, {5}, {6}",
                              tuple7.Item1, tuple7.Item2, tuple7.Item3,
                              tuple7.Item4, tuple7.Item5, tuple7.Item6,
                              tuple7.Item7);
        }
    }
}
