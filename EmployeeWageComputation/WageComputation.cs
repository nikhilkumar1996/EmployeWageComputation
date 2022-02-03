using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int Full_Day_Hr = 8, Total_Working_Days = 20, WagePerHr = 20,Part_Time_Hr=4, empPresent = 1, empNotPresent = 0, empPartTime = 2;
        int DailyEmpWage, PartTimeEmpWage,empHrs=0;
        public void CalculateEmpWage()
        {
            for (int i = 0; i < Total_Working_Days; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case empPresent:

                        this.empHrs += Full_Day_Hr;
                        break;

                    case empPartTime:
                        this.empHrs += Part_Time_Hr;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        this.empHrs += 0;
                        break;





                }

            }
            int totalEmpWage = empHrs * WagePerHr;
            Console.WriteLine("Total Employee Wage For a Month ="+totalEmpWage);





        }
    }
}
