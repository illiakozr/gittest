using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesDemo
{
    [Serializable]
    class EmployeeWithFixedPayment : Employee
    {
        public decimal FixedPayment { get; set; }

        //public EmployeeWithFixedPayment(int Id, string name) : base (Id, name) {}

        public EmployeeWithFixedPayment(int Id, string name, decimal payment) : base(Id, name) 
        {
            FixedPayment = payment;
            ComputeSalary();
        }

        public override void ComputeSalary()
        {
            this.Salary = FixedPayment;
        }
    }
}
