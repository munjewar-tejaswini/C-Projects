using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Truck : VehicleClass
    {
        public void getVehicleType()
        {
            string Truck_name = getNameOfTruck();
            int Truck_model = getModelOfTruck();
            int Truck_price = getPriceOfTruck();
            Console.Clear();
            Console.WriteLine("Truck Details: ");
            Console.WriteLine("Name: {0}", Truck_name);
            Console.WriteLine("Model No.: {0}", Truck_model);
            Console.WriteLine("Price: {0}", Truck_price);
        }

        public string getNameOfTruck()
        {
            Console.WriteLine("Enter Truck Name: ");
            return Console.ReadLine();
        }

        public int getModelOfTruck()
        {
            Console.WriteLine("Enter Truck Model no.: ");
            return int.Parse(Console.ReadLine());
        }

        public int getPriceOfTruck()
        {
            Console.WriteLine("Enter Truck Price: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
