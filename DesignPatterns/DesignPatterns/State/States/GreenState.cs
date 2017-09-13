using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.States
{
    class GreenState : State
    {
        public GreenState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            lowerLimit = -100.0;
        }

        public GreenState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            lowerLimit = -100.0;
        }


        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            CheckStateChange();
        }

        public void CheckStateChange()
        {
            if (balance < lowerLimit)
                account.State = new RedState(this);
        }
    }
}
