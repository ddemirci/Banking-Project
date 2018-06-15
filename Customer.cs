using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    class Customer
    {
        string FName;
        string MName;
        string LName;
        string CustomerID;
        string Email;


        public Customer(string fname, string lname, string custID, string email)
        {
            this.FName = fname;
            this.LName = lname;
            this.CustomerID = custID;
            this.Email = email;

            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat("Customer {0},{1} has been created with Customer Number: {2} ", LName, FName, CustomerID);
        }

        public Customer(string fname, string mname, string lname, string custID, string email)
        {
            this.FName = fname;
            this.MName = mname;
            this.LName = lname;
            this.CustomerID = custID;
            this.Email = email;

            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat("Customer {0},{1} {2} has been created with Customer Number: {3} ", LName, FName, MName, CustomerID);
        }

    }
}
