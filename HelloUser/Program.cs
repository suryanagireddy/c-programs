using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        string name;
        double weightInKG, heightInMeters;
        int heightInCM;

        Console.WriteLine("BMI Calculator");
        Console.WriteLine("===============");
        Console.WriteLine();

        Console.Write("Enter your name:");
        name =  Console.ReadLine();

        Console.Write("Please enter your weight in kilograms:");
        string weightInKGString =Console.ReadLine();
        weightInKG = Convert.ToInt32(weightInKGString);


        Console.Write("Please enter your height in cms:");
        string heightInCMString  =Console.ReadLine();
        heightInCM = Convert.ToInt32(heightInCMString);

        heightInMeters=heightInCM/100.0;

        double BMI;
        BMI = weightInKG/(heightInMeters*heightInMeters);



        Console.WriteLine("Hey !"+ name + "  Your height in meters :"+ heightInMeters + " your BMI value is :"+ BMI );

    }

}
