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
            int empHrs = 0, empWage = 0;
            Console.WriteLine("Welcome to employee wage computation");

            //UC3-PartTimeWage
            Random random = new Random();
            int empAttendance=random.Next(0,3); // 0 or 1 or 2 it will generate
            if (empAttendance == FULL_TIME)
            {
                Console.WriteLine("Full time Employee is present");
                empHrs = 8;
            }
            else if (empAttendance == PART_TIME) 
            {
                Console.WriteLine("Part time employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                //empHrs = 0;
            }
            empWage= empHrs*EMP_RATE_PER_HR;
            //Console.WriteLine("Employee wage: " +empWage); old way 
            Console.WriteLine("Employee Wage:{0}", empWage);  //new way
            Console.ReadLine();
        }
    }
}
