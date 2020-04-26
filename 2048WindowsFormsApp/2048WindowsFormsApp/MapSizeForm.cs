using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MapSizeForm : Form
    {
        public MapSizeForm()
        {
            InitializeComponent();
            var currentMapSize = MainForm.MapSize;
            mapSizeComboBox.Text = currentMapSize + " x " + currentMapSize;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var userMapSize = Convert.ToString(mapSizeComboBox.Text[0]);
            var newMapSize = int.Parse(userMapSize);
            if (newMapSize == 1)
            { newMapSize = 10; }
            MainForm.MapSize = newMapSize;
            MessageBox.Show("Размер принят. Новое поле: " + mapSizeComboBox.Text);
                Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
