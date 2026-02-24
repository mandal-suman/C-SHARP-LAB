/*
    Definition 14
    Write a program to check weather a number is palindrome or not 
    e.g. input: 121, output: It is palindrome 
         input:124, output: It is not palindrome
*/

using System;

class Program {
    static void Main() {
        string name;
        Console.Write("Enter String: ");
        name = Console.ReadLine();

        string revname = "";

        int i;
        for (i = name.Length - 1; i >= 0; i--) {
            revname = revname + name[i];
        }
        if (name == revname) {
            Console.WriteLine("Palindrome!");
        }
        else {
            Console.WriteLine("Not Palindrome!");
        }
    }
}
