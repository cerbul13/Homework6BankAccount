//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework6BankAccount
//{
//    class SecretAccount:Account
//    {
//        public SecretAccount(string firstName,string lastName): base(firstName,lastName)
//        {
//        }
//        public override void Withdraw(decimal sum)
//        {
//            if (this.accountClosed == true) { Console.WriteLine("Contul este inchis. Nu se pot face withdraws."); }
//            else
//            {
//                if (DateTime.Now.Month != 10 && this.canWithdraw == true) { amount -= sum; Console.WriteLine($"S-a ridicat suma de {sum} RON in contul {FirstName} {LastName}."); } else { Console.WriteLine("Nu se pot face withdraws."); }
//            }
//        }
//    }
//}
