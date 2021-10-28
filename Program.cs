/*using System;
//Till UC9
namespace EmpWagebuilderObject
{
    class EmpWagebuilderObject
    {
        const int IS_FULL_TIME = 1;
        int empRatePerHour;
        const int IS_PART_TIME = 2;
        int no_of_working_day;
        int max_hours;
        int totalEmpWage;
        string company;
        

        public EmpWagebuilderObject(string company,int empRatePerHour, int no_of_working_day, int max_hours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.no_of_working_day = no_of_working_day;
            this.max_hours = max_hours;

        }
        public void computeEmpWage() {
          
            int empHr = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            while (totalWorkingDays < this.no_of_working_day && totalEmpHrs < this.max_hours)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
             
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        Console.WriteLine("Day " + totalWorkingDays+"  part time");
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
                Console.WriteLine("Company name " + this.company + " and Total Working hours :" + totalEmpHrs);
            }
                totalEmpWage = totalEmpHrs * this.empRatePerHour;
              
               
               *//*Console.WriteLine("Employee Wage for the day : " + empWage);
               Console.WriteLine("Total employee wage " + totalEmpWage);*//*
            }
        
        public string toString()
        {
            return "Total Emp Wage for Company " + this.company + " is :" + this.totalEmpWage;
        }

    }
}*/