using GeniyIdiotCommon;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotGameWindowsFormsApp
{
    public partial class UserResultsForm : Form
    {
        public List<UserResult> UserResults;
        public UserResultsForm(List<UserResult> UserResults)
        {
            InitializeComponent();
            this.UserResults = UserResults;
            ResultsShow();
        }

        private void ResultsShow()
        {
            foreach (var userResult in UserResults)
            {
                userResultDataGridView.Rows.Add(userResult.Name, userResult.CountRightAnswer, userResult.Diagnose);
            }
        }
    }
}
