using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Employees.Add(new EmployeeWithFixedPayment(1, "John", 3000));
            Employees.Add(new EmployeeWithFixedPayment(2, "Bob", 3500));
            Employees.Add(new EmployeeWithFixedPayment(3, "Mark", 2400));
            Employees.Add(new EmployeeWithFixedPayment(4, "Peter", 3000));
            Employees.Add(new EmployeeWithFixedPayment(6, "Olexa", 5500));
            Employees.Add(new EmployeeWithHourlyWage(2, "Jaccy", 160));
            Employees.Add(new EmployeeWithHourlyWage(3, "Kane", 145));
            Employees.Add(new EmployeeWithHourlyWage(1, "Sue", 183));
            Employees.Add(new EmployeeWithHourlyWage(4, "Tom", 150));

            foreach (Employee emp in Employees.OrderByDescending(e => e.Salary).ThenBy(e => e.Name))
            {
                Console.WriteLine($"{emp.ID} --- {emp.Name} --- {emp.Salary}");
            }

            Console.WriteLine("-------------------------------------------------------------------");

            SerializeEmployees(Employees);

            List<Employee> newList = DeserializeEmployees();
            foreach(Employee emp in newList)
            {
                Console.WriteLine($"{emp.ID} --- {emp.Name} --- {emp.Salary}");
            }

           
        }

        public static void SerializeEmployees(IEnumerable<Employee> employees)
        {
            using (FileStream fileStream = new FileStream("employees.dat", FileMode.OpenOrCreate))
            {

                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, employees);
            }
        }

        public static List<Employee> DeserializeEmployees()
        {
            using (FileStream fs = new FileStream("employees.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                return (List<Employee>)formatter.Deserialize(fs);
            }
        }
    }
}
