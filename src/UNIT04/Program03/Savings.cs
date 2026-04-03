using System;

namespace Program03 {
    public class Savings : Account {
        private double InterestRate;

        public Savings(int accountNo, double initialBalance, double interestRate) 
            : base(accountNo, initialBalance) {
            InterestRate = interestRate;
        }

        public void ApplyInterest() {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest applied. New Balance: ${Balance}");
        }
    }
}