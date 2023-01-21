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
            const int isPartTime = 2;
            const int empRatePerHour = 20;
            int empHour = 0, empWage = 0, i, totalWage = 0; 
            Console.WriteLine("Welcome to Employee Wage Computation");

            Console.WriteLine("Enter the number of days: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //UC2-Employee daily Wage
            //Random random = new Random();
            //int empAttendence = random.Next(0, 2);
            for (i = 1; i <= number; i++)
            {
                Random random = new Random();
                int empAttendence = random.Next(0, 3);

                if (empAttendence == isPresent)
                {
                    Console.WriteLine("\nEmployee is Present");
                    empHour = 8;
                }
                else if (empAttendence == isPartTime)
                {
                    Console.WriteLine("\nEmployee is Present for Half day");
                    empHour = 4;
                }
                else
                {
                    Console.WriteLine("\nEmployee is Absent");
                    empHour = 0;
                }
                empWage = empHour * empRatePerHour;
                Console.WriteLine($"Employee Wage day {i}: " + empWage);
                totalWage += empWage;
            }

            Console.WriteLine($"Total Employee Wage till day {number} is: " + totalWage);
            Console.ReadLine();
        }
    }
}
