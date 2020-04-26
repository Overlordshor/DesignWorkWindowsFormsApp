using BallGameClassLibrary.Properties;
using System;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class PictureBall : PictureBox
    {
        public event EventHandler<HitEventArgs> OnHited;
        public int vx;
        public int vy;

        protected Form form;

        protected static Random random = new Random();
        protected int diameter;
        protected int radius;
        protected int direction;
        protected int LeftBorder;
        protected int RightBorder;
        protected int TopBorder;
        protected int DownBorder;

        public int X { get; protected set; }
        public int Y { get; protected set; }
        public Timer Timer { get; private set; }
        public PictureBall(Form form)
        {
            this.form = form;

            diameter = CalculateDiameter();
            radius = diameter / 2;

            Width = diameter;
            Height = diameter;
            Image = Resources.molecule_O2;
            SizeMode = PictureBoxSizeMode.StretchImage;

            LeftBorder = 0;
            RightBorder = form.ClientSize.Width - radius;
            TopBorder = 0;
            DownBorder = form.ClientSize.Height - radius;
            X = random.Next(LeftBorder, RightBorder);
            Y = random.Next(TopBorder, DownBorder);
            Left = X;
            Top = Y;

            form.Controls.Add(this);
            BringToFront();

            direction = GetRandomDirection();
            vx = CalculateRandomSpeed() * direction;
            vy = CalculateRandomSpeed() * direction;

            Timer = new Timer();
            Timer.Interval = 30;
            Timer.Tick += Timer_Tick;
        }
        public void Delete()
        {
            Dispose();
        }
        public bool IntersectCircle(PictureBall other)
        {
            var dx = X - other.X;
            var dy = Y - other.Y;
            var length = Math.Sqrt(dx * dx + dy * dy);
            return length < radius + other.radius;
        }
        public bool IntersectSquare(PictureBall other)
        {
            for (int i = 0; i < diameter; i++)
            {
                for (int j = 0; j < other.diameter; j++)
                {
                    if (X + i == other.X + j)
                    {
                        for (int k = 0; k < diameter; k++)
                        {
                            for (int l = 0; l < other.diameter; l++)
                            {
                                if (Y + k == other.Y + l)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
         }

        public bool IsMove()
        {
            return Timer.Enabled;
        }
        public int GetRadius()
        {
            return radius;

        }
        public void Start()
        {
            Timer.Start();
        }
        public void Stop()
        {
            Timer.Stop();
        }
        public void Draw()
        {
            Left = X;
            Top = Y;
        }
        public int GetDiameter()
        {
            return diameter;
        }
        private int CalculateDiameter()
        {
            var randomDiameter = random.Next(30, 100);
            return randomDiameter;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Go();
            СheckLeftForm();
        }
        private void СheckLeftForm()
        {
            if (Top + 2 * diameter <= 0)
            {
                Delete();
            }
            if (Top - 2 * diameter >= form.ClientSize.Height)
            {
                Delete();
            }
            if (Left + 2 * diameter <= 0)
            {
                Delete();
            }
            if (Left - 2 * diameter >= form.ClientSize.Width)
            {
                Delete();
            }
        }
        private void CheckHitWall()
        {
            if (Top <= 0)
            {
                ChangeVerticalDirection();
                OnHited?.Invoke(this, new HitEventArgs(HitType.Left));
            }
            if (Top + diameter >= form.ClientSize.Height - radius)
            {
                ChangeVerticalDirection();
                OnHited?.Invoke(this, new HitEventArgs(HitType.Right));
            }
            if (Left <= 0)
            {
                ChangeHorizontalDirection();
                OnHited?.Invoke(this, new HitEventArgs(HitType.Top));
            }
            if (Left + diameter >= form.ClientSize.Width - radius)
            {
                ChangeHorizontalDirection();
                OnHited?.Invoke(this, new HitEventArgs(HitType.Bottom));
            }
        }
        private int GetRandomDirection()
        {
            if (random.Next(2) == 1)
            {
                return direction = -1;
            }
            else
            {
                return direction = 1;
            }
        }
        protected void ChangeHorizontalDirection()
        {
            vx *= -1;
        }
        protected void ChangeVerticalDirection()
        {
            vy *= -1;
        }
        protected virtual void Go()
        {
            CheckHitWall();
            X += vx;
            Y += vy;
            Draw();
        }
        protected static int CalculateRandomSpeed()
        {
            var randomSpeed = random.Next(-5, 5);
            return randomSpeed;
        }
    }
}
