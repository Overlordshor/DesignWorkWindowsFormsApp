using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaFormsApp
{
    public partial class FruitNinjaForm : Form
    {
        private static readonly Random random = new Random();
        private int countFruits;
        private readonly List<Fruit> fruits = new List<Fruit>();
        private Fruit fruit;

        public FruitNinjaForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            FruitTimer.Start();
        }

        private void FruitTimer_Tick(object sender, EventArgs e)
        {
            CreateFruits();
            FruitTimer.Interval = random.Next(3000, 3500);
        }
        private void CreateFruits()
        {
            fruits.Clear();
            countFruits = random.Next(2, 5);
            for (int i = 0; i < countFruits; i++)
            {
                fruit = new Fruit(this);
                fruit.Start();
                fruits.Add(fruit);
            }
        }

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            fruit?.Fruit_MouseMove(sender, e);
        }
    }
}
