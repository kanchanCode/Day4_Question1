using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_Day4
{
    class UC1

    {
        public void attendance()
        {
            const int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }


        }
    }
}

