using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Dimensional Array: ");
            SingleDimensionalArray sda = new SingleDimensionalArray();
            sda.SingleDimensionalArraymethod();

            Console.WriteLine("\nMulti Dimensional Array: ");
            MultiDimensionalArray mda = new MultiDimensionalArray();
            mda.MultiDimensionalArraymethod();

            Console.WriteLine("\nJagged Array: ");
            JaggedArray ja = new JaggedArray();
            ja.JaggedArrayMethod();

            Console.ReadLine();
        }
    }
}
