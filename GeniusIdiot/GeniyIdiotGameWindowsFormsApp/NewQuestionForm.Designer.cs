namespace GeniyIdiotGameWindowsFormsApp
{
    partial class NewQuestionForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addQuestuonLabel = new System.Windows.Forms.Label();
            this.newQuestionTextBox = new System.Windows.Forms.TextBox();
            this.addAnswerLabel = new System.Windows.Forms.Label();
            this.newAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(57, 312);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(146, 58);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(608, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 58);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addQuestuonLabel
            // 
            this.addQuestuonLabel.AutoSize = true;
            this.addQuestuonLabel.Location = new System.Drawing.Point(53, 72);
            this.addQuestuonLabel.Name = "addQuestuonLabel";
            this.addQuestuonLabel.Size = new System.Drawing.Size(184, 20);
            this.addQuestuonLabel.TabIndex = 2;
            this.addQuestuonLabel.Text = "Введите новый вопрос";
            // 
            // newQuestionTextBox
            // 
            this.newQuestionTextBox.Location = new System.Drawing.Point(57, 112);
            this.newQuestionTextBox.Name = "newQuestionTextBox";
            this.newQuestionTextBox.Size = new System.Drawing.Size(697, 26);
            this.newQuestionTextBox.TabIndex = 3;
            // 
            // addAnswerLabel
            // 
            this.addAnswerLabel.AutoSize = true;
            this.addAnswerLabel.Location = new System.Drawing.Point(53, 189);
            this.addAnswerLabel.Name = "addAnswerLabel";
            this.addAnswerLabel.Size = new System.Drawing.Size(204, 20);
            this.addAnswerLabel.TabIndex = 4;
            this.addAnswerLabel.Text = "Введите ответ на вопрос";
            // 
            // newAnswerTextBox
            // 
            this.newAnswerTextBox.Location = new System.Drawing.Point(57, 223);
            this.newAnswerTextBox.Name = "newAnswerTextBox";
            this.newAnswerTextBox.Size = new System.Drawing.Size(693, 26);
            this.newAnswerTextBox.TabIndex = 5;
            // 
            // NewQuestionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newAnswerTextBox);
            this.Controls.Add(this.addAnswerLabel);
            this.Controls.Add(this.newQuestionTextBox);
            this.Controls.Add(this.addQuestuonLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "NewQuestionForm";
            this.Text = "NewQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addQuestuonLabel;
        private System.Windows.Forms.TextBox newQuestionTextBox;
        private System.Windows.Forms.Label addAnswerLabel;
        private System.Windows.Forms.TextBox newAnswerTextBox;
    }
}