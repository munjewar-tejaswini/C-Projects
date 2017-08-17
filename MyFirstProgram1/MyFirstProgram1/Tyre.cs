using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram1
{
    public class Tyre
    {
        public void TyreType()
        {
            Console.WriteLine("Tubeless Tyre");
        }
    }

    public class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter color is red");
            TyreType();
        }
    }


    public class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car color is Blue");
            TyreType();
        }
    }

}
