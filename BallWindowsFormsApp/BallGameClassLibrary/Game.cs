using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class Game
    {
        public static int ChoiseDifficulty = 1;
        public int CountFindBall;
        public static List<RandomPointBall> RandomPointBalls = new List<RandomPointBall>();
        public int CountHitTop;
        public int CountHitBottom;
        public int CountHitLeft;
        public int CountHitRight;

        private int CountBalls;
        private static int OldCountBalls;
        private RandomPointBall randomPointBall;

        public Game()
        {
            CountBalls = ChooseDifficulty();
        }

        public void StopAllBalls()
        {
            for (int i = 0; i < CountBalls; i++)
            {
                RandomPointBalls[i].Stop();
            }
        }
        public void ClearForm()
        {
            if (RandomPointBalls.Count != 0)
            {
                for (int i = 0; i < OldCountBalls; i++)
                {
                    RandomPointBalls[i].Draw(Brushes.White);
                }
                RandomPointBalls.Clear();
            }
            OldCountBalls = CountBalls;
        }
        public bool CheckMoveBalls()
        {
            bool moveBalls = false;
            foreach (var randomPointBall in RandomPointBalls)
            {
                if (randomPointBall.Timer.Enabled == true)
                {
                    return moveBalls = true;
                }
            }
            return moveBalls;
        }
        public void CreateNewGame(Form form)
        {
            for (int i = 0; i < CountBalls; i++)
            {
                randomPointBall = new RandomPointBall(form);
                RandomPointBalls.Add(randomPointBall);
                randomPointBall.OnHited += RandomPointBall_OnHited;
                randomPointBall.Start();
            }
        }
        public int GetCaughtBalls(Form form)
        {
            int countFindBall = 0;
            for (int i = 0; i < CountBalls; i++)
            {
                RandomPointBalls[i].Stop();
                if (FindBallInForm(form, i) == true)
                {
                    countFindBall++;
                }
            }
            return countFindBall;
        }
        public void AddCaughtBallsMouse(int mouseX, int mouseY)
        {
            if (ClickBallInForm(mouseX, mouseY))
            {
                CountFindBall++;
            }
        }
        public bool FindBallInForm(Form form, int i)
        {
            bool success = false;
            int currentPositionX = RandomPointBalls[i].X;
            int currentPositionY = RandomPointBalls[i].Y;
            int diameter = RandomPointBalls[i].GetDiameter();
            if (currentPositionX > 0 && currentPositionX < form.ClientSize.Width - diameter && currentPositionY > 0 && currentPositionY < form.ClientSize.Height - diameter)
            {
                success = true;
            }
            return success;
        }
        public bool CheckBallsInForm(Form form)
        {
            bool ballsInForm = false;
            for (int i = 0; i < RandomPointBalls.Count; i++)
            {
                ballsInForm = FindBallInForm(form, i);
                if (ballsInForm == true)
                {
                    break;
                }
            }
            return ballsInForm;
        }
        private void RandomPointBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Type)
            {
                case HitType.Top:
                    CountHitTop++;
                    break;
                case HitType.Bottom:
                    CountHitBottom++;
                    break;
                case HitType.Left:
                    CountHitLeft++;
                    break;
                case HitType.Right:
                    CountHitRight++;
                    break;
            }
        }
        private int ChooseDifficulty()
        {
            switch (ChoiseDifficulty)
            {
                case 1: CountBalls = 10; return CountBalls;
                case 2: CountBalls = 20; return CountBalls;
                case 3: CountBalls = 30; return CountBalls;
                default: CountBalls = 10; return CountBalls;
            }
        }
        private bool ClickBallInForm(int mouseX, int mouseY)
        {
            bool success = false;
            foreach (var randomPointBall in RandomPointBalls)
            {
                int currentPositionX = randomPointBall.X;
                int currentPositionY = randomPointBall.Y;
                int currentPositionMouseX = mouseX;
                int currentPositionMouseY = mouseY;
                int radiusBall = randomPointBall.GetDiameter() / 2;
                if ((currentPositionX - currentPositionMouseX) * (currentPositionX - currentPositionMouseX) + (currentPositionY - currentPositionMouseY) * (currentPositionY - currentPositionMouseY) <= radiusBall * radiusBall)
                {
                    randomPointBall.Stop();
                    success = true;
                }
            }
            return success;
        }
    }
}
