using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }

        public PartTimeEmployee(string name, double hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }

        public string GetInfo()
        {
            return $"Part-Time Employee: {Name}, Hourly Rate: {HourlyRate:C}";
        }
    }
}
