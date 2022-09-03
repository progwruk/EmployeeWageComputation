using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, FULL_TIME_HR = 8, PART_TIME_HR = 4;
        public int CalculateEmpWage(string company, int wagePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int totalEmpWage = 0, empHrs = 0;
            Random random = new Random();
            for (int i = 0; i < numOfWorkingDays && empHrs <= maxHoursPerMonth; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_TIME_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                }
            }
            totalEmpWage = wagePerHour * empHrs;
            Console.WriteLine("Total employee wage of " + company + " is : " + totalEmpWage);
            return totalEmpWage;
        }

    }
}
