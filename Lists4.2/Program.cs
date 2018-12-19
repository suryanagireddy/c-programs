using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

    public static void Main(string[] args)
    {
        Menuoption userSelection;

        do
        {
            userSelection = ReadUserOption();
            switch (userSelection)
            {
                case Menuoption.NewValue:
                    AddValueToList();
                    break;

                case Menuoption.Sum:
                    ListSum();
                    break;

                case Menuoption.Print:
                    Print();
                    break;
            }

        } while (userSelection != Menuoption.Quit);
        Console.WriteLine(userSelection);
    }

    public static Menuoption ReadUserOption()
    {
        Console.WriteLine("**Select Option*");
        Console.WriteLine("==1- To add a value==");
        Console.WriteLine("==2- To sum all entered values==");
        Console.WriteLine("==3- To print the entered values==");
        Console.WriteLine("== 4- To quit==");
        int option;
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
            Console.WriteLine("Wrong enter");
            option = -1;
        }

        return (Menuoption)(option - 1);
    }
    private static List<double> _values = new List<double>();
    public static int ReadInteger(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }
    }

    public static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid double");
            }
        }
    }

    public static void AddValueToList()
    {
        double x = ReadDouble("Please Enter The Number You Wish to add. \n");
        _values.Add(x);
    }

    public static void Print()
    {
        // Loop through List with foreach
        foreach (int item in _values)
        {
            Console.WriteLine("The number(s) you entered was:\n");
            Console.WriteLine(item); 
        }
    }

    public static void ListSum()
    {
        double sum = 0;
        sum += _values.Sum();
        Console.WriteLine("The sum of values is: \n"+ sum);
    }

}

public enum Menuoption
{
    //Enum Values.
    NewValue,
    Sum,
    Print,
    Quit,
}