using BallGameClassLibrary;
using System;
using System.Windows.Forms;

namespace DiffusionFormsApp
{
    public partial class MainForm : Form
    {
        private Diffusion diffusion;

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            diffusion = new Diffusion();
            diffusion.ClearForm();
            diffusion.CreateMoleculesOxygen(this);
            diffusion.CreateMoleculesCarbonDioxide(this);
            EndDiffusionTimer.Start();

            rulesLabel.Text = "Нажмитие на поле ЛКМ, чтобы начать диффузию";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rulesLabel.Text = null;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (Diffusion.GasMolecules.Count != 0 && diffusion.Molecule.Timer.Enabled == true)
            {
                StopDiffusion();
                return;
            }
            if (Diffusion.GasMolecules.Count != 0 && diffusion.Molecule.Timer.Enabled == false)
            {
                diffusion?.StartAllMolecules();
                rulesLabel.Text = "Нажмитие на поле ЛКМ, чтобы остановить диффузию и узнать давление газов";
            }
        }

        private void EndDiffusionTimer_Tick(object sender, EventArgs e)
        {
            if (diffusion.End())
            {
                StopDiffusion();
                EndDiffusionTimer.Stop();
                MessageBox.Show("Диффузия закончилась");
            }
        }
        private void StopDiffusion()
        {
            diffusion?.StopAllMolecules();
            rulesLabel.Text = "Давление Кислорода - " + diffusion.CountHitOxygen + ", давление Углекислого газа - " + diffusion.CountHitCarbonDioxide;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ball = new Oxygen(this);
            ball.Start();
        }
    }
}
