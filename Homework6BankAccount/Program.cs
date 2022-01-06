using System;

namespace Homework6BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account=new Account("Dan","Cerba");
            account.Deposit(100);
            account.CloseAccount();
            account.Withdraw(10);
            account.OpenAccount();
            account.DisplayAmount();
            EconomyAccount economyAccount = new EconomyAccount("Cucu", "Bau");
            economyAccount.Deposit(100);
            economyAccount.DisplayAmount();
            economyAccount.Withdraw(50);
            economyAccount.DisplayAmount();
            GameAccount gameAccount = new GameAccount("Game", "Account");
            gameAccount.Deposit(100);
            gameAccount.DisplayAmount();
            gameAccount.Withdraw(50);
            gameAccount.DisplayAmount();
            SecretAccount secretAccount = new SecretAccount("Secret", "Account");
            secretAccount.Deposit(100);
            secretAccount.DisplayAmount();
            secretAccount.Withdraw(50);
            secretAccount.DisplayAmount();

        }
    }
}
