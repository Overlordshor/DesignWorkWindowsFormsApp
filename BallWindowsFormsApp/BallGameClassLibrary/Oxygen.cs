using BallGameClassLibrary.Properties;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class Oxygen : PictureBall
    {
        public Oxygen(Form form) : base(form)
        {
            Name = "Кислород";
            diameter = 30;
            Width = diameter;
            Height = diameter;
            Image = Resources.molecule_O2;
            X = random.Next(form.ClientSize.Width / 2 - radius, form.ClientSize.Width - radius);
            vx = random.Next(20) * direction;
            vy = 20 - vx * direction;
        }
    }
}
