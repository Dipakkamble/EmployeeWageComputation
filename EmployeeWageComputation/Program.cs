using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs= 0;

            Console.WriteLine("Welcome to employee wage computation");
            //UC5-MonthEmpWage
            Random random = new Random();
            while (day<= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int empAttendance = random.Next(0, 3); // 0 or 1 or 2 it will generate
                switch (empAttendance)
                {
                    case FULL_TIME:
                        Console.WriteLine("\nFull time Employee is present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("\nPart time employee is present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("\nEmployee is absent");
                        empHrs= 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                //Console.WriteLine("Employee wage: " +empWage); old way 
                Console.WriteLine("Day{0} Employee Wage:{1}",day, empWage);  //new way
                //totalWage = totalWage + empWage;
                totalWage+= empWage;
                day++;
                totalHrs+= empHrs;
            }
            Console.WriteLine("Total Employee wage for {0} days:{1} and totalHrs:{2}", (day - 1),totalWage,totalHrs);
            Console.ReadLine();
        }
    }
}
