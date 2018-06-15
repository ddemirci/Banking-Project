using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    class InterestAccount : BankAccount
    {
        int counter = 100000;
        public decimal InterestRate;

        public InterestAccount(string CustomerNumber)
        {
            this.AccountID = "IA" + counter.ToString();
            this.Balance = decimal.Zero;
            this.CustomerID = CustomerNumber;
            this.IsInterestAccount = true;
            InterestRate = Convert.ToDecimal(3);
        }

        public decimal CalculateMonthlyInterest(int month)
        {
            return this.Balance * (this.InterestRate / 100) * (month / 12);
        }

        public decimal BalanceAfterInterest(int month)
        {
            this.Balance += CalculateMonthlyInterest(month);
            return this.Balance;
        }
    }
}
