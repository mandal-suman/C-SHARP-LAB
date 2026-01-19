// Date: 19-01-2026
/*
    Definition 4
    Write a program to accept 5 numbers in an array and display their sum and average.
*/

using System;

namespace U2P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum = 0;

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
