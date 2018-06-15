using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    interface IBankAccount
    {
        string withdrawMoney(decimal Amount);
        string depositMoney(decimal Amount);
        string TransferMoney(string ReceiverAccountID, decimal Amount);
    }
}
