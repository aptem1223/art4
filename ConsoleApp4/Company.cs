using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Company
    {
        private List<IEmployee> employees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employees.Remove(employee);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Company Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }
    }
}
