using System.Windows.Forms;

namespace SalutFormsApp
{
    public partial class SalutForm : Form
    {
        public SalutForm()
        {
            InitializeComponent();
        }

        private void SalutForm_MouseDown(object sender, MouseEventArgs e)
        {
            var salut = new SalutGame(this);
            salut.ClearForm();
            salut.CreateShells(e.X, e.Y);
            salut.StartAllShells();
        }
    }
}
