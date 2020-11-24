using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesDemo
{
    [Serializable]
    class EmployeeWithHourlyWage : Employee
    {
        public int Hours { get; set; }

        //public EmployeeWithHourlyWage(int id, string name) : base(id, name) { }

        public EmployeeWithHourlyWage(int id, string name, int Hours) : base(id, name) {
            this.Hours = Hours;
            ComputeSalary();
        }

        public override void ComputeSalary()
        {
            Salary = (decimal)(20.8 * 8 * Hours);
        }
    }
}
