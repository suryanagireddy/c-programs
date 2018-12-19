using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window makeSceneWindow;
        makeSceneWindow = new Window ("Make a Scene",800,700);

        Bitmap surya = new Bitmap("surya", "surya.png");
        SoundEffect hello = new SoundEffect("hello", "hello.wav");
        Bitmap satya = new Bitmap("satya", "satya.png");


        makeSceneWindow.Clear(Color.Green);
        makeSceneWindow.DrawBitmap(surya, 100, 200);
        makeSceneWindow.Refresh(60);

        hello.Play();

        SplashKit.Delay(5000);

        
        makeSceneWindow.Clear(Color.Green);
        makeSceneWindow.DrawBitmap(satya, 200, 500);
        makeSceneWindow.Refresh(60);

        SplashKit.Delay(6000);


    }
}
