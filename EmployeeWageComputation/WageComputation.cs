﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int Full_Day_Hr = 8, WagePerHr = 20;
        int empPresent=0, empNotPresent=1,DailyEmpWage;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == empPresent)
            {
                Console.WriteLine("Employee is Present");

            }
            if(empCheck == empNotPresent)
            {
                Console.WriteLine("Employee is Absent");
            }

            DailyEmpWage = (Full_Day_Hr * WagePerHr);
            Console.WriteLine("DailyEmpWage="+DailyEmpWage);

        }
    }
}
