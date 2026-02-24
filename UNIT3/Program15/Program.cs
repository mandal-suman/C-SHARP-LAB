/*
    Definition 15
    Write a program to check weather a string is palindrome or not 
    e.g. input:nayan output: it is palindrome 
    e.g. input: virat output: it is not palindrome 
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
