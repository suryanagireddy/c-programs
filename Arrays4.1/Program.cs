using System;
using SplashKitSDK;


public class Program
{
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



    public static void Main(string[] args)
    {
        int numberOfValues;

        //Prompt the user to enter the array size.
        numberOfValues = ReadInteger("\n Please Enter The Amount Of Numbers You Want To Store: \n");
        double[] values = new double[numberOfValues];

        //Loop for accepting values into the array
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = ReadDouble($"Enter the {i + 1}st value:\n");
        }

        //Printing the array values on the console before summation.
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine("\n You entered {0}", values[i]);
        }

        //Adding All Array Values.
        double sum = 0;
        for (int x = 0; x < values.Length; x++)
        {
            sum = sum + values[x];
        }
        //Displaying the sum To The Console.
        Console.WriteLine("\n The sum of the array contents is:" + sum);

    }
}