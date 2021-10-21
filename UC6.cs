using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_Day4
{
    class UC6

    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS = 100;
        public int totalEmpWage = 0;
        public void maxHours()
        {

            int empHr = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpWage = 0;

            while (totalEmpWage <= NUM_OF_WORKING_DAYS && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHr;
                Console.WriteLine("Days :" + totalWorkingDays + "Emp Hrs " + empHr);

            }
            totalEmpWage = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }

}