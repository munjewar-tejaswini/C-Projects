using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalVar;
namespace Day3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalVar.Console cc = new GlobalVar.Console();
            System.Console.WriteLine("Hello");
            cc.WriteLine();

            System.Console.ReadLine();
        }
    }

}


namespace GlobalVar
{
    class Console
    {
        public void WriteLine()
        {
            global::System.Console.WriteLine("Class Console and Namespace Globalvar");
        }

    }
}
