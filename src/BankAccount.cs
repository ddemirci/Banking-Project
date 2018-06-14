using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    class BankAccount : IBankAccount
    {

        public string AccountID;
        public decimal Balance;
        public string CustomerID;

        public const string SuccessMessage = " Successful Transaction Info : ";
        public const string FailureMessage = " Failed Transaction Info : ";

        public string depositMoney(decimal Amount, string Currency)
        {
            try
            {
                StringBuilder Sb = new StringBuilder();
                string info = Amount + " " + Currency + " has been sent to Account Number: " + this.AccountID; 
                if (Amount > 0)
                {
                    this.Balance += Amount;
                    
                    Sb.Append(SuccessMessage).Append(" ");
                    Sb.Append(Environment.NewLine);
                    Sb.Append(info);

                }
                else
                {
                    Sb.Append(FailureMessage);
                    Sb.Append(" ");
                    Sb.Append("Insufficient Funds");
                }
                return Sb.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string withdrawMoney(decimal Amount, string Currency)
        {
            throw new NotImplementedException();
        }

        public string TransferMoney(string ReceiverAccountID, decimal Amount, string Currency)
        {
            throw new NotImplementedException();
        }
    }
}
