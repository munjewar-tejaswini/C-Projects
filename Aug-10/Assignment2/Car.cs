using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Car : Vehicles
    {
        public override void getVehicleType()
        {
           
            string car_name = getNameOfCar();
            int car_model = getModelOfCar();
            int car_price = getPriceOfCar();
            Console.Clear();
            Console.WriteLine("Car Details: "); 
            Console.WriteLine("Name: {0}", car_name);
            Console.WriteLine("Model No.: {0}", car_model);
            Console.WriteLine("Price: {0}", car_price);
        }

        public string getNameOfCar()
        {
            Console.WriteLine("Enter Car Name: ");
            return Console.ReadLine();
        }

        public int getModelOfCar()
        {
            Console.WriteLine("Enter Car Model no.: ");
            return int.Parse(Console.ReadLine());
        }

        public int getPriceOfCar()
        {
            Console.WriteLine("Enter Car Price: ");
            return int.Parse(Console.ReadLine());
        }

    }

}
