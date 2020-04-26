using BallGameClassLibrary.Properties;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class CarbonDioxide : PictureBall
    {
        public CarbonDioxide(Form form) : base(form)
        {
            Name = "Углекислый газ";
            diameter = 32;
            Width = diameter;
            Height = diameter;
            X = random.Next(0 + radius, form.ClientSize.Width / 2 - radius);
            Image = Resources.molecule_CO2;
            vx = random.Next(14) * direction;
            vy = (14 - vx) * direction;
        }
    }
}

