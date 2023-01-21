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
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHour = 0, empWage=0;
            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC2-Daily wages
            Random random = new Random();
            int empAttendence = random.Next(0, 2);
            if (empAttendence == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HR;
            //Console.WriteLine("Employee Wage: " + empWage);
            Console.WriteLine("Employee Wage {0}", empWage);
            Console.ReadLine();
        }
    }
}
