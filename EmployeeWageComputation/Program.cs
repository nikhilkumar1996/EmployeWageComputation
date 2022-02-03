using EmployeeWageComputation;
using System;
namespace EmployeWageComputation
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program ");
            WageComputation WC = new WageComputation();
            WC.CalculateEmpWage();
            
        }
    }
}

