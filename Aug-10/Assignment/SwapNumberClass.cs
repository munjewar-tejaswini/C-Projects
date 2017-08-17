using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class SwapNumberClass
    {
        public void Swap(int num1, int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping: {0}, {1}", num1,num2);
        }
    }
}
