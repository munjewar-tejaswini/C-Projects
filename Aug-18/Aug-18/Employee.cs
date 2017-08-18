using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_18
{
    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public Employee(int id, string name, int salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} \nName : {1} \nSalary : {2}\n", ID,Name,Salary);
        }
    }
}
