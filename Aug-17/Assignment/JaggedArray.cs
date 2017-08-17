using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class JaggedArray
    {
        public void JaggedArrayMethod()
        {
            int[][] arr = new int[][] { new int[] { 1,1}, new int[] { 2,2}, new int[] { 3,3}, new int[] { 4,4} };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i][j]);
                }
            }
        }
    }
}
