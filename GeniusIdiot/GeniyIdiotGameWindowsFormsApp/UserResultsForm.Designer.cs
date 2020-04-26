namespace GeniyIdiotGameWindowsFormsApp
{
    partial class UserResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userResultDataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRightAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIagnoseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultDataGridView
            // 
            this.userResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.CountRightAnswer,
            this.DIagnoseName});
            this.userResultDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userResultDataGridView.Name = "userResultDataGridView";
            this.userResultDataGridView.Size = new System.Drawing.Size(344, 491);
            this.userResultDataGridView.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.Name = "UserName";
            // 
            // CountRightAnswer
            // 
            this.CountRightAnswer.HeaderText = "Количество правильных ответов";
            this.CountRightAnswer.Name = "CountRightAnswer";
            // 
            // DIagnoseName
            // 
            this.DIagnoseName.HeaderText = "Диагноз";
            this.DIagnoseName.Name = "DIagnoseName";
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 515);
            this.Controls.Add(this.userResultDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRightAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIagnoseName;
    }
}