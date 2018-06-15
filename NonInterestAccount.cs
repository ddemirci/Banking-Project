using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    class NonInterestAccount : BankAccount
    {
        int counter = 100000;

        public NonInterestAccount(string CustomerNumber)
        {
            this.AccountID = "NI" + counter.ToString();
            this.Balance = decimal.Zero;
            this.CustomerID = CustomerNumber;
            this.IsInterestAccount = false; 
        }

    }
}
