using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6BankAccount
{
    class GameAccount:Account
    {
        public GameAccount(string firstName, string lastName) : base(firstName, lastName)
        {
            this.canDeposit = true;
            this.canWithdraw = false;
        }
    }
}
