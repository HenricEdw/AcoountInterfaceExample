using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(0.03d, "Henric", "223344");

            CreditAccount credit = new CreditAccount("Bertil", "552233", 10000d);

            List<IAccount> accounts = new List<IAccount>();

            accounts.Add(savings);
            accounts.Add(credit);

            foreach(var account in accounts)
            {
                account.Deposit(300);
                account.Withdraw(4000);

                Console.WriteLine($"Konto {account.AccountNumber} som ägs av {account.AccountHolder} har {account.Amount}:- i saldo");
            }

            Console.Read();
        }
    }
}
