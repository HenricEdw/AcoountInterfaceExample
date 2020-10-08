using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface
{
    interface IAccount
    {
        double Amount { get; }
        string AccountHolder { get; }
        string AccountNumber { get; }
        double Deposit(double amountToDeposit);

        double Withdraw(double amountToWithdraw);
    }
}
