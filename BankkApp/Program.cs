using System;

namespace BankkApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Sudenaz Civelek", 1000); //Nesne 

            Console.WriteLine("Welcome to the Bank App!");

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. View Account Balance"); //Bakiye Sorgulama 
                Console.WriteLine("2. Withdraw Money"); //para çekme 
                Console.WriteLine("3. Deposit Money");  //Para yatırma 
                Console.WriteLine("4. Finish Transactions and Logout"); //Çıkış işlemi
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice) //tercih 
                {
                    case "1":
                        Console.WriteLine($"Your Account Balance: {bankAccount.GetBalance()}"); 
                        break;
                    case "2":
                        Console.Write("Enter the amount to withdraw: "); //kaç para çekeğeni soruyor.
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (bankAccount.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine($"Successfully withdrew {withdrawAmount} from your account.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance. Withdrawal failed!"); //Eğer tutar az ise başarısız mesajı veriyor.
                        }
                        break;
                    case "3":
                        Console.Write("Enter the amount to deposit: "); //kaç para yatıracağını sorar.
                        double depositAmount = double.Parse(Console.ReadLine());
                        bankAccount.Deposit(depositAmount);
                        Console.WriteLine($"Successfully deposited {depositAmount} to your account.");
                        return;
                    case "4":
                        Console.WriteLine("Thank you for using the Bank App. Logging out..."); //Çıkış yapar.
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again."); //5 giibi başka bir seçenek sunduysa tekrar menüyü okur.
                        break;
                }
            }
        }
    }


}
