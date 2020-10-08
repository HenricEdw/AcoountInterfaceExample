using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface
{
    public abstract class Account
    {
        protected string m_AccountNumber;
        protected string m_AccountHolder;
        protected double m_Amount;

        protected Account(string accountHolder, string accountNumber)
        {
            m_AccountHolder = accountHolder;
            m_AccountNumber = accountNumber;
        }

        public string AccountHolder { get { return m_AccountHolder; } private set { } }
        public string AccountNumber { get { return m_AccountNumber; } private set { } }

        public double Amount { get { return m_Amount; } private set { } }
    }
}
