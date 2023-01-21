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
            const int IS_MAX_WORKING_DAY = 20;
            const int IS_EMP_RATE_PER_HR = 20;
            int empHour = 0, empWage=0, day, totalWage=0;
            Console.WriteLine("Welcome to Employee Wage Computation");

            //UC4-Employee wage 20 days
            
            for (day = 1; day <= IS_MAX_WORKING_DAY; day++)

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
                //Console.WriteLine("Employee Wage: " + empWage);
                Console.WriteLine("day{0} Employee Wage: {1}" ,day, empWage);
                totalWage += empWage;
            }
            Console.WriteLine("Total Employee wage for {0} days: {1}", (day - 1), totalWage);
            Console.ReadLine();
        }
    }
}
