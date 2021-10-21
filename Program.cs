using System;

namespace Assignment1_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employees Wage Calculator");

            UC1 obj1 = new UC1();
            obj1.attendance();

            UC2 obj2 = new UC2();
            obj2.wageCheck();

            UC3 obj3 = new UC3();
            obj3.addedPartTime();

            UC4 obj4 = new UC4();
            obj4.addedSwitchCase();

            UC5 obj5 = new UC5();
            obj5.monthlyWage();

            UC6 obj6 = new UC6();
            obj6.maxHours();
        
        }
    }
}
