using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_Day4
{
    class UC2

    {
        public void wageCheck()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empWage = 0;
            int empHr = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHr=8;

            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHr=0;
            }
            empWage = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is :"+empWage);
        }

    }

}


