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
    }
}
