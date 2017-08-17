using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_17
{
    public class ClassSwap<T>
    {
        public void SwapMethod(T num1, T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("Num1: {0} \nNum2: {1}\n",num1,num2);
        }
    }
}
