using BallGameClassLibrary;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiffusionFormsApp
{
    public class Diffusion
    {
        public static List<PictureBall> GasMolecules = new List<PictureBall>();
        public int CountHitOxygen;
        public int CountHitCarbonDioxide;
        public PictureBall Molecule;

        private readonly int countMolecules;
        private int countOxygenDiffusion;
        private int countCarbonDioxideDiffusion;

        public Diffusion()
        {
            countMolecules = 20;
        }
        public void StartAllMolecules()
        {
            for (int i = 0; i < GasMolecules.Count; i++)
            {
                GasMolecules[i].Start();
            }
        }
        public void StopAllMolecules()
        {

            for (int i = 0; i < GasMolecules.Count; i++)
            {
                GasMolecules[i].Stop();
            }
        }
        public void ClearForm()
        {
            if (GasMolecules.Count != 0)
            {
                for (int i = 0; i < GasMolecules.Count; i++)
                {
                    GasMolecules[i].Stop();
                    GasMolecules[i].Dispose();
                }
                GasMolecules.Clear();
            }
        }

        public void CreateMolecules(PictureBall molecule)
        {
            GasMolecules.Add(molecule);
            molecule.Draw();
        }
        public void CreateMoleculesOxygen(Form form)
        {
            for (int i = 0; i < countMolecules; i++)
            {
                Molecule = new Oxygen(form);
                CreateMolecules(Molecule);
                Molecule.OnHited += Oxygen_OnHited;
            }
        }
        public void CreateMoleculesCarbonDioxide(Form form)
        {
            for (int i = 0; i < countMolecules; i++)
            {
                Molecule = new CarbonDioxide(form);
                CreateMolecules(Molecule);
                Molecule.OnHited += CarbonDioxide_OnHited;
            }
        }
        private void Oxygen_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Type)
            {
                case HitType.Top:
                    CountHitOxygen++;
                    break;
                case HitType.Bottom:
                    CountHitOxygen++;
                    break;
                case HitType.Left:
                    CountHitOxygen++;
                    countOxygenDiffusion++;
                    break;
                case HitType.Right:
                    CountHitOxygen++;
                    break;
            }
        }
        private void CarbonDioxide_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Type)
            {
                case HitType.Top:
                    CountHitCarbonDioxide++;
                    break;
                case HitType.Bottom:
                    CountHitCarbonDioxide++;
                    break;
                case HitType.Left:
                    CountHitCarbonDioxide++;
                    break;
                case HitType.Right:
                    CountHitCarbonDioxide++;
                    countCarbonDioxideDiffusion++;
                    break;
            }
        }

        public bool End()
        {
            if (countOxygenDiffusion >= countMolecules / 2 && countCarbonDioxideDiffusion >= countMolecules / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
