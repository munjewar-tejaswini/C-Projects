using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOperations
{
    class Employee
    {
        public Employee(int id, string name, string departmentName, string projectName)
        {
            ID = id;
            Name = name;
            DepartmentName= departmentName;
            ProjectName = projectName;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectName { get; set; }

        public override string ToString()
        {
            return string.Format("\nId: {0} \nName:{1} \nDepartment Name: {2}, \nProject Name: {3}", ID, Name, DepartmentName, ProjectName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee(101, "ABC", "Developer", "Project1"));
            employeeList.Add(new Employee(102, "DEF", "Trainer", "Project2"));
            employeeList.Add(new Employee(103, "GHI", "Trainer", "Project3"));
            employeeList.Add(new Employee(104, "JKL", "Developer", "Project4"));

            Console.WriteLine("To find dept no. 101");
            foreach (Employee emp in employeeList.Where(e => e.ID == 101))
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();
        }
    }
}
