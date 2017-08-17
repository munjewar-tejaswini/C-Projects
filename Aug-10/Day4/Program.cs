using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            ClassPartial cl = new ClassPartial();
            cl.method_1();
            cl.method_2();
            Console.ReadLine();
        }
    }
}
