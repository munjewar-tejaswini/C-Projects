using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram1
{
    abstract class AbstractClass
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Animal Can Sound");
        }
    }

    class Dog : AbstractClass
    {
        public override void eat()
        {
            Console.WriteLine("Dog Can eat");
        }
    }
}
