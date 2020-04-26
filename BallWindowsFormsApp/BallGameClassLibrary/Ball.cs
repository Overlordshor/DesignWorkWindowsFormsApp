using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class Ball
    {
        public static int ChoiseDifficulty = 1;
        public int CountFindBall;
        public static List<Ball> Balls = new List<Ball>();
        public int CountHitTop;
        public int CountHitBottom;
        public int CountHitLeft;
        public int CountHitRight;
        public int CountBalls;
        public event EventHandler<HitEventArgs> OnHited;
        public Timer Timer;
        public Brush BrushBall;
        public int radius;


        private readonly Graphics graphics;


        protected Ball ball;
        protected int vx;
        protected int vy;
        protected Form form;
        protected Rectangle rectangle;
        protected int diameter;
        protected static Random random = new Random();


        public int X { get; protected set; }
        public int Y { get; protected set; }

        public Ball(Form form)
        {
            this.form = form;
            diameter = CalculateDiameter();
            radius = diameter / 2;
            vx = CalculateRandomSpeed();
            vy = CalculateRandomSpeed();
            graphics = form.CreateGraphics();
            Timer = new Timer();
            Timer.Interval = 30;
            Timer.Tick += Timer_Tick;
        }
        public int GetDiameter()
        {
            return diameter;
        }
        public void Draw(Brush brush)
        {
            rectangle = new Rectangle(X - radius, Y - radius, diameter, diameter);
            graphics.FillEllipse(brush, rectangle);
        }
        public void Start()
        {
            Timer.Start();
        }
        public void Stop()
        {
            Timer.Stop();
        }
        private int CalculateDiameter()
        {
            var randomDiameter = random.Next(30, 100);
            return randomDiameter;
        }
        private static int CalculateRandomSpeed()
        {
            var randomSpeed = random.Next(-5, 5);
            return randomSpeed;
        }
        protected void ChangeHorizontalDirection()
        {
            vx *= -1;
        }
        protected void ChangeVerticalDirection()
        {
            vy *= -1;
        }
        protected virtual void Move()
        {
            Draw(Brushes.White);
            Go();
        }
        protected void CheckHit(int position, int sizeForm)
        {
            if (position == X)
            {
                if (position - radius <= 0)
                {
                    ChangeHorizontalDirection();
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Left));
                }
                if (position >= sizeForm - radius)
                {
                    ChangeHorizontalDirection();
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Right));
                }
            }
            if (position == Y)
            {
                if (position - radius <= 0)
                {
                    ChangeVerticalDirection();
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Top));
                }
                if (position >= sizeForm - radius)
                {
                    ChangeVerticalDirection();
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Bottom));
                }
            }
        }
        protected virtual void Go()
        {
            X += vx;
            Y += vy;
            if (Y > 2 * form.ClientSize.Height)
            {
                Stop();
            }
        }
        protected virtual void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
    }
}

