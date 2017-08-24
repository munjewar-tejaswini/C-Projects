using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


//ThreadPool
namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Adding Function 1 to Threadpool");
            ThreadPool.QueueUserWorkItem(new WaitCallback (Function1));
            Console.WriteLine("Adding Function 2 to Threadpool");
            ThreadPool.QueueUserWorkItem(new WaitCallback (Function2));

            Console.ReadLine();
        }

        static void Function1(object obj)
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + ".";
            }
            Console.WriteLine("Thread 1 Finished");
        }

        static void Function2(object obj)
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
