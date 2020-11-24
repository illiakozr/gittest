using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesDemo
{
    [Serializable]
    abstract class Employee
    {
        protected Employee(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        //protected Employee(int iD, string name, decimal salary)
        //{
        //    ID = iD;
        //    Name = name;
        //    Salary = salary;
        //}

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public abstract void ComputeSalary();
    }
}
