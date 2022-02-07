using EmployeeWageComputation;
using System;
namespace EmployeWageComputation
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            WageComputation WC = new WageComputation();
            WC.CalculateEmpWage("Tata Consultancy Services", 80, 12, 90);
            WageComputation WC1 = new WageComputation();
            WC1.CalculateEmpWage("Tata Motors", 55, 22, 110);
            WageComputation WC2 = new WageComputation();
            WC.CalculateEmpWage("Google", 78, 32, 120);


        }
    }
}

