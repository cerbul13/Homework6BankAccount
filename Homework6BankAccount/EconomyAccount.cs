using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6BankAccount
{
    class EconomyAccount : Account
    {
        private decimal percentDeposit;
        private decimal percentWithdraw;
        //public decimal PercentDeposit
        //{
        //    get { return percentDeposit; }
        //    set { percentDeposit = value; }
        //}
        //public decimal PercentWithdraw
        //{
        //    get { return percentWithdraw; }
        //    set { percentWithdraw = value; }
        //}
        public EconomyAccount(string firstName,string lastName) :base (firstName,lastName)
        {
            this.percentDeposit = (decimal)0.01;
            this.percentWithdraw = (decimal)0.02;
        }
        public override void Deposit(decimal sum)
        {
            if (this.accountClosed == true) { Console.WriteLine("Contul este inchis. Nu se pot face deposits."); }
            else
            {
                if (this.canDeposit == true) { amount += sum; amount += sum * percentDeposit / 100; Console.WriteLine($"S-a depus suma de {sum+(sum * percentDeposit / 100)} RON in contul {FirstName} {LastName}."); } else { Console.WriteLine("Nu se pot face deposits."); }
            }
        }
        public override void Withdraw(decimal sum)
        {
            if (this.accountClosed == true) { Console.WriteLine("Contul este inchis. Nu se pot face withdraws."); }
            else
            {
                if (this.canWithdraw == true) { amount -= sum; amount -= sum * percentWithdraw / 100; Console.WriteLine($"S-a ridicat suma de {sum + (sum * percentWithdraw / 100)} RON in contul {FirstName} {LastName}."); } else { Console.WriteLine("Nu se pot face withdraws."); }
            }
        }
    }
}
