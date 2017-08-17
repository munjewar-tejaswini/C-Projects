using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram1
{
    class BaseClass
    {
        public virtual void myMethod()
        {
            Console.WriteLine("This is Base class");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void myMethod()
        {
            Console.WriteLine("This is Derived class");
        }
    }
}
