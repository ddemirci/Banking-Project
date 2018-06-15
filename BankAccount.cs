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
        public bool IsInterestAccount;

        public const string SuccessMessage = " Successful Transaction Info : ";
        public const string FailureMessage = " Failed Transaction Info : ";

        public string depositMoney(decimal Amount, string Currency)
        {
            try
            {
                StringBuilder Sb = new StringBuilder();
                if (Amount > 0)
                {
                    this.Balance += Amount;
                    
                    string info = Amount + " " + Currency + " has been sent to Account Number: " + this.AccountID; 
                    Sb.Append(SuccessMessage).Append(" ");
                    Sb.Append(Environment.NewLine);
                    Sb.Append(info);

                }
                else
                {
                    Sb.Append(FailureMessage);
                    Sb.Append(" ");
                    Sb.Append("Wrong input");
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
            try
            {
                StringBuilder Sb = new StringBuilder();
                if (Amount > 0 && this.Balance >= Amount)
                {
                    this.Balance -= Amount;

                    string info = Amount + " " + Currency + " has been taken from Account Number: " + this.AccountID;
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

        public string TransferMoney(string ReceiverAccountID, decimal Amount, string Currency)
        {
            throw new NotImplementedException();
        }
    }
}
