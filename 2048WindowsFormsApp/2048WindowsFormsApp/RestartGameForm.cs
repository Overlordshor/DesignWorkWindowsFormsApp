using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class RestartGameForm : Form
    {
        public RestartGameForm()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            MainForm.NewName = true;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            MainForm.NewName = false;
            Close();
        }
    }
}
