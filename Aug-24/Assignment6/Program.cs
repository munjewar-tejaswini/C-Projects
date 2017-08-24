using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TPL
namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100000, x => Execute());
            Console.ReadLine();
        }

        static void Execute()
        {
            string x = "";
            for (int i = 0; i < 100000; i++)
            {
                x = x + "T";
            }
        }
    }
}
