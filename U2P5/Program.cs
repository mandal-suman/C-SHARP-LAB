// Date: 19-01-2026
/*
    Definition 5
    Write a program to check if a string is a palindrome.
*/

using System;

namespace U2P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            
            // Remove spaces and convert to lowercase for accurate comparison
            string cleanInput = input.Replace(" ", "").ToLower();
            string reversed = "";

            for (int i = cleanInput.Length - 1; i >= 0; i--)
            {
                reversed += cleanInput[i];
            }

            if (cleanInput == reversed)
            {
                Console.WriteLine($"\"{input}\" is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{input}\" is NOT a Palindrome.");
            }
        }
    }
}
