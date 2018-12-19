using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        MenuOption userSelection;
        do
        {
            userSelection = ReadUserOption();
            switch (userSelection)
            {
                case MenuOption.TestName:
                    TestName();
                    break;

                case MenuOption.GuessThatNumber:
                    RunGuessThatNumber();
                    break;
            }
        } while (userSelection != MenuOption.Quit);
        Console.WriteLine(userSelection);
    }

    private static MenuOption ReadUserOption()
    {
        int option;
        Console.WriteLine("**Select Option**");
        Console.WriteLine("==1 - Run the Test Name==");
        Console.WriteLine("==2 - Play Guess That Number==");
        Console.WriteLine("==3 - will Quit==");
        try
        {
            do
            {
                Console.Write("Choose an option :");
                string optionText = Console.ReadLine();
                option = Convert.ToInt32(optionText);
            } while (option < 1 || option > 3);


        }
        catch
        {
            Console.WriteLine("Wrong enter");
            option = -1;
        }

        return (MenuOption)(option - 1);
    }

    public static void TestName()
    {
        string name;
        Console.Write("Please enter your name:");
        name = Console.ReadLine();

        if (name.ToLower() == "andrew")
        {
            Console.WriteLine("Welcome my creator!");
        }
        else if (name.ToLower() == "surya")
        {
            Console.WriteLine("Welcome my programmer!");
        }
        else
        {
            Console.WriteLine("Hey!! " + name);
        }
    }

    public static void RunGuessThatNumber()
    {
        int target, guess, lowestguess, highestguess;
        lowestguess = 1;
        highestguess = 100;
        target = new Random().Next(100) + 1;
        Console.WriteLine("Guess a number between 1 and 100");

        do
        {
            guess = ReadGuess(lowestguess, highestguess);

            if (guess < target)
            {
                Console.WriteLine("lowestguess");
            }
            else if (guess > target)
            {
                Console.WriteLine("highestguess");
            }
            else if (guess == target)
            {
                Console.WriteLine("Guessed the number");
            }
        } while (guess != target);

    }

    private static int ReadGuess(int min, int max)
    {
        Console.WriteLine("Enter the guess ");
        int option;
        try
        {
            do
            {
                string optiontext = Console.ReadLine();
                option = Convert.ToInt32(optiontext);

            } while (option < min || option > max);

        }
        catch
        {
            option = -1;
        }
        return option;
    }


}

public enum MenuOption
{
    TestName,
    GuessThatNumber,
    Quit
}