using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        class EmpWageBuilder
        {
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;
            public string company;
            public int maxWorkingDays, maxWorkingHours, empRatePerHour;

            public EmpWageBuilder(string company, int maxWorkingDays, int maxWorkingHours, int empRatePerHour)
            {
                this.company = company;
                this.maxWorkingDays = maxWorkingDays;
                this.maxWorkingHours = maxWorkingHours;
                this.empRatePerHour = empRatePerHour;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("\nWelcome to Employee Wage Computation");
                EmpWageBuilder deloitte = new EmpWageBuilder("Deloitte", 25, 50, 30);
                deloitte.ConputeEmpWage();
                EmpWageBuilder bridge = new EmpWageBuilder("Bridge", 30, 70, 20);
                bridge.ConputeEmpWage();
                EmpWageBuilder google = new EmpWageBuilder("Google", 20, 60, 35);
                google.ConputeEmpWage();
                Console.ReadLine();
            }

            public void ConputeEmpWage()
            {
                int empHour = 0, empWage = 0, day = 1, totalWage = 0, totalHours = 0;

                //UC6-Employee wage 20 days and 50 hours

                while (day <= maxWorkingDays && totalHours <= maxWorkingHours)

                {
                    Random random = new Random();
                    int empAttendence = random.Next(0, 3);
                    switch (empAttendence)
                    {
                        case IS_FULL_TIME:
                            //Console.WriteLine("\nEmployee is Present");
                            empHour = 8;
                            break;

                        case IS_PART_TIME:
                            //Console.WriteLine("\nEmployee is Present for Half day");
                            empHour = 4;
                            break;

                        default:
                            //Console.WriteLine("\nEmployee is Absent");
                            empHour = 0;
                            break;
                    }
                    empWage = empHour * empRatePerHour;
                    //Console.WriteLine("\nday{0} Employee Wage: {1} EmpHours {2}", day, empWage, empHour);
                    totalWage += empWage;
                    day++;
                    totalHours += empHour;
                }
                Console.WriteLine("\nTotal Employee wage of company {3} for {0} days is {1} and TotalHours: {2}", (day - 1), totalWage, totalHours, company);
            }
        }
    }
}
