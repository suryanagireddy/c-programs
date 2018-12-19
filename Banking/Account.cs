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
    public void Deposit(decimal amountToAdd)
    {
        _balance = _balance + amountToAdd;
    }
    public void Withdraw(decimal amountToSubract)
    {
        _balance = _balance - amountToSubract;
    }
    public void Print()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_balance);
    }

}