using BallGameClassLibrary;
using SnakeFormsApp;
using SnakeFormsApp.Properties;
using System.Windows.Forms;

namespace SnakeWindowsFormsApp
{
    public class Snake : PictureBall
    {
        public Snake(Form form) : base(form)
        {
            diameter = 40;
            radius = diameter / 2;
            RightBorder = form.ClientSize.Width - radius;
            DownBorder = form.ClientSize.Height - radius;
            X = random.Next(LeftBorder, RightBorder) + radius;
            Y = random.Next(TopBorder, DownBorder) + radius;
            Left = X - radius;
            Top = Y - radius;

            Width = diameter;
            Height = diameter;
            Image = Resources.Snake;
            vx = diameter;
            vy = diameter;
        }
        public void SetX(Map cell)
        {
            X = cell.X;
        }
        public void SetY(Map cell)
        {
            Y = cell.Y;
        }
        public void MoveX()
        {
            X += vx;
            if (X > RightBorder)
            {
                X = LeftBorder;
            }

            if (X < LeftBorder)
            {
                X = RightBorder;
            }
            Draw();
        }

        public void MoveY()
        {
            Y += vy;

            if (Y > DownBorder)
            {
                Y = TopBorder;
            }

            if (Y < TopBorder)
            {
                Y = DownBorder;
            }
            Draw();
        }

        public void SetCoordinate(Snake snake)
        {
            X = snake.X;
            Y = snake.Y;
        }
    }
}