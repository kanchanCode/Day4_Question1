using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EmpWagebuilderObject
{
    public class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
       public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        /*public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public string company;
        public int empRatePerHour;


       public EmpWageBuilderArray(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }*/

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;

        }
      


        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHr;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            while (totalEmpHrs < companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        Console.WriteLine("Day " + totalWorkingDays + "  part time");
                        break;


                    case IS_FULL_TIME:

                        empHr = 8;
                        Console.WriteLine("Day " + totalWorkingDays + "  present");
                        break;


                    default:

                        empHr = 0;
                        Console.WriteLine("Day " + totalWorkingDays + "  absent");
                        break;
                }
                totalEmpHrs += empHr;
                Console.WriteLine("Company name " + companyEmpWage.company + " and Total Working hours :" + totalEmpHrs);
            }

           
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }


        /*Console.WriteLine("Employee Wage for the day : " + empWage);
        Console.WriteLine("Total employee wage " + totalEmpWage); */


        
    }




    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for " + this.company + " is: " + this.totalEmpWage;
        }



    }
}



