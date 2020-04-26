namespace _2048WindowsFormsApp
{
    partial class UsersResultForm
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
            this.usersResultDataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersResultDataGridView
            // 
            this.usersResultDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.usersResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.userResult});
            this.usersResultDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usersResultDataGridView.Name = "usersResultDataGridView";
            this.usersResultDataGridView.RowHeadersWidth = 62;
            this.usersResultDataGridView.RowTemplate.Height = 28;
            this.usersResultDataGridView.Size = new System.Drawing.Size(463, 400);
            this.usersResultDataGridView.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя игрока";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.Width = 150;
            // 
            // userResult
            // 
            this.userResult.HeaderText = "Лучший счёт";
            this.userResult.MinimumWidth = 8;
            this.userResult.Name = "userResult";
            this.userResult.Width = 150;
            // 
            // UsersResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 424);
            this.Controls.Add(this.usersResultDataGridView);
            this.Name = "UsersResultForm";
            this.Text = "UsersResult";
            ((System.ComponentModel.ISupportInitialize)(this.usersResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userResult;
    }
}