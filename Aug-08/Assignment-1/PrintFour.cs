using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class PrintFour
    {
        public void CheckNumber(int num)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if(i%2!=0)
                    {
                        Console.Write("{0} ", num);
                    }
                    else
                    {
                        Console.Write("{0}", num);
                    }
                }
                Console.WriteLine("\n");
            }

        }
    }
}
