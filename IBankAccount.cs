using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Project
{
    interface IBankAccount
    {
        string withdrawMoney(decimal Amount, string Currency);
        string depositMoney(decimal Amount, string Currency);
        string TransferMoney(string ReceiverAccountID, decimal Amount, string Currency);
    }
}
