using BallGameClassLibrary;
using System;
using System.Windows.Forms;

namespace BallWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (Game.RandomPointBalls.Count == 0)
            {
                return;
            }
            game.AddCaughtBallsMouse(e.X, e.Y);
        }
        private void легкоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.ChoiseDifficulty = 1;
        }

        private void нормальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.ChoiseDifficulty = 2;
        }

        private void сложноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.ChoiseDifficulty = 3;
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поймайте максимальное количество шаров с помощью кнопки мышки.");
        }

        private void newGameMouseButton_Click(object sender, EventArgs e)
        {

            game = new Game();
            game.ClearForm();
            game.CreateNewGame(this);
            newGameMouseButton.Enabled = false;
            checkResultButton.Enabled = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            game = new Game();
            checkResultButton.Enabled = false;
        }

        private void checkResultButton_Click(object sender, EventArgs e)
        {
            int countFindBall = game.CountFindBall;
            game.StopAllBalls();
            MessageBox.Show("Ваш результат: " + countFindBall);


            newGameMouseButton.Enabled = true;
            checkResultButton.Enabled = false;
            newGameMouseButton.Focus();
        }

        private void counterHitTimer_Tick(object sender, EventArgs e)
        {
            counterBottomLabel.Text = game.CountHitBottom.ToString();
            counterTopLabel.Text = game.CountHitTop.ToString();
            counterLeftLabel.Text = game.CountHitLeft.ToString();
            counterRightLabel.Text = game.CountHitRight.ToString();
        }
    }
}
