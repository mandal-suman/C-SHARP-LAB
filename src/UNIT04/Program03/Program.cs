/*
    Definition 3
        Create a class “Account” containing accountNo, and balance as an instance variable.
        Derive the Account class into two classes named “Savings” and “Current”. The“Savings” 
        class should contain instance variable named interest Rate, and the “Current” class should 
        contain an instance variable called overdraft Limit. Define appropriate methods for all the 
        classes to enable functionalities to check balance, deposit, and  withdraw amounts in Savings
        and Current accounts. (Use the concept of Abstract class) 
*/

using System;

namespace Program03 {
    class Program {
        static void Main(String[] args) {
            Savings sAcc = new Savings(1001, 5000, 4.5);
            sAcc.CheckBalance();
            sAcc.Deposit(1000);
            sAcc.Withdraw(7000);
            sAcc.ApplyInterest();

            Console.WriteLine("-------------------");

            Current cAcc = new Current(2001, 2000, 1000);
            cAcc.CheckBalance();
            cAcc.Withdraw(2500);
            cAcc.CheckBalance();
        }
    }
}