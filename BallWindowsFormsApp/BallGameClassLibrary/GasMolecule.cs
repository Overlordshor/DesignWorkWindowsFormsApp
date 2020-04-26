using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGameClassLibrary
{
    public class GasMolecule : Ball
    {
        protected int direction;
        protected static Random directionMove = new Random();
        protected GasMolecule molecule;
        protected List<GasMolecule> molecules = new List<GasMolecule>();
        protected Game diffusion;

        public string Name { get; protected set; }

        public GasMolecule(Form form) : base(form)
        {
            Y = random.Next(0 + radius, form.ClientSize.Height - radius);
            BrushBall = Brushes.Blue;
        }
        protected int GetRandomDirection()
        {
            if (directionMove.Next(2) == 1)
            {
                return direction = -1;
            }
            else
            {
                return direction = 1;
            }
        }
        protected override void Move()
        {
            base.Move();
            Draw(Brushes.Red);
        }
        protected override void Go()
        {
            CheckHit(X, form.ClientSize.Width);
            CheckHit(Y, form.ClientSize.Height);
            base.Go();
        }

    }
}

