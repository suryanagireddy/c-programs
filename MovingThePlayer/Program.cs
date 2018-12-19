using System;
using SplashKitSDK;


public class Program
{
    static void Main(string[] args)
    {
        Window gameWindow = new Window("Robot Dodge", 800, 600);
        Player p = new Player(gameWindow);
        bool quit;
        do
        {
            SplashKit.ProcessEvents();
            gameWindow.Clear(Color.Yellow);
            p.HandleInput();
            p.StayOnWindow(gameWindow, p);
            p.Draw();
            quit = p.DoQuit();
            gameWindow.Refresh(60);
        } while (!gameWindow.CloseRequested && (quit != true));
    }
}
