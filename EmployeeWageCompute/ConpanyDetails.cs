using System;
namespace EmployeeWageCompute
{
	public class CompanyDetails
	{
		public string company;
        public int maxWorkingDays, maxWorkingHours, empRatePerHour, totalWage,empWage;

		public CompanyDetails(string company, int maxWorkingDays, int maxWorkingHours, int empRatePerHour)
		{
            this.company = company;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.empRatePerHour = empRatePerHour;
        }

        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public override string ToString()
        {
            return $"\nCompany:{company} totalWage:{totalWage}";
        }
    }
}

