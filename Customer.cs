using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project 
{
    class Customer 
    {
        int counter = 1;
        public string FName;
        public string MName;
        public string LName;
        public string CustomerID;
        public string Email;


        public Customer(string fname, string lname, string email)
        {
            this.FName = fname;
            this.LName = lname;
            this.CustomerID = GenerateCustomerID(ref counter);
            this.Email = email;
            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat("Customer {0},{1} has been created with Customer Number: {2} ", LName, FName, CustomerID);
            Console.WriteLine(Sb.ToString());

        }

        public Customer(string fname, string mname, string lname, string email)
        {
            this.FName = fname;
            this.MName = mname;
            this.LName = lname;
            this.CustomerID = GenerateCustomerID(ref counter);
            this.Email = email;


            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat("Customer {0},{1} {2} has been created with Customer Number: {3} ", LName, FName, MName, CustomerID);
            Console.WriteLine(Sb.ToString());
        }

        public string GenerateCustomerID(ref int counter)
        {
            StringBuilder Sb = new StringBuilder();
            for (int i = 0; i < 5 - counter.ToString().Trim().Length; i++) Sb.Append("0");
            Sb.Append(counter.ToString());
            counter++;
            return Sb.ToString();

        }
    }
}
