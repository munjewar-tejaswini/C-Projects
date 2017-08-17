using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Abstract Class
            /* Dog dd = new Dog();
             AbstractClass thePet = dd;
             thePet.eat();
             dd.sound();*/


            // Inheritance
            /*Scooter sc = new Scooter();
            sc.ScooterType();

            Car ca = new Car();
            ca.CarType();*/

            //Polymorphism
            /* Calculator cl = new Calculator();
             cl.Sum();
             cl.Sum(2, 4);
             cl.Sum(3.5f, 2.5f);
             cl.Sum("Tejaswini");*/

            //Overriding
            BaseClass bs = new DerivedClass();
            bs.myMethod();

            bs = new BaseClass();
            bs.myMethod();

            Console.ReadLine();
        }
    }
}
