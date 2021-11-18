using System;

namespace DailyEmpWageCompute
{
   public class DailyEmpWage
    {
       public static void Main(string[] args)
        {
            int isPresent = 1;
            int empWage = 0;
            int ratePerHrs = 20;
            int empHrs = 0;

            Random employee = new Random();
            int randomInput = employee.Next(0, 2);

            if (randomInput == isPresent)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empWage = ratePerHrs * empHrs;
            Console.WriteLine("Employee wage per day :" + empWage);
            Console.ReadLine();


        }
    }
}
