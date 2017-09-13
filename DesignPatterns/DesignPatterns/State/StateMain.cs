using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class StateMain
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }
    }
}
