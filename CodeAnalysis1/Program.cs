using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
       int a, b, c, d, e;
 a = 10;
 b = 20;
 c = 30;
 d = a;
 e = 50;
b = a;
a = a + b; 
c = e - c;
 d = a;
e = e - 1;
Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");


    }
}
