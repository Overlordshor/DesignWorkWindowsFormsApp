using System.Collections.Generic;
using System.Windows.Forms;

namespace SalutFormsApp
{
    public class SalutGame
    {
        public static List<Shell> Shells = new List<Shell>();

        private readonly int CountShells;
        private readonly Form form;
        private Shell shell;

        public SalutGame(Form form)
        {
            this.form = form;
            CountShells = 15;
        }



        public void StartAllShells()
        {
            for (int i = 0; i < Shells.Count; i++)
            {
                Shells[i].Start();
            }
        }
        public void ClearForm()
        {
            for (int i = 0; i < Shells.Count; i++)
            {
                Shells[i].Stop();
                Shells[i].Delete();
            }
            Shells.Clear();
        }
        public void CreateShells(int mouseX, int mouseY)
        {
            for (int i = 0; i < CountShells; i++)
            {
                shell = new Shell(form, mouseX, mouseY);
                AddShell(shell);
            }
        }
        private void AddShell(Shell shell)
        {
            Shells.Add(shell);
            shell.Draw();
        }
    }
}
