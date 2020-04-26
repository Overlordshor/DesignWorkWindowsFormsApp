namespace _2048WindowsFormsApp
{
    partial class MapSizeForm
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
            this.сonditionsLabel = new System.Windows.Forms.Label();
            this.mapSizeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(31, 93);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(161, 93);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // сonditionsLabel
            // 
            this.сonditionsLabel.AutoSize = true;
            this.сonditionsLabel.Location = new System.Drawing.Point(12, 45);
            this.сonditionsLabel.Name = "сonditionsLabel";
            this.сonditionsLabel.Size = new System.Drawing.Size(166, 13);
            this.сonditionsLabel.TabIndex = 3;
            this.сonditionsLabel.Text = "Длина стороны квадрата поля:";
            // 
            // mapSizeComboBox
            // 
            this.mapSizeComboBox.FormattingEnabled = true;
            this.mapSizeComboBox.Items.AddRange(new object[] {
            "3 х 3",
            "4 х 4",
            "5 х 5",
            "6 х 6",
            "7 х 7",
            "8 х 8",
            "9 х 9",
            "10 х 10"});
            this.mapSizeComboBox.Location = new System.Drawing.Point(184, 42);
            this.mapSizeComboBox.Name = "mapSizeComboBox";
            this.mapSizeComboBox.Size = new System.Drawing.Size(54, 21);
            this.mapSizeComboBox.TabIndex = 4;
            // 
            // MapSizeForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(258, 139);
            this.Controls.Add(this.mapSizeComboBox);
            this.Controls.Add(this.сonditionsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "MapSizeForm";
            this.Text = "Размер поля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label сonditionsLabel;
        private System.Windows.Forms.ComboBox mapSizeComboBox;
    }
}