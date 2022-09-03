using System;
namespace EmployeeWageComputation
{
    class Program 
    { 
        static void Main(string[] args)
        {
            EmployeeWage employeewage = new EmployeeWage();
            employeewage.CalculateEmpWage("DMart", 30, 20, 100);
            employeewage.CalculateEmpWage("Reliance", 20, 10, 200);
        }
    }
}
