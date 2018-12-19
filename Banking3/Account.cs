using System;
using SplashKitSDK;

public class Account
{
    private decimal _balance;
    private string _name;

    public Account(string name, decimal startingBalance)
    {
        _name = name;
        _balance = startingBalance;
    }
    public bool Deposit(decimal amountToDeposit)
    {
        if (amountToDeposit > 0)
        {
            _balance = _balance + amountToDeposit;
            Console.WriteLine("New balance : " + _balance);
            return true;
        }
        else
        {
            Console.WriteLine("No negative deposits");
            return false;
        }

    }


    public bool Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw < _balance)
        {
            _balance = _balance - amountToWithdraw;
            Console.WriteLine("New balance : " + _balance);
            return true;
        }
        else
        {
            Console.WriteLine("No sufficient funds");
            return false;
        }
    }


    public void Print()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_balance);
    }

}