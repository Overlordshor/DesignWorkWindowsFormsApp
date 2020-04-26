namespace _2048WindowsFormsApp
{
    partial class RestartGameForm
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
            this.newOrOldUserlabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newOrOldUserlabel
            // 
            this.newOrOldUserlabel.AutoSize = true;
            this.newOrOldUserlabel.Location = new System.Drawing.Point(32, 43);
            this.newOrOldUserlabel.Name = "newOrOldUserlabel";
            this.newOrOldUserlabel.Size = new System.Drawing.Size(158, 13);
            this.newOrOldUserlabel.TabIndex = 0;
            this.newOrOldUserlabel.Text = "Вы хотите ввести новое имя?";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(34, 81);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.noButton.Location = new System.Drawing.Point(115, 81);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "Отмена";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // RestartGameForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noButton;
            this.ClientSize = new System.Drawing.Size(236, 133);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.newOrOldUserlabel);
            this.Name = "RestartGameForm";
            this.Text = "Начать заново";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newOrOldUserlabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button noButton;
    }
}