using System;

namespace Program03
{
    // Abstract base class: Centralizes state and defines the strict contract.
    public abstract class Account {
        public int AccountNo { get; private set; }
        protected double Balance;

        public Account(int accountNo, double initialBalance) {
            AccountNo = accountNo;
            Balance = initialBalance;
        }

        public void CheckBalance() {
            Console.WriteLine($"Account {AccountNo} Balance: ${Balance}");
        }

        public void Deposit(double amount) {
            if (amount <= 0) throw new ArgumentException("Deposit must be positive.");
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance: ${Balance}");
        }

        public virtual void Withdraw(double amount) {
            if (amount <= 0) throw new ArgumentException("Withdrawal must be positive.");
            if (Balance >= amount) {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. Remaining: ${Balance}");
            } else {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}