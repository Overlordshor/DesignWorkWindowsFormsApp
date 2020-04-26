using BallGameClassLibrary;
using SalutFormsApp.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace SalutFormsApp
{
    public class Shell : PictureBall
    {
        public Brush BrushTrack;
        private readonly int speed;
        private readonly int g;

        public Shell(Form form, int mousePositionX, int mousePositionY) : base(form)
        {
            this.form = form;

            diameter = 20;
            speed = 40;
            g = 3;
            X = mousePositionX + radius;
            Y = mousePositionY + radius;
            Top = X;
            Left = Y;
            Image = TakeRandomImage();
            Width = diameter;
            Height = diameter;
            vx = random.Next(-15, 15);
            vy = -speed + g;
        }
        private Bitmap TakeRandomImage()
        {
            var indexFriut = random.Next(1, 7);
            Bitmap image = null;
            switch (indexFriut)
            {
                case 1:
                    image = Resources.Color1;
                    break;
                case 2:
                    image = Resources.Color2;
                    break;
                case 3:
                    image = Resources.Color3;
                    break;
                case 4:
                    image = Resources.Color4;
                    break;
                case 5:
                    image = Resources.Color5;
                    break;
                case 6:
                    image = Resources.Color6;
                    break;
                case 7:
                    image = Resources.Color7;
                    break;
            }
            return image;
        }

        protected override void Go()
        {
            X += vx;
            Y += vy;

            Draw();
            vy += g;
        }
    }
}
