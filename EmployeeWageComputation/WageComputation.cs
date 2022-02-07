using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation 
    {
       const int  empPresent = 1, empPartTime = 2;
        const int Full_Day_Hr = 8,Part_Time_Hr = 4;
        int empHrs=0;
        public void CalculateEmpWage(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
        {
            
            int empDailyWage = 0;
            int workingDays = 1;
            int workingHrs = 0;
            
            while (workingDays <= max_working_days && workingHrs <= maxHoursPerMonth)
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
                if(empCheck != 0)
                {
                    workingDays++;
                }
                empDailyWage = empHrs * wage_per_hour;

            }
            int totalEmpWage = empHrs * wage_per_hour;
            int totalWorkingHrs = empHrs;
            

            Console.WriteLine("Company Name:" + company);
            Console.WriteLine("Total Working Hours :" + totalWorkingHrs);
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Working days in a month :" + workingDays);
            Console.WriteLine("Employee Wage for 20 working days :" + totalEmpWage);







        }
    }
}
