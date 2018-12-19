using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window gameWindow = new Window(" Robot Dodge", 800, 600);
        Player p = new Player(gameWindow);

        gameWindow.Clear(Color.Yellow);
        p.Draw();
        gameWindow.Refresh(60);
        SplashKit.Delay(10000);
    }
}