using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static int num1 = 0, num2 = 0, result = 0;

        static void Main(string[] args)
        {
            Program Obj = new Program();
            new Thread(Obj.Divide).Start();
            Console.ReadLine();
        }

        public void Divide()
        {
            Random randomNo = new Random();
            for(long i=0;i<100000;i++)
            {
                lock(this)
                {
                    num1 = randomNo.Next(1, 1000);
                    num2 = randomNo.Next(1, 1000);

                    result = num1 / num2;

                    num1 = 0;
                    num2 = 0;
                }
                    
            }
        }
    }
}
