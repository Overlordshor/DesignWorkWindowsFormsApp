using AngryBirdsFormsApp.Properties;
using BallGameClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsFormsApp
{
    class Pig : PictureBall
    {
        public Timer TimerNextRound;
        public Bitmap ImageBrokenPig;
        private readonly Timer timer;

        public Pig(Form form, Timer timerNextRound) : base(form)
        {
            this.form = form;
            this.TimerNextRound = timerNextRound;
            Image = Resources.pig;
            ImageBrokenPig = Resources.hitPig;
            X = random.Next(form.ClientSize.Width / 3 - radius, form.ClientSize.Width - radius);
            vx = 0;
            vy = 0;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }
        public void TurnOnTimerDelete()
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            timer.Stop();
            TimerNextRound.Start();
        }
    }
}
