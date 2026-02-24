/*
    Definition 10
    Write a program to find Fibonacci series up to a number inputted by user.
*/

using System;
namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find Fibonacci series up to that number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series up to " + n + ":");
            int a = 0, b = 1, c = 0;

            while (c <= n)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
