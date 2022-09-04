using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1;
        string company;
        int wagePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;

        public EmployeeWage(string company, int wagePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
    
        public void CalculateEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                }
                totalEmpHrs += empHrs;
            }
            totalEmpWage = totalEmpHrs * this.wagePerHour;
            Console.WriteLine("Total employee wage of " + company + " is : " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp wage for company  " + this.company + " is :" + totalEmpWage;
        }
    }
}
