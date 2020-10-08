using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface
{
    class CreditAccount : IAccount
    {
        private double m_Amount;
        private string m_AccountHolder;
        private string m_AccountNumber;
        public double CreditLimit { get; private set; }

        public double Amount { get { return m_Amount; } } 

        public string AccountHolder { get { return m_AccountHolder; } } 

        public string AccountNumber { get { return m_AccountNumber; } }

        public CreditAccount(string accountHolder, string accountNumber, double creditLimit)
        {
            m_AccountNumber = accountNumber;
            m_AccountHolder = accountHolder;
            CreditLimit = creditLimit;
        }
        public double Deposit(double amountToDeposit)
        {
            m_Amount += amountToDeposit;

            return Amount;
        }

        public double Withdraw(double amountToWithdraw)
        {
            if (amountToWithdraw > Amount + CreditLimit)
            {
                return Amount;
            }
            else
            {
                m_Amount -= amountToWithdraw;
            }

            return Amount;
        }
    }
}
