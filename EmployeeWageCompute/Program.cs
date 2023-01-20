using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int isPresent = 1;
            const int empRatePerHour = 20;
            int empHour = 0, empWage=0;
            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC1- EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 2);
            if (empAttendence == isPresent)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);
            Console.ReadLine();
        }
    }
}
