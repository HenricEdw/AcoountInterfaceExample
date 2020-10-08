using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface
{
    internal abstract class AbstractAccountExample
    {
        //Eftersom klassen är abstrakt måste också våra metoder vara det
        //Det innebär att vi inte FÅR ha en implementation, precis som ett interface
        public abstract double Deposit(double amountToDeposit);
        public abstract double Withdraw(double amountToWithdraw);
    }
}
