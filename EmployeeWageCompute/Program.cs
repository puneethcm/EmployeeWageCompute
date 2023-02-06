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

            List<CompanyDetails> list;
            Dictionary<string, CompanyDetails> KeyValues;
            int numofcompany = 0;
            public EmpWageBuilder()
            {
                //companies = new CompanyDetails[3];
                list = new List<CompanyDetails>();
                KeyValues = new Dictionary<string, CompanyDetails>();
            }

            public void AddCompanyDetails(string company, int maxWorkingDays, int maxWorkingHours, int empRatePerHour)
            {
                CompanyDetails conpanyDetails = new CompanyDetails(company, maxWorkingDays, maxWorkingHours, empRatePerHour);
                
                list.Add(conpanyDetails);
                KeyValues.Add(company,conpanyDetails);
            }

            public void IterateOverCompanies()
            {
                for(int i = 0; i < list.Count; i++)
                {
                    int totalWage = ConputeEmpWage(list[i]);
                    list[i].SetTotalWage(totalWage);
                    Console.WriteLine(list[i]);
                }
            }
            public void GetTotalWageOnCompany(string comp)
            {
                Console.WriteLine("\nTotalWage for {0} is {1}",comp, KeyValues[comp].totalWage);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("\nWelcome to Employee Wage Computation");
                EmpWageBuilder builder = new EmpWageBuilder();
                builder.AddCompanyDetails("Deloitee", 25, 50, 30);
                builder.AddCompanyDetails("Bridge", 25, 50, 30);
                builder.AddCompanyDetails("Google", 25, 50, 30);
                builder.IterateOverCompanies();
                builder.GetTotalWageOnCompany("Bridge");
                Console.ReadLine();
            }

            public int ConputeEmpWage(CompanyDetails details)
            {
                int empHour = 0, empWage = 0, day = 1, totalWage = 0, totalHours = 0;

                //UC6-Employee wage 20 days and 50 hours

                while (day <= details.maxWorkingDays && totalHours <= details.maxWorkingHours)

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
                    empWage = empHour * details.empRatePerHour;
                    //Console.WriteLine("\nday{0} Employee Wage: {1} EmpHours {2}", day, empWage, empHour);
                    totalWage += empWage;
                    day++;
                    totalHours += empHour;
                }
                //Console.WriteLine("\nTotal Employee wage of company {3} for {0} days is {1} and TotalHours: {2}", (day - 1), totalWage, totalHours, details.company);
                return totalWage;
            }
        }
    }
}
