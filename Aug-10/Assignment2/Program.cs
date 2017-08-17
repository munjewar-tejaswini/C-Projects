using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicleObj = new Vehicles();
            string ch ;
            do
            {
                vehicleObj.getVehicleType();
                Console.WriteLine("\nWant to Continue..?\nPress y to continue");
                ch = Console.ReadLine();
                Console.Clear();
            } while (ch=="y");
            Console.ReadLine();
        }
    }
}
