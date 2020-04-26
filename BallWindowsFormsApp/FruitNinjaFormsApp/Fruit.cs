using BallGameClassLibrary;
using FruitNinjaFormsApp.Properties;
using System.Drawing;
using System.Windows.Forms;
namespace FruitNinjaFormsApp
{
    public class Fruit : PictureBall
    {
        private int g;

        public Fruit(Form form) : base(form)
        {
            g = 5;
            X = form.ClientSize.Width / 2;
            Y = form.ClientSize.Height + diameter;
            vx = CalculateRandomSpeed();

            Image = TakeRandomImageFriut();
            Top = X + radius;
            Left = Y + radius;
            Timer.Interval = 30;

            MouseMove += Fruit_MouseMove;
        }

        public void Fruit_MouseMove(object sender, MouseEventArgs e)
        {
            Delete();
        }

        private Bitmap TakeRandomImageFriut()
        {
            var indexFriut = random.Next(1, 5);
            Bitmap image = null;
            switch (indexFriut)
            {
                case 1:
                    image = Resources.watermelon;
                    break;
                case 2:
                    image = Resources.banana;
                    break;
                case 3:
                    image = Resources.coconut;
                    break;
                case 4:
                    image = Resources.mango;
                    break;
                case 5:
                    image = Resources.orange;
                    break;
            }
            return image;
        }

        protected override void Go()
        {
            X += vx;
            Y += vy;

            Draw();

            g += 1;
            vy = -35 + g;
        }
    }
}
