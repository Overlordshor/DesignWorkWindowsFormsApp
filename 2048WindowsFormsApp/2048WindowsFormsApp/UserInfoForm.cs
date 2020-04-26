using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class UserInfoForm : Form
    {
        public string UserName;
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UserName = userNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Введите имя игрока");
            }
            else
            {
                MessageBox.Show(RulesGame());
                Close();
            }
        }

        public static string RulesGame()
        {
            return "C помощью нажатия на клавиши стрелок, перемещайте и объединяйте плитки одного номинала. За объединения плиток Вы получаете очки. Приятной игры!";
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RulesGame());
            Close();
        }
    }
}
