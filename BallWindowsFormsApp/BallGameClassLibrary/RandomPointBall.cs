using System.Drawing;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(Form form) : base(form)
        {
            X = random.Next(0 + radius, form.ClientSize.Width - radius);
            Y = random.Next(0 + radius, form.ClientSize.Height - radius);
            BrushBall = Brushes.Blue;
        }
        protected override void Go()
        {
            CheckHit(X, form.ClientSize.Width);
            CheckHit(Y, form.ClientSize.Height);
            base.Go();
        }
        protected override void Move()
        {
            base.Move();
            Draw(Brushes.Red);
        }
    }
}
