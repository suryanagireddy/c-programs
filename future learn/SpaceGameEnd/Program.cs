using System;
using SplashKitSDK;

namespace CharacterDrawing1
{
    public class Program
    {
        public static void Main()
        {
            SpaceGame game = new SpaceGame();
            game.Run();
        }
    }

    public class SpaceGame
    {
        private SpaceShip _player;
        private Window _gameWindow;

        public SpaceGame()
        {
            LoadResources();
            _player = new SpaceShip { X = 110, Y = 110 };
        }

        private void LoadResources()
        {
            SplashKit.LoadBitmap("Aquarii", "Aquarii.png");
            SplashKit.LoadBitmap("Gliese", "Gliese.png");
            SplashKit.LoadBitmap("Pegasi", "Pegasi.png");
        }

        public void Run()
        {
            _gameWindow = new Window("BlastOff", 600, 600);

            while ( ! _gameWindow.CloseRequested )
            {
                Draw();
                HandleInput();
            }

            Draw();
            SplashKit.Delay(2500);

            _player.Move(100, -70);
            Draw();
            SplashKit.Delay(2500);

            _player.Rotate(60);
            Draw();
            SplashKit.Delay(2500);

            _player.Move(100, 0);
            Draw();
            SplashKit.Delay(2500);

            _gameWindow.Close();
            _gameWindow = null;

            // SplashKit.Delay(2500);
        }

        private void Draw()
        {
            _gameWindow.Clear(Color.Black);
            _player.Draw();
            _gameWindow.Refresh(60);
        }

        private void HandleInput()
        {
            SplashKit.ProcessEvents();

            // if ( SplashKit.KeyDown(KeyCode.RightKey) ) _player.Rotate(5);
            // if ( SplashKit.KeyDown(KeyCode.LeftKey) ) _player.Rotate(-5);

            // if ( SplashKit.KeyDown(KeyCode.RightKey) ) _x += 5;
            // if ( SplashKit.KeyDown(KeyCode.LeftKey) ) _x -= 5;
            // if ( SplashKit.KeyDown(KeyCode.UpKey) ) _y -= 5;
            // if ( SplashKit.KeyDown(KeyCode.DownKey) ) _y += 5;

            if ( SplashKit.KeyDown(KeyCode.UpKey) ) _player.Move(5, 0);
            if ( SplashKit.KeyDown(KeyCode.DownKey) ) _player.Move(-5, 0);
            
            if ( SplashKit.KeyDown(KeyCode.LeftShiftKey))
            {
                if ( SplashKit.KeyDown(KeyCode.LeftKey) ) _player.Move(0, -5);
                if ( SplashKit.KeyDown(KeyCode.RightKey) ) _player.Move(0, 5);
            }
            else
            {
                if ( SplashKit.KeyDown(KeyCode.LeftKey) ) _player.Rotate(-5);
                if ( SplashKit.KeyDown(KeyCode.RightKey) ) _player.Rotate(5);
            }

            if ( SplashKit.KeyTyped(KeyCode.Num1Key) ) _player.ShipKind = ShipType.Aquarii;
            if ( SplashKit.KeyTyped(KeyCode.Num2Key) ) _player.ShipKind = ShipType.Gliese;
            if ( SplashKit.KeyTyped(KeyCode.Num3Key) ) _player.ShipKind = ShipType.Pegasi; 
        }
    }

    public enum ShipType
    {
        Aquarii,
        Gliese,
        Pegasi
    }

    public class SpaceShip
    {
        private double _x, _y;
        private double _angle;
        private Bitmap _shipBitmap;

        private ShipType _kind;

        public SpaceShip()
        {
            _angle = 270;
            ShipKind = ShipType.Aquarii;
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }

        public ShipType ShipKind
        {
            get { return _kind; }
            set
            {
                _kind = value;
                SetShipBitmap();
            }
        }

        private void SetShipBitmap()
        {
            _shipBitmap = SplashKit.BitmapNamed(Enum.GetName(_kind.GetType(), _kind));
        }

        public void Rotate(double amount)
        {
            _angle = (_angle + amount) % 360;
        }

        public void Draw()
        {
            _shipBitmap.Draw(_x, _y, SplashKit.OptionRotateBmp(_angle));
        }

        public void Move(double amountForward, double amountStrafe)
        {
            Vector2D movement = new Vector2D();
            Matrix2D rotation = SplashKit.RotationMatrix(_angle);

            movement.X += amountForward;
            movement.Y += amountStrafe;

            movement = SplashKit.MatrixMultiply(rotation, movement);

            _x += movement.X;
            _y += movement.Y;
        }
    }
}
