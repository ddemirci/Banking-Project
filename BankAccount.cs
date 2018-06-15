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

        public string depositMoney(decimal Amount)
        {
            try
            {
                StringBuilder Sb = new StringBuilder();
                if (Amount > 0)
                {
                    this.Balance += Amount;
                    
                    string info = Amount + " TL has been sent to Account Number: " + this.AccountID; 
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

        public string withdrawMoney(decimal Amount)
        {
            try
            {
                StringBuilder Sb = new StringBuilder();
                if (Amount > 0 && this.Balance >= Amount)
                {
                    this.Balance -= Amount;

                    string info = Amount + " TL has been taken from Account Number: " + this.AccountID;
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

        public string TransferMoney(string ReceiverAccountID, decimal Amount)
        {
            try
            {
                if (this.Balance >= Amount && Amount > 0)
                {
                    Bank bank = new Bank();
                    BankAccount Receiver = bank.RetrieveAccount(ReceiverAccountID);
                    if (Receiver != null)
                    {
                        //this.withdrawMoney(Amount); //Withdraw money fonksiyonunda zaten kontrol var
                        //Found.depositMoney(Amount);
                        this.Balance -= Amount;
                        Receiver.Balance += Amount;
                        return Amount + " TL has been transferred from Account ID: " + this.AccountID +
                            "to Account ID: " + Receiver.AccountID;
                    }
                    else
                    {
                        return "There is no account with Account ID: " + ReceiverAccountID;
                    }
                }
                else
                {
                    if (this.Balance < Amount) return "Insufficient funds";
                    else return "Negative amount entered !";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
