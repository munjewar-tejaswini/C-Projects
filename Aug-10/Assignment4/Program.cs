using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for base and height: ");
            double _Base = double.Parse(Console.ReadLine());
            double _Height = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Area Of rectangle: {0}", calculateArea.Rectangle(_Base, _Height));
            Console.ReadLine();
        }
    }
}
