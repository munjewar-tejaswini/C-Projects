using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread objThread1 = new Thread(Function1);
            Thread objThread2 = new Thread(Function2);
            Console.WriteLine("Main Thread Started..!!");

            Console.WriteLine("Thread 1 Started");
            objThread1.Start();
            Console.ReadLine();

            Console.WriteLine("Thread 2 Started");
            objThread2.Start();
            Console.ReadLine();
        }

        static void Function1()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + ".";
            }
            Console.WriteLine("Thread 1 Finished");
        }

        static void Function2()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + ".";
            }
            Console.WriteLine("Thread 2 Finished");
        }
    }
}
