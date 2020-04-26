using SnakeFormsApp.Properties;
using SnakeWindowsFormsApp;
using System.Windows.Forms;

namespace SnakeFormsApp
{
    public class Food : Snake
    {
        public Food(Form form) : base(form)
        {
            Image = Resources.Food;
            diameter = 40;
            Width = diameter;
            Height = diameter;
        }

    }
}
