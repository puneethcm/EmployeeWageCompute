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
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int IS_EMP_RATE_PER_HR = 20;
            int empHour = 0, empWage;
            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC4-Switch Case
            Random random = new Random();
            int empAttendence = random.Next(0, 3);
            switch (empAttendence)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Present");
                    empHour = 8;
                    break;

                case IS_PART_TIME:
                    Console.WriteLine("Employee is Present for Half day");
                    empHour = 4;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    //empHour = 0;
                    break;
            }
            empWage = empHour * IS_EMP_RATE_PER_HR;
            //Console.WriteLine("Employee Wage: " + empWage);
            Console.WriteLine("Employee Wage {0}", empWage);
            Console.ReadLine();
        }
    }
}
