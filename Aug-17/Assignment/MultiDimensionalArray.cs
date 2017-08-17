using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MultiDimensionalArray
    {
        public void MultiDimensionalArraymethod()
        {
            int[,] arr = new int[4, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
                }
            }
        }
    }
}
