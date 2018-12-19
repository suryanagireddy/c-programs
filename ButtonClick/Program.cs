using System;
using SplashKitSDK;

public class Program
{
    public static void Main(string[] args)
    {
        Window testWindow = new Window("Test Window", 800, 600);
        Color clr;

        clr = Color.White;

        do
        {
            SplashKit.ProcessEvents();

            if ( ButtonClicked(50, 50, 100, 30) )
            {
                clr = Color.RandomRGB(255);
            }

            testWindow.Clear(clr);
            testWindow.FillRectangle(Color.Gray, 50, 50, 100, 30);
            testWindow.DrawText("Click Me", Color.Black, 60, 60);
            
            testWindow.Refresh(60);
        } while ( ! testWindow.CloseRequested );
    }

    private static bool ButtonClicked(int x, int y, int width, int height)
    {
        double mx, my;
        mx = SplashKit.MouseX();
        my = SplashKit.MouseY();

        int buttonRight, buttonBottom;

        buttonRight = x + width;
        buttonBottom = y + height;

        

        if ( SplashKit.MouseClicked(MouseButton.LeftButton) && mx >= x && mx <= buttonRight && my >= y && my <= buttonBottom )
        {
            return true;
        }

        return false;
    }
}

