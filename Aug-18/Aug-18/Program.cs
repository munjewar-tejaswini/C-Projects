using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee(101, "Tejaswini", 30000));
            employee.Add(new Employee(102, "Ashwini", 30000));
            employee.Add(new Employee(103, "Minal", 30000));
            employee.Add(new Employee(104, "Pooja", 30000));

            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();
        }
    }
}
