using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface
{
    class SavingsAccount : Account, IAccount
    {
        private double m_InterestRate;

        public SavingsAccount(double interestRate, string accountOwner, string accountNumber)
            : base(accountOwner, accountNumber)
        {
            m_InterestRate = interestRate;
        }

        public string AccountOwner { get { return m_AccountHolder; } }

        public double Deposit(double amountToDeposit)
        {
            m_Amount += amountToDeposit;

            return Amount;
        }

        public double Withdraw(double amountToWithdraw)
        {
            if (amountToWithdraw > Amount)
            {
                return 0;
            }
            else
            {
                m_Amount -= amountToWithdraw;
            }

            return Amount;
        }
    }
}
