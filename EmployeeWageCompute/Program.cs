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
            ConputeEmpWage();
            Console.ReadLine();
        }

        public static void ConputeEmpWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int IS_MAX_WORKING_DAY = 20;
            const int IS_MAX_WORKING_HRS = 50;
            const int IS_EMP_RATE_PER_HR = 20;
            int empHour = 0, empWage = 0, day = 1, totalWage = 0, totalHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC6-Employee wage 20 days and 50 hours

            while (day <= IS_MAX_WORKING_DAY && totalHours <= IS_MAX_WORKING_HRS)

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
                empWage = empHour * IS_EMP_RATE_PER_HR;
                Console.WriteLine("day{0} Employee Wage: {1} EmpHours {2}", day, empWage, empHour);
                totalWage += empWage;
                day++;
                totalHours += empHour;
            }
            Console.WriteLine("Total Employee wage for {0} days: {1} TotalHours: {2}", (day - 1), totalWage, totalHours);
        }
    }
}
