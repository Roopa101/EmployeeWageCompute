using System;

namespace EmployeeWageComputation
{
    public class EmpPresentAbsent
    {

     public static void Main(string[] args)
        {
            int isPresent = 1;

            Random employee = new Random();
            int randomInput = employee.Next(0, 2);

            if(randomInput == isPresent)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
            }
    }
}
