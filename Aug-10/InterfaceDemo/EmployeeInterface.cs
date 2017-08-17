using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface EmployeeInterface
    {
        void getName();
        void getSalary();
        void Display();
    }

    class FullTimeEmployee : EmployeeInterface
    {
        string name;
        int salary;
        public void getName()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();  
        }

        public void getSalary()
        {
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Salary: {0}", salary);
        }
    }
}
