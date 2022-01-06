using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6BankAccount
{
    class SecretAccount:Account
    {
        private Account normalAccount;
        //private decimal balance;
        public SecretAccount(string firstName,string lastName,Account normalAccount,decimal balance):base(firstName,lastName)
        {
            this.normalAccount = normalAccount;
            Console.Write( "Instantiere: " ); base.Deposit(balance);
        }
        public void BuyPurse(decimal amount)
        {
            Console.Write( "Purse: " ); this.Withdraw(amount);
        }
        public void BuyWine(decimal amount)
        {
            Console.Write("Wine: "); this.Withdraw(amount);
        }
        public override void Deposit(decimal sum)
        {
            Console.Write($"Deposit fwd from {this.FirstName} {this.LastName}: "  ); normalAccount.Deposit(sum);
        }

        public override void Withdraw(decimal sum)
        {
            if (this.accountClosed == true) { Console.WriteLine("Contul este inchis. Nu se pot face withdraws."); }
            else
            {
                if (DateTime.Now.Month != 10 && this.canWithdraw == true && sum<=amount) { amount -= sum; Console.WriteLine($"S-a ridicat suma de {sum} RON din contul {FirstName} {LastName}."); } else { Console.WriteLine("Nu se pot face withdraws."); }
            }
        }
    }
}
