namespace BallWindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборУровняСложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нормальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMouseButton = new System.Windows.Forms.Button();
            this.checkResultButton = new System.Windows.Forms.Button();
            this.counterLeftLabel = new System.Windows.Forms.Label();
            this.counterTopLabel = new System.Windows.Forms.Label();
            this.counterRightLabel = new System.Windows.Forms.Label();
            this.counterBottomLabel = new System.Windows.Forms.Label();
            this.counterHitTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборУровняСложностиToolStripMenuItem,
            this.правилаИгрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборУровняСложностиToolStripMenuItem
            // 
            this.выборУровняСложностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкоToolStripMenuItem,
            this.нормальноToolStripMenuItem,
            this.сложноToolStripMenuItem});
            this.выборУровняСложностиToolStripMenuItem.Name = "выборУровняСложностиToolStripMenuItem";
            this.выборУровняСложностиToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выборУровняСложностиToolStripMenuItem.Text = "Выбор уровня сложности";
            // 
            // легкоToolStripMenuItem
            // 
            this.легкоToolStripMenuItem.Name = "легкоToolStripMenuItem";
            this.легкоToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.легкоToolStripMenuItem.Text = "Легко";
            this.легкоToolStripMenuItem.Click += new System.EventHandler(this.легкоToolStripMenuItem_Click);
            // 
            // нормальноToolStripMenuItem
            // 
            this.нормальноToolStripMenuItem.Name = "нормальноToolStripMenuItem";
            this.нормальноToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.нормальноToolStripMenuItem.Text = "Нормально";
            this.нормальноToolStripMenuItem.Click += new System.EventHandler(this.нормальноToolStripMenuItem_Click);
            // 
            // сложноToolStripMenuItem
            // 
            this.сложноToolStripMenuItem.Name = "сложноToolStripMenuItem";
            this.сложноToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.сложноToolStripMenuItem.Text = "Сложно";
            this.сложноToolStripMenuItem.Click += new System.EventHandler(this.сложноToolStripMenuItem_Click);
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила Игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // newGameMouseButton
            // 
            this.newGameMouseButton.BackColor = System.Drawing.Color.Lime;
            this.newGameMouseButton.Location = new System.Drawing.Point(485, 28);
            this.newGameMouseButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameMouseButton.Name = "newGameMouseButton";
            this.newGameMouseButton.Size = new System.Drawing.Size(88, 48);
            this.newGameMouseButton.TabIndex = 4;
            this.newGameMouseButton.Text = "Начать новую игру";
            this.newGameMouseButton.UseVisualStyleBackColor = false;
            this.newGameMouseButton.Click += new System.EventHandler(this.newGameMouseButton_Click);
            // 
            // checkResultButton
            // 
            this.checkResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkResultButton.Location = new System.Drawing.Point(403, 28);
            this.checkResultButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkResultButton.Name = "checkResultButton";
            this.checkResultButton.Size = new System.Drawing.Size(78, 50);
            this.checkResultButton.TabIndex = 5;
            this.checkResultButton.Text = "Узнать результат";
            this.checkResultButton.UseVisualStyleBackColor = false;
            this.checkResultButton.Click += new System.EventHandler(this.checkResultButton_Click);
            // 
            // counterLeftLabel
            // 
            this.counterLeftLabel.AutoSize = true;
            this.counterLeftLabel.Location = new System.Drawing.Point(13, 284);
            this.counterLeftLabel.Name = "counterLeftLabel";
            this.counterLeftLabel.Size = new System.Drawing.Size(13, 13);
            this.counterLeftLabel.TabIndex = 6;
            this.counterLeftLabel.Text = "0";
            // 
            // counterTopLabel
            // 
            this.counterTopLabel.AutoSize = true;
            this.counterTopLabel.Location = new System.Drawing.Point(284, 28);
            this.counterTopLabel.Name = "counterTopLabel";
            this.counterTopLabel.Size = new System.Drawing.Size(13, 13);
            this.counterTopLabel.TabIndex = 7;
            this.counterTopLabel.Text = "0";
            // 
            // counterRightLabel
            // 
            this.counterRightLabel.AutoSize = true;
            this.counterRightLabel.Location = new System.Drawing.Point(537, 284);
            this.counterRightLabel.Name = "counterRightLabel";
            this.counterRightLabel.Size = new System.Drawing.Size(13, 13);
            this.counterRightLabel.TabIndex = 8;
            this.counterRightLabel.Text = "0";
            // 
            // counterBottomLabel
            // 
            this.counterBottomLabel.AutoSize = true;
            this.counterBottomLabel.Location = new System.Drawing.Point(284, 539);
            this.counterBottomLabel.Name = "counterBottomLabel";
            this.counterBottomLabel.Size = new System.Drawing.Size(13, 13);
            this.counterBottomLabel.TabIndex = 9;
            this.counterBottomLabel.Text = "0";
            // 
            // counterHitTimer
            // 
            this.counterHitTimer.Enabled = true;
            this.counterHitTimer.Interval = 20;
            this.counterHitTimer.Tick += new System.EventHandler(this.counterHitTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.counterBottomLabel);
            this.Controls.Add(this.counterRightLabel);
            this.Controls.Add(this.counterTopLabel);
            this.Controls.Add(this.counterLeftLabel);
            this.Controls.Add(this.checkResultButton);
            this.Controls.Add(this.newGameMouseButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "м";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборУровняСложностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нормальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.Button newGameMouseButton;
        private System.Windows.Forms.Button checkResultButton;
        private System.Windows.Forms.Label counterLeftLabel;
        private System.Windows.Forms.Label counterTopLabel;
        private System.Windows.Forms.Label counterRightLabel;
        private System.Windows.Forms.Label counterBottomLabel;
        private System.Windows.Forms.Timer counterHitTimer;
    }
}

