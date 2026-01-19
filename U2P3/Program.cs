// Date: 19-01-2026
/*
    Definition 3
    Write a program to generate the Fibonacci series up to n terms.
*/

using System;

namespace U2P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int a = 0, b = 1, c;
                Console.WriteLine($"Fibonacci Series up to {n} terms:");
                Console.Write($"{a} {b}");

                for (int i = 2; i < n; i++)
                {
                    c = a + b;
                    Console.Write($" {c}");
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid positive number.");
            }
        }
    }
}
