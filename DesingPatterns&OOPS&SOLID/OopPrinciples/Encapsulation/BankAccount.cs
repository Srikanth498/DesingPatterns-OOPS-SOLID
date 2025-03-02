using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_OOPS_SOLID.OopPrinciples.Encapsulation
{
    class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }
        public decimal GetBalance()
        {
            return balance; 
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount cannot be negative");
            }

            this.balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("WithDraw amount must be postive");
            }
            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            this.balance -= amount;
        }
    }
}
