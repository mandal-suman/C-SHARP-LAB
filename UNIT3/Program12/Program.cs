/*
    Definition 12
    Write a program to Calculate sum of the number inputted by the user for 
    e.g. if user has inputted 1234 then it’s sum is 10
*/

using System;
namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate the sum of its digits:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10; // Add the last digit to sum
                number /= 10; // Remove the last digit
            }

            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
