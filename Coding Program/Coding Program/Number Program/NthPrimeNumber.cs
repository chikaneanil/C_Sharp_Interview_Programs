using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Number_Program
{
    class NthPrimeNumber
    {
        public static bool isPrime(int number) {
            int counter = 0;

            for (int j = 2; j < number; j++) {
                if (number % j == 0) {
                    counter = 1;
                    break;
                }
            }

            if (counter == 0) {
                return true;
            }
            else {
                return false;
            }

        }
        //static void Main(string[] args) {
        //    int num = 1;
        //    int count = 0;
        //    Console.Write("Enter Number :");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    while (true) {
        //        num++;
        //        if (isPrime(num)) {
        //            count++;
        //        }
        //        if (count == n) {
        //            Console.WriteLine(n + "th prime number is " + num);
        //            break;
        //        }
        //    }
        //    Console.ReadLine();
        //}
    }
}
