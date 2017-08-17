using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Bike : Vehicles 
    {
        public override void getVehicleType()
        {
            string Bike_name = getNameOfBike();
            int Bike_model = getModelOfBike();
            int Bike_price = getPriceOfBike();
            Console.Clear();
            Console.WriteLine("Bike Details: "); 
            Console.WriteLine("Name: {0}", Bike_name);
            Console.WriteLine("Model No.: {0}", Bike_model);
            Console.WriteLine("Price: {0}", Bike_price);
        }

        public string getNameOfBike()
        {
            Console.WriteLine("Enter Bike Name: ");
            return Console.ReadLine();
        }

        public int getModelOfBike()
        {
            Console.WriteLine("Enter Bike Model no.: ");
            return int.Parse(Console.ReadLine());
        }

        public int getPriceOfBike()
        {
            Console.WriteLine("Enter Bike Price: ");
            return int.Parse(Console.ReadLine());
        }

    }
}
