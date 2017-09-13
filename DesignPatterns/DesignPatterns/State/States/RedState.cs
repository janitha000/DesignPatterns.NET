using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.States
{
    class RedState : State
    {
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            upperLimit = 0.0;
            lowerLimit = -100.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("No withdrawals are permitted since the account is in red state");
        }

        public void StateChangeCheck()
        {
            if (balance > upperLimit)
                account.State = new GreenState(this);
        }
    }
}
