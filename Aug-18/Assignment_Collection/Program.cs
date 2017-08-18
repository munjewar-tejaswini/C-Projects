using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collection
{
    class Program
    {
        static List<Employee> employee = new List<Employee>();

        static void Main(string[] args)
        {
            int empId, empSalary;
            string empName;
            int choice;

            do
            {
                Console.WriteLine("1. Add \n2. Update \n3.Delete \n4. Display \nEnter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Id, Name and Salary of Employee");
                        empId = int.Parse(Console.ReadLine());
                        empName = Console.ReadLine();
                        empSalary = int.Parse(Console.ReadLine());

                        AddItemInList(new Employee(empId, empName, empSalary));
                        break;

                    case 2:
                        Console.WriteLine("Enter Details to Update:");
                        Console.WriteLine("Enter Id, Name and Salary of Employee");
                        empId = int.Parse(Console.ReadLine());
                        empName = Console.ReadLine();
                        empSalary = int.Parse(Console.ReadLine());

                        UpdateItemInList(new Employee(empId, empName, empSalary));
                        break;

                    case 3:
                        Console.WriteLine("Enter employee Id to delete:");
                        empId = int.Parse(Console.ReadLine());
                        DeleteItemInList(new Employee(empId, null, 0));
                        break;

                    case 4:
                        foreach (Employee emp in employee)
                        {
                            Console.WriteLine(emp);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
            } while (choice != 4);

            Console.ReadLine();
        }

        private static void AddItemInList(Employee emp)
        {
            employee.Add(emp);
        }

        private static void DeleteItemInList(Employee emp)
        {
            employee.RemoveAll(e => e.ID.Equals(emp.ID));
        }

        private static void UpdateItemInList(Employee emp)
        {
            int index = employee.FindIndex(e => e.ID == emp.ID);
            employee[index] = emp;
        }

    
        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public Employee()
            { }

            public Employee(int id, string name, int salary)
            {
                ID = id;
                Name = name;
                Salary = salary;
            }

            public override string ToString()
            {
                return string.Format("ID : {0} \nName : {1} \nSalary : {2}\n", ID, Name, Salary);
            }

        }
    }
}
