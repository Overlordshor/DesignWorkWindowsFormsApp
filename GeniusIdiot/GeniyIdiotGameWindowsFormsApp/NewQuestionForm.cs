using GeniyIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniyIdiotGameWindowsFormsApp
{
    public partial class NewQuestionForm : Form
    {
        Game game;
        User user;
        public NewQuestionForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var text = newQuestionTextBox.Text;
            var answer = newAnswerTextBox.Text;
            if (isValid(text, answer))
            {
                game.AddNewQuestion(text, answer);
                MessageBox.Show("Вопрос успешно добавлен");
                Close();
            }
        }

        private bool isValid(string text, string answer)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Неправильный формат вопроса или ответа");
                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
