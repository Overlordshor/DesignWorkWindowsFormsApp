using GeniyIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniyIdiotGameWindowsFormsApp
{
    public partial class Main : Form
    {
        User user;
        Game game;
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void questionNextButton_Click(object sender, EventArgs e)
        {
            game.AddUserAnswer(userAnswerTextBox.Text);

            if (game.Over())
            {
                MessageBox.Show(game.PrintDiagnose(user));
                game.AddUserResult();
                return;
            }
            var currentQuestion = game.PopRandomQuestion();
            var currentNumberQuestion = game.PrintNumberQuestion();
            questionNumberLabel.Text = currentNumberQuestion;
            questionTextLabel.Text = currentQuestion.Text;
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
        }

        private void показатьРезультатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var userResultForm = new UserResultsForm(game.LoadUserResult());
            userResultForm.Show();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newQuestionForm = new NewQuestionForm(game);
            newQuestionForm.Show();
        }
        private void Start()
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                user = new User(userInfoForm.userNameTextBox.Text);
            }
            else
            {
                user = new User();
            }
            game = new Game(user);
            var currentQuestion = game.PopRandomQuestion();
            var currentNumberQuestion = game.PrintNumberQuestion();
            questionNumberLabel.Text = currentNumberQuestion;
            questionTextLabel.Text = currentQuestion.Text;
        }

        private void запуститьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void выходИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestion = new DeleteQuestion(game);
            deleteQuestion.Show();
        }
    }
}
