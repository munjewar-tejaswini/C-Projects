using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool objThread = new ThreadPool(Function);
            ThreadPool.
            objThread.Start();
            Console.ReadLine();

        }

        static void Function()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + ".";
            }
        }
    }
}
