using System;

namespace CSharpXLink
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int DivideByTwo(int number)
        {
            return number / 2;
        }

        // In class practice
        // Write the method to determine if a number is perfect square. Should return true if it is, else no. 
        // Write tests for the edge cases. 
        public static bool PerfectSquare(int number)
        {
            // IF number % number == 0, return true;
            // ELSE return false;
            double result = Math.Sqrt(number);
            bool isSquare = result % 1 == 0;
            if (isSquare == true)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
