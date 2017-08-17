using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class PrintPattern
    {
        public void PrintRectangle(int num)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=3;j++)
                {
                    if(i==1 || i==5)
                    {
                        Console.Write("{0}", num);
                    }
                    else
                    {
                        if(j==2)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("{0}", num);
                        }
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
