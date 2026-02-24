/*
    Definition 19
    Write a program to display minimum number from 5 
    numbers inputted by user by using the concept of arrays 
*/

using System;

class Program {
    static void Main() {
        int num, sum = 0, temp, remainder;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (temp != 0) {
            remainder = temp % 10;
            sum += remainder * remainder * remainder;
            temp /= 10;
        }
        if (sum == num) {
            Console.WriteLine(num + " is an Armstrong number.");
        }
        else {
            Console.WriteLine(num + " is not an Armstrong number.");
        }
    }
}
