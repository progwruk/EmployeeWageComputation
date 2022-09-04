using System;
namespace EmployeeWageComputation
{
    class Program 
    { 
        static void Main(string[] args)
        {
            EmployeeWage dMart = new EmployeeWage("DMart",30, 20, 100);
            EmployeeWage reliance = new EmployeeWage("Reliance", 20, 10, 50);
            dMart.CalculateEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.CalculateEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
