using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_Day4
{
    class UC5

    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 10;
        public void monthlyWage()
        {

            int empWage = 0;
            int empHr = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is on part time");
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is on part time");
                        empHr = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHr = 0;
                        break;
                }

                empWage = empHr * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage is :" + empWage);
            }

            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }

}

