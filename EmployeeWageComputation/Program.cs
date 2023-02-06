using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        //const int MAX_WORKING_DAYS = 20;
        //const int MAX_WORKING_HRS = 100;
        //const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Emplployee wage computation program");
            ComputeWage("Deloitee", 25, 35, 30);
            ComputeWage("Bridgelabz", 30, 25, 35);
            ComputeWage("Wipro", 20, 15, 80);
            Console.ReadLine();
        }
        public static void ComputeWage(string Company, int maxWorkingDays, int maxWorkingHrs, int empRatePerHrs)
        {
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;
            Random myObj = new Random();
            while (day <= maxWorkingDays && totalHrs <= maxWorkingHrs)
            {
                int empAttendence = myObj.Next(0, 3); //0 or 1 or 2
                switch (empAttendence)
                {
                    case FULL_TIME:
                        //Console.WriteLine("\nFull Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("\nPart Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("\nEmployee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empRatePerHrs;
                //Console.WriteLine("Day {0} Employeewage: {1} totalHrs:{2}", day, empWage, totalHrs);
                totalWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("Total Employeewage for {3} {0} days: {1} and totalHrs:{2}", (day - 1), totalWage, totalHrs, Company);
        }

    }
}
