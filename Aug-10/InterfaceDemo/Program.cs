using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMyInterface intObj = new InterfaceImplementer();
            //intObj.MethodToImplement();
            //Console.ReadLine();
            EmployeeInterface Obj = new FullTimeEmployee();
            Obj.getName();
            Obj.getSalary();
            Console.Clear();
            Obj.Display();
            Console.ReadLine();
        }
    }
}


