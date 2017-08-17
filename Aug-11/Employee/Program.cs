using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp = new Developer(101, "Rutwik", "Developer", 5000);
            emp.CalSalary();

            emp = new Manager(102, "Tejaswini", "Manager", 8000); ;
            emp.CalSalary();

            emp = new LabAssistance(103, "mMMMM", "Lab Assistance", 1000); ;
            emp.CalSalary();

            Console.ReadLine();
        }
    }

}
