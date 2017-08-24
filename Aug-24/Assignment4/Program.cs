using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var m = new Mutex(false, "Assignment4_1"))
            {
                if(!m.WaitOne(5000,false))
                {
                    Console.WriteLine("Already Running Instance");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("App is Running");
                Console.ReadLine();
            }
        }
    }
}
