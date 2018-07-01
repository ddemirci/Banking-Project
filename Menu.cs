using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Banking_Project
{
    class Menu
    {

        Bank IsBank = new Bank();

        static void Main(string[] args)
        {
            //Program pg = new Program();
            //Bank IsBank = new Bank();
            //Customer Doruk = IsBank.DefineCustomer("Doruk", "", "Demirci", "dorukdemirci.boun@gmail.com");
            //Console.WriteLine("Doruk's ID: " + Doruk.CustomerID);
            //BankAccount DoruksAccount = IsBank.OpenAccount(Doruk.CustomerID, 0);
            //BankAccount DoruksAnotherAccount = IsBank.OpenAccount(Doruk.CustomerID, 1);

            //Console.WriteLine("Doruk's money is " + DoruksAccount.Balance);
            //DoruksAccount.depositMoney(Convert.ToDecimal(2500));
            //Console.WriteLine("Doruk's money after deposit is " + DoruksAccount.Balance);

            //// Withdraw
            //DoruksAccount.withdrawMoney(Convert.ToDecimal(150));
            //Console.WriteLine("Doruk's money after withdraw is " + DoruksAccount.Balance);

            ////Transfer
            //DoruksAccount.TransferMoney(IsBank, DoruksAnotherAccount.AccountID, 1000);
            //Console.WriteLine("Doruk's money after transfer is " + DoruksAccount.Balance);
            //Console.WriteLine("Doruk's another account money after transfer is " + DoruksAnotherAccount.Balance);
            //Console.Read();


            //Console.WriteLine(IsBank.RetrieveAllAccountInfo());
            while (true)
            {
                Menu mn = new Menu();
                mn.showMenu();
                Console.Read();
            }

        }

        public void showMenu()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.Append("Please select operation number you want to do:").Append("\n");
            Sb.Append("1. Create a customer.").Append("\n");
            Sb.Append("2. Delete a customer.").Append("\n");
            Sb.Append("3. Open an account.").Append("\n");
            Sb.Append("4. Close an account.").Append("\n");
            Sb.Append("5. Transfer money.").Append("\n");
            Sb.Append("6. Withdraw money.").Append("\n");
            Sb.Append("7. Deposit money.").Append("\n");
            Console.Write(Sb.ToString());
            string UserInput = Console.ReadLine();
            int chosen = int.Parse(UserInput);
            ChoosingOption(chosen);
            Console.Read();
        }

        public void ChoosingOption(int chosen)
        {
            if (chosen == 1)
                CreateCustomer();
            else if (chosen == 3)
                OpenAnAccount();
            //else
            //    DepositMoney();
        }

        public void CreateCustomer()
        {
            Console.WriteLine("Creating a customer, please fullfill information of the customer.");
            Console.WriteLine("First Name, Middle Name (Optional), Last Name , Email adress (Please seperate them with whitespace \" \")");
            string CustomerInfo = Console.ReadLine();
            string[] splitted = CustomerInfo.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            if (splitted.Length == 3)
            {
                Customer c = new Customer(splitted[0], splitted[1], splitted[2]);
            }
            else if (splitted.Length == 4)
            {
                Customer c = new Customer(splitted[0], splitted[1], splitted[2], splitted[3]);
            }
            else
                Console.WriteLine("Invalid input stream.");

        }

        public void OpenAnAccount()
        {
            //Ask for CustomerID
            Console.WriteLine("Opening an account, please specify the owner of the account.");
            string CustomerId = Console.ReadLine();

            //Retrieve the customer
            Customer Owner = IsBank.RetrieveCustomer(CustomerId);

            //Ask for type 0 -> Interest  , 1->Non Interest . Specify it.
            Console.Write("Specify type of the account, 0 for Interest Account, 1 for Non-Interest Account :");
            string AccountType = Console.ReadLine();
            int Type = int.Parse(AccountType);

            //Open the account
            IsBank.OpenAccount(CustomerId, Type);

        }
        //public string DepositMoney()
        //{

        //    throw new NotImplementedException();
        //}

    }
}
