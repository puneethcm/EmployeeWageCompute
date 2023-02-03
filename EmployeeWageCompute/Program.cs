using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private static void Main(string[] args)
        {
            ConputeEmpWage("Deloitee",25,50,30);
            ConputeEmpWage("Google", 30, 70, 20);
            Console.ReadLine();
        }

        public static void ConputeEmpWage(string company, int maxWorkingDays, int maxWorkingHours, int empRatePerHour)
        {
            int empHour = 0, empWage = 0, day = 1, totalWage = 0, totalHours = 0;
            Console.WriteLine("\nWelcome to Employee Wage Computation");

            //UC6-Employee wage 20 days and 50 hours

            while (day <= maxWorkingDays && totalHours <= maxWorkingHours)

            {
                Random random = new Random();
                int empAttendence = random.Next(0, 3);
                switch (empAttendence)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("\nEmployee is Present");
                        empHour = 8;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("\nEmployee is Present for Half day");
                        empHour = 4;
                        break;

                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        empHour = 0;
                        break;
                }
                empWage = empHour * empRatePerHour;
                Console.WriteLine("\nday{0} Employee Wage: {1} EmpHours {2}", day, empWage, empHour);
                totalWage += empWage;
                day++;
                totalHours += empHour;
            }
            Console.WriteLine("\nTotal Employee wage of company {3} for {0} days: {1} TotalHours: {2}", (day - 1), totalWage, totalHours, company);
        }
    }
}
