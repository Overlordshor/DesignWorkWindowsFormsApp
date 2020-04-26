using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotGameWindowsFormsApp
{
    public partial class DeleteQuestion : Form
    {
        Game game;
        private List<Question> Questions;
        public DeleteQuestion(Game game)
        {
            InitializeComponent();
            this.game = game;
            Questions = Question.GetQuestionsFromFile();
            CreateListQuestions(Questions);
            
            
        }
        private void CreateListQuestions(List<Question> questions)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                QuestionListBox.Items.Add(questions[i].Text);
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            RemoveQuestion(Questions);
        }

        private void RemoveQuestion(List<Question> questions)
        {
            int indexQuestion = QuestionListBox.SelectedIndex;
            QuestionListBox.Items.RemoveAt(indexQuestion);
            questions.RemoveAt(indexQuestion);
            game.QuestionsSaveToFile(questions);
        }
    }
}
