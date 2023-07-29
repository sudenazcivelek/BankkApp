using System;

namespace BankkApp
{
    public class BankAccount
    {
        private string accountHolderName; //isim tutar
        private double balance;  // bakiyeyi tutar 

        public BankAccount(string accountHolderName, double initialBalance)  //Constructor metod
        {
            this.accountHolderName = accountHolderName;
            this.balance = initialBalance;
        }

        public double GetBalance()  //mevcut bakiyeyi döndürür tercih 1 için 
        {
            return balance;
        }

        public bool Withdraw(double amount)  //Para çekmek. Tercih 2 için
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(double amount) //Para yatırmak. Tercih 3 için 
        {
            balance += amount;
        }
    }
}