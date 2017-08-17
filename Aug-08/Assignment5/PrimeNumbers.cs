using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class PrimeNumbers
    {
        public void SumPrime()
        {
            int sum = 0;
            int count = 0;
            for (int i= 2;count<=1000;i++)
            {
                int isPrime = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                  
                }
                if (isPrime == 1)
                {
                    sum += i;
                    count++;
                }

            }
            Console.WriteLine("Sum={0}", sum);
        }
    }
}
