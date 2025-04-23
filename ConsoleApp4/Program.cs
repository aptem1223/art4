using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Company myCompany = new Company();

            var emp1 = new FullTimeEmployee("Alice", 60000);
            var emp2 = new PartTimeEmployee("Bob", 20);
            var emp3 = new Contractor("Charlie", "6-month web development contract");

            myCompany.AddEmployee(emp1);
            myCompany.AddEmployee(emp2);
            myCompany.AddEmployee(emp3);

            myCompany.DisplayEmployees();

            Console.WriteLine("\nRemoving Bob (Part-Time Employee)...\n");
            myCompany.RemoveEmployee(emp2);

            myCompany.DisplayEmployees();
        }
    }
}
