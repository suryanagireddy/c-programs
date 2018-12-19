using System;
using SplashKitSDK;

public class Program
{


    public static void Main()
    {


        Account account = new Account("suryas account", 400);

        MenuOption userSelection;
        do
        {
            userSelection = ReadUserOption();
            switch (userSelection)
            {
                case MenuOption.Deposit:
                    DoDeposit(account);
                    break;

                case MenuOption.Withdraw:
                    DoWithdraw(account);
                    break;

                case MenuOption.Print:
                    DoPrint(account);
                    break;
            }
        } while (userSelection != MenuOption.Quit);
        Console.WriteLine(userSelection);
    }


    private static MenuOption ReadUserOption()
    {
        int option;
        Console.WriteLine("**Select Option**");
        Console.WriteLine("1 - Deposit");
        Console.WriteLine("2 - Withdraw");
        Console.WriteLine("3 - Print");
        Console.WriteLine("4 - Quit");
        try
        {
            do
            {
                Console.Write("Choose an option :");
                string optionText = Console.ReadLine();
                option = Convert.ToInt32(optionText);
            } while (option < 1 || option > 4);


        }
        catch
        {
            option = -1;
        }

        return (MenuOption)(option - 1);
    }

    public static void DoDeposit(Account account)
    {

        Console.WriteLine("Enter the amount to deposit :");
        decimal x = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(x);
    }

    public static void DoWithdraw(Account account)
    {

        Console.WriteLine("Enter the amount to Withdraw :");
        decimal y = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(y);
    }

    public static void DoPrint(Account account)
    {
        Console.WriteLine("Account details");
        account.Print();
    }



}

public enum MenuOption
{
    Deposit,
    Withdraw,

    Print,
    Quit
}