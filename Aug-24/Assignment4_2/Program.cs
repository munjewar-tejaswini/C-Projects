using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4_2
{
    class Program
    {
        static Semaphore s1 = null;
        static void Main(string[] args)
        {
            try
            {
                s1 = Semaphore.OpenExisting("Assignment4_2");
            }
            catch(Exception e)
            {
                s1 = new Semaphore(3, 3, "Assignment4_2");
            }

            Console.WriteLine("Acquiring...!!!");
            s1.WaitOne();
            Console.WriteLine("Thread Acquired");
            Console.ReadLine();
            s1.Release();
        }
    }
}
