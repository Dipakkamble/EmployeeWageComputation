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
            int isPresent = 1;
            Console.WriteLine("Welcome to employee wage computation");

            //UC1-EmployeeAttendance
            Random random = new Random();
            int empAttendance=random.Next(0,2); // 0 or 1 it will generate
            if ( empAttendance == isPresent )
            {
                Console.WriteLine("Employee is present");
            }
            else 
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
        }
    }
}
