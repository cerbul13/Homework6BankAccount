using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6BankAccount
{
    class Account
    {
        protected decimal amount;
        private string firstName;
        private string lastName;
        protected bool canDeposit;
        protected bool canWithdraw;
        protected bool accountClosed;

        public decimal Amount
        {
            get { return amount; }
        }
        public string FirstName
        {
            get { return firstName;}
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public virtual void Deposit(decimal sum)
        {
            if (this.accountClosed == true) { Console.WriteLine("Contul este inchis. Nu se pot face deposits."); }
            else
            {
                if (this.canDeposit == true) { amount += sum; Console.WriteLine($"S-a depus suma de {sum} RON in contul {FirstName} {LastName}."); } else { Console.WriteLine("Nu se pot face deposits."); }
            }
        }
        public virtual void Withdraw(decimal sum)
        {
            if (this.accountClosed == true) { Console.WriteLine("Contul este inchis. Nu se pot face withdraws."); }
            else
            {
                if (this.canWithdraw == true) { amount -= sum; Console.WriteLine($"S-a ridicat suma de {sum} RON in contul {FirstName} {LastName}."); } else { Console.WriteLine("Nu se pot face withdraws."); }
            }
        }
        public Account(string firstName,string lastName)
        {
            this.amount = 0;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.canDeposit = true;
            this.canWithdraw = true;
            this.accountClosed = false;
        }
        public void CloseAccount()
        {
            Console.WriteLine("Contul a fost inchis.");
            this.accountClosed = true;
        }
        public void OpenAccount()
        {
            Console.WriteLine("Contul a fost deschis.");
            this.accountClosed = false;
        }
        public void DisplayAmount()
        {
            Console.WriteLine($"Contul {this.firstName} {this.lastName} are {this.Amount} RON.");
        }


    }
}
