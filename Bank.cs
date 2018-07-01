using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banking_Project
{
    class Bank
    {
        List<BankAccount> BankAccountList = new List<BankAccount>();
        List<Customer> CustomerList = new List<Customer>();

        public BankAccount OpenAccount(string CustomerID, int type)
        {

            //BankAccount Acc = ( type == 0 ) ? new InterestAccount(CustomerID): 
            //                                  new NonInterestAccount(CustomerID);
            //var a = type == 0 ? 5 : 4;


            if (type == 0)
            {
                BankAccount acc = new InterestAccount(CustomerID);
                BankAccountList.Add(acc);
                return acc;
            }
            else
            {
                BankAccount acc = new NonInterestAccount(CustomerID);
                BankAccountList.Add(acc);
                return acc;
            }

        }

        public void CloseAccount(string AccountID)
        {

        }

        public BankAccount RetrieveAccount(string AccountID)
        {
            try
            {
                BankAccount Found = BankAccountList.Find(x => (x.AccountID).Equals(AccountID));
                if (Found != null) return Found;
                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            throw new NotImplementedException();
        }

        public string RetrieveAccountInfo(string AccountID)
        {
            StringBuilder Sb = new StringBuilder();

            try
            {
                BankAccount Found = RetrieveAccount(AccountID);
                if (Found != null)
                {
                    string AccountTypeInfo = (Found.IsInterestAccount) ? "Interest" : "NonInterest";
                    Sb.Append("Account Info:").Append(Environment.NewLine);
                    Sb.AppendFormat("Customer ID: {0}, Account ID: {1}, Account Type: {2}, Amount: {3} ",
                        Found.CustomerID, Found.AccountID, AccountTypeInfo, Found.Balance);
                    return Sb.ToString();
                }
                else return "There is no account with ID: " + AccountID;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string RetrieveAllAccountInfo()
        {
            throw new NotImplementedException();
        }

        public Customer DefineCustomer(string fname, string mname, string lname, string email)
        {
            try
            {
                StringBuilder Sb = new StringBuilder();

                if (mname != "")
                {
                    Customer Cust = new Customer(fname, lname, email);
                    //Sb.AppendFormat("Customer {0},{1} has been created with Customer Number: {2}"
                    //    , Cust.LName, Cust.FName, Cust.CustomerID);
                    //Console.WriteLine(Sb.ToString());
                    return Cust;
                }
                else
                {
                    Customer Cust = new Customer(fname, mname, lname, email);
                    //Sb.AppendFormat("Customer {0},{1} {2} has been created with Customer Number: {3} "
                    //    , Cust.LName, Cust.FName, Cust.MName, Cust.CustomerID);
                    //Console.WriteLine(Sb.ToString());
                    return Cust;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer RetrieveCustomer(string CustomerID)
        {
            try
            {
                Customer Found = CustomerList.Find(x => (x.CustomerID).Equals(CustomerID));
                if (Found != null) return Found;
                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
