using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread objThread = new Thread(Function1);
            Console.WriteLine("Main Thread started");
            objThread.IsBackground = true;  //if IsBackground = false then the foregraound thread will be running
            objThread.Start();
            Console.ReadLine();
        }

        static void Function1()
        {
            Console.WriteLine("Thread 1 started");
            Console.ReadLine();
            Console.WriteLine("Thread 1 Finished");
            Console.ReadLine();
        }
    }
}
