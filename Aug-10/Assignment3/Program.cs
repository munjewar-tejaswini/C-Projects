using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceVehicle vehicleObj = new VehicleClass();
            string ch;
            do
            {
                vehicleObj.getVehicleInterface();
                Console.WriteLine("\nWant to Continue..?\nPress y to continue");
                ch = Console.ReadLine();
                Console.Clear();
            } while (ch == "y");
            Console.ReadLine();
        }
    }
}
