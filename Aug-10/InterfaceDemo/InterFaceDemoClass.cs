using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IMyInterface
    {
        void MethodToImplement();
    }

    class InterfaceImplementer : IMyInterface
    {
        public void MethodToImplement()
        {
            Console.WriteLine("This is method to implement interface");
        }
    }
}
