using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class UsersResultForm : Form
    {
        private List<UserResult> userResults;
        public UsersResultForm(List<UserResult> UserResults)
        {
            InitializeComponent();
            userResults = UserResults;
            ResultShow();
        }

        private void ResultShow()
        {
            foreach (var userResult in userResults)
            {
                usersResultDataGridView.Rows.Add(userResult.Name, userResult.Result);
            }
        }
    }
}
