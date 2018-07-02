using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    class NonInterestAccount : BankAccount
    {
        //int counter = 100000;
        long counter = Numerator.GetInstance().NonIntrestAccountCounter();

        public NonInterestAccount(string CustomerNumber)
        {
            this.AccountID = "NI" + counter.ToString();
            this.Balance = decimal.Zero;
            this.CustomerID = CustomerNumber;
            this.IsInterestAccount = false;
            StringBuilder SB = new StringBuilder();
            SB.AppendFormat("Non-Interest Account {0} of Customer {1} has been created.", AccountID, CustomerID);
            Console.WriteLine(SB.ToString());
        }

    }
}
