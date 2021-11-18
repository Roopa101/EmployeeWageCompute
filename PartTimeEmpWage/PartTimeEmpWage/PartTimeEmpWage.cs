﻿using System;

namespace PartTimeEmpWageCompute
{
    public class PartTimeEmpWage
    {
        public static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int empWage = 0;
            int ratePerHrs = 20;
            int empHrs = 0;

            Random employee = new Random();
            int randomInput = employee.Next(0, 3);

            if (randomInput == IS_FULL_TIME)
            {
                Console.WriteLine("FullTimeEmp is Present");
                empHrs = 8;
            }
            else if (randomInput == IS_PART_TIME)
            {
                Console.WriteLine("PartTimeEmp is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empWage = ratePerHrs * empHrs;
            Console.WriteLine("Emp Wage per day:" +empWage);
            Console.ReadLine();
        }
    }
}
