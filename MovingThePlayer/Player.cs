using System;
using SplashKitSDK;

public class Player
{
    private Bitmap _PlayerBitmap;
    public double X { get; private set; }
    public double Y { get; private set; }
    private Window _GameWindow;
    public bool quit;
    private int width;
    private int height;

    public Player(Window gameWindow)
    {
        _PlayerBitmap = new Bitmap("Player", "Player.png");
        quit = false;
        _GameWindow = gameWindow;
        X = (_GameWindow.Width / 2) - (_PlayerBitmap.Width / 2);
        Y = (_GameWindow.Height / 2) - (_PlayerBitmap.Height / 2);

        width = _PlayerBitmap.Width;
        height = _PlayerBitmap.Height;

    }

    public void HandleInput()
    {

        int boost = 3;
        if (SplashKit.KeyDown(KeyCode.LeftKey))
        {
            X = X - boost;
        }
        else if (SplashKit.KeyDown(KeyCode.RightKey))
        {
            X = X + boost;
        }
        else if (SplashKit.KeyDown(KeyCode.UpKey))
        {
            Y = Y - boost;
        }
        else if (SplashKit.KeyDown(KeyCode.DownKey))
        {
            Y = Y + boost;
        }
        else if (SplashKit.KeyDown(KeyCode.EscapeKey))
        {
            quit = true;
        }
    }

    public void StayOnWindow(Window gameWindow, Player p)
    {
        const int GAP = 10;
        if ((X + width) >= (gameWindow.Width - GAP))
        {
            X = (gameWindow.Width - GAP) - (width);

        }
        else if (X <= GAP)
        {
            X = GAP;
        }
        else if ((Y + height) >= (gameWindow.Height - GAP))
        {

            Y = ((gameWindow.Height - GAP) - (height));

        }
        else if (Y <= GAP)
        {
            Y = GAP;
        }

    }


    public void Draw()
    {
        if (quit != true)
        {
            _GameWindow.DrawBitmap(_PlayerBitmap, X, Y);
        }
        else
        {
            quit = true;
        }
    }
    public bool DoQuit()
    {
        return quit;
    }
}