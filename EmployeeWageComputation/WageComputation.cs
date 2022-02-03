﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int Full_Day_Hr = 8, WagePerHr = 20,Part_Time_Hr=4;
        int empPresent=1, empNotPresent=0,empPartTime=2,DailyEmpWage, PartTimeEmpWage;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == empPresent)
            {
                Console.WriteLine("Employee is Present");
                DailyEmpWage = (Full_Day_Hr * WagePerHr);
                Console.WriteLine("Daily Employee Wage=" + DailyEmpWage);

            }
            if(empCheck == empNotPresent)
            {
                Console.WriteLine("Employee is Absent");
            }
            if (empCheck == empPartTime)
            {
                Console.WriteLine("Employee is Working PartTime");
                PartTimeEmpWage = (Part_Time_Hr * WagePerHr);
                Console.WriteLine("PartTime Wage =" + PartTimeEmpWage);
            }


            

            
        }
    }
}
