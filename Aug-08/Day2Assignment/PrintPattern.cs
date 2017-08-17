using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class PrintPattern
    {
        public void PrintStar(int n)
        {
            int sp = n - 1;
            for(int i=1;i<=n;i++)
            {
                for (int k = 1; k <= sp; k++)
                {
                    Console.Write(" ");
                }

                for (int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
              sp--;
            }
            
        }

    }
}
