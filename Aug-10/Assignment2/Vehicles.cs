using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Vehicles
    {
        public virtual void getVehicleType()
        {
            Console.WriteLine("Select Vehicle Type:\n1. Car \n2. Bike \n3. Truck");
            Console.WriteLine("\nEnter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Clear();

            Car carObj = new Car();
            Bike bikeObj = new Bike();
            Truck truckObj = new Truck();

            switch (choice)
                {
                    case 1:
                        carObj.getVehicleType();
                        break;

                    case 2:
                        bikeObj.getVehicleType();
                        break;

                    case 3:
                        truckObj.getVehicleType();
                        break;

                    default:
                            return;
            }
        }
    }
}
