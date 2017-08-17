using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class SumOfDigits
    {
        public int FindSum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + FindSum(num / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}

