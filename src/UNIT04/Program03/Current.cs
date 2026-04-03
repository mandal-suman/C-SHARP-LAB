using System;

namespace Program03 {
    public class Current : Account {
        private double OverdraftLimit;

        public Current(int accountNo, double initialBalance, double overdraftLimit) 
            : base(accountNo, initialBalance) {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount) {
            if (amount <= 0) throw new ArgumentException("Withdrawal must be positive.");
            
            if ((Balance + OverdraftLimit) >= amount) {
                Balance -= amount;
                Console.WriteLine($"Withdrew ₹{amount}. Remaining Balance: ${Balance}");
            } else {
                Console.WriteLine("Overdraft limit exceeded. Withdrawal denied.");
            }
        }
    }
}