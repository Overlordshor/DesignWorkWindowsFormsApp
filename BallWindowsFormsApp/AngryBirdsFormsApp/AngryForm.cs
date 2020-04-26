using AngryBirdsFormsApp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsFormsApp
{
    public partial class AngryForm : Form
    {
        public Timer timerNextRound;
        private int score;
        private Bird bird;
        private Pig pig;
        private PictureBox backGround;
        public AngryForm()
        {
            InitializeComponent();
            timerNextRound = new Timer();
            timerNextRound.Interval = 100;
            timerNextRound.Tick += timerNextRound_Tick;
        }

        private void timerNextRound_Tick(object sender, EventArgs e)
        {
            NextRound();
        }

        private void AngryForm_Load(object sender, EventArgs e)
        {
            AddPig();
            AddBird();
            CreateBackGround();
        }

        private void AddBird()
        {
            bird = new Bird(this, pig);
            bird.Draw();
            bird.BringToFront();
        }

        private void AddPig()
        {
            pig = new Pig(this, timerNextRound);
            pig.Draw();
            pig.BringToFront();
        }

        private void CreateBackGround()
        {
            backGround = new PictureBox();
            Controls.Add(backGround);
            backGround.Image = Resources.background;
            backGround.SendToBack();
            backGround.Size = ClientSize;
            backGround.SizeMode = PictureBoxSizeMode.StretchImage;
            backGround.BackColor = Color.Transparent;
            backGround.MouseClick += BackGround_MouseClick;
        }

        private void BackGround_MouseClick(object sender, MouseEventArgs e)
        {
            bird.SetMouseFly(e.X, e.Y);
            bird.Start();
        }
        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextRound();
        }
        private void NextRound()
        {
            score += bird.Hit;
            scoreLabel.Text = "Количество попаданий: " + score;
            Controls.Remove(pig);
            Controls.Remove(bird);
            AddPig();
            AddBird();
            timerNextRound.Stop();
        }
    }
}
