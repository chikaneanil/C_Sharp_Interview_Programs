using System;

namespace Coding_Program.Number_Program
{
    public class FactorialRecursion
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Please Enter Number");
            int factorialnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number {0}",factorial_recursion(factorialnumber));
            Console.ReadLine();
        }

        public static double factorial_recursion(int number) 
        {
            if (number == 0) {
                return 1;
            }
            else {
                return number * factorial_recursion(number - 1);
            }
        }

        
    }
}
