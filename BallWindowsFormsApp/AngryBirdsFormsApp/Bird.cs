using AngryBirdsFormsApp.Properties;
using BallGameClassLibrary;
using System.Windows.Forms;

namespace AngryBirdsFormsApp
{
    class Bird : PictureBall
    {
        public int Hit;
        private int g = 2;
        private int resistanceForce;
        private readonly Pig pig;
        public Bird(Form form, Pig pig) : base(form)
        {
            this.form = form;
            this.pig = pig;
            diameter = 50;
            Width = diameter;
            Height = diameter;
            Image = Resources.bird;
            X = diameter;
            Y = form.ClientSize.Height - 2 * diameter;
            Top = Y;
            Left = X;
        }
        public void SetMouseFly(int mouseX, int mouseY)
        {
            vx = mouseX / 20;
            vy = -50 + mouseY / 10;
        }
        private void CheckHitGround()
        {
            if (Top >= form.ClientSize.Height - diameter)
            {
                ChangeVerticalDirection();
                vy = 0;
                g = 0;
                resistanceForce = 2;
            }
        }
        private void ActPhysics()
        {
            vx -= resistanceForce;
            vy += g;
            if (vx <= 0)
            {
                Stop();
                pig.TimerNextRound.Start();
            }
        }
        private void CheckClash()
        {
            for (int i = 0; i < diameter; i++)
            {
                for (int j = 0; j < pig.GetDiameter(); j++)
                {
                    if (X + i == pig.X + j)
                    {
                        for (int k = 0; k < diameter; k++)
                        {
                            for (int l = 0; l < pig.GetDiameter(); l++)
                            {
                                if (Y + k == pig.Y + l)
                                {
                                    Stop();
                                    form.Controls.Remove(this);
                                    pig.Image = pig.ImageBrokenPig;
                                    pig.TurnOnTimerDelete();
                                    Hit++;
                                    return;
                                }
                            }
                        }
                    }
                }
            }

        }
        protected override void Go()
        {
            CheckHitGround();
            X += vx;
            Y += vy;
            Draw();
            ActPhysics();
            CheckClash();
        }


    }
}
