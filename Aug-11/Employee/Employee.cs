using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        string ename;
        int empId;
        string empDesignation;

        public Employee(int _empId, string _ename, string _empDesignation)
        {
            ename = _ename;
            empId = _empId;
            empDesignation = _empDesignation;
        }

        public virtual void CalSalary()
        {
            Console.WriteLine(" ");
        }

        public void Display()
        {
            Console.WriteLine("\nEmployee Id : {0} \nEmployee Name : {1} \nEmployee Designation : {2}", empId, ename, empDesignation);
        }

    }


    class LabAssistance : Employee
    {
        int salary;

        public LabAssistance(int _empId, string _ename, string _empDesignation, int _salary) : base(_empId,_ename, _empDesignation) 
        {
            salary = _salary;
        }

        public override void CalSalary()
        {
            Display();
            Console.WriteLine("Employee Salary : {0}", salary * 2);
        }
    }


    class Developer : Employee
    {
        int salary;

        public Developer(int _empId, string _ename, string _empDesignation, int _salary) : base(_empId,_ename,  _empDesignation)
        {
            salary = _salary;
        }

        public override void CalSalary()
        {
            Display();
            Console.WriteLine("Employee Salary : {0}", salary * 3);
        }
    }


    class Manager : Employee
    {
        int salary;

        public Manager(int _empId, string _ename, string _empDesignation, int _salary) : base(_empId,_ename, _empDesignation)
        {
            salary = _salary;
        }

        public override void CalSalary()
        {
            Display();
            Console.WriteLine("Employee Salary : {0}", salary * 4);
        }
    }

}


