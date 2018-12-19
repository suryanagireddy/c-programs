using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        
            Account account = new Account("suryas account", 400);
            account.Print();
            account.Deposit(100);
            account.Print();
            account.Withdraw(200);
            account.Print();
        


        
            Account newAccount = new Account("sri account", 50);
            newAccount.Print();
            newAccount.Deposit(100);
            newAccount.Print();
            newAccount.Withdraw(200);
            newAccount.Print();
        
    }
}