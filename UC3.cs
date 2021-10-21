using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_Day4
{
    class UC3

    {
        public void addedPartTime()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empWage = 0;
            int empHr = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is on part time");
                empHr = 4;
            }
            else if  (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHr = 0;
            }
            empWage = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is :" + empWage);
        }

    }

}
