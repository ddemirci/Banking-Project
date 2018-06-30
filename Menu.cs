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
        static void Main(string[] args)
        {
            Program pg = new Program();
            Bank IsBank = new Bank();
            Customer Doruk = IsBank.DefineCustomer("Doruk", "", "Demirci", "dorukdemirci.boun@gmail.com");
            Console.WriteLine("Doruk's ID: " + Doruk.CustomerID);
            BankAccount DoruksAccount = IsBank.OpenAccount(Doruk.CustomerID, 0);
            BankAccount DoruksAnotherAccount = IsBank.OpenAccount(Doruk.CustomerID, 1);
            Console.WriteLine("Doruk's money is " + DoruksAccount.Balance);
            DoruksAccount.depositMoney(Convert.ToDecimal(2500));
            Console.WriteLine("Doruk's money after deposit is " + DoruksAccount.Balance);

            // Withdraw
            DoruksAccount.withdrawMoney(Convert.ToDecimal(150));
            Console.WriteLine("Doruk's money after withdraw is " + DoruksAccount.Balance);

            //Transfer
            DoruksAccount.TransferMoney(DoruksAccount.AccountID, 1000);
            Console.WriteLine("Doruk's money after transfer is " + DoruksAccount.Balance);
            Console.WriteLine("Doruk's another account money after transfer is " + DoruksAnotherAccount.Balance);

            //Console.WriteLine(IsBank.RetrieveAllAccountInfo());
            Menu mn = new Menu();
            mn.showMenu();
            Console.Read();

        }

        public void showMenu()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.Append("Please select operation number you want to do:").Append("\n");
            Sb.Append("1. Create a user.").Append("\n");
            Sb.Append("2. Delete a user.").Append("\n");
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
                CreateUser();
            //else if (chosen == 2)
            //    OpenAnAccount();
            //else
            //    DepositMoney();
        }

        public string CreateUser()
        {
            Console.Write("Creating User");
            return "";
        }

        //public string OpenAnAccount()
        //{

        //    throw new NotImplementedException();
        //}
        //public string DepositMoney()
        //{

        //    throw new NotImplementedException();
        //}

    }
}
