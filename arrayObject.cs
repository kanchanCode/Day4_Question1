using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagebuilderObject
{
    
    class arrayObject
    {
        static void Main(string[] args)

        {
            EmpWageBuilderArray object1 = new EmpWageBuilderArray();
            //addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            object1.addCompanyEmpWage("Nokia", 100, 15, 40);
            object1.addCompanyEmpWage("Samsung", 80, 18,50);
            object1.addCompanyEmpWage("Micromax", 60, 22, 80);
            object1.addCompanyEmpWage("Xiomi", 20, 30,100 );
            object1.addCompanyEmpWage("Realme", 25, 30, 100);
            object1.computeEmpWage();
        }
    }
}
