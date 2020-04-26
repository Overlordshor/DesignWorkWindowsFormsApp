namespace _2048WindowsFormsApp
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bestResultLabel = new System.Windows.Forms.Label();
            this.usersResultLabel = new System.Windows.Forms.Label();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закончитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРазмерПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(11, 97);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(53, 52);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Счёт: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestResultLabel
            // 
            this.bestResultLabel.BackColor = System.Drawing.Color.Gold;
            this.bestResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestResultLabel.Location = new System.Drawing.Point(11, 162);
            this.bestResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bestResultLabel.Name = "bestResultLabel";
            this.bestResultLabel.Size = new System.Drawing.Size(53, 52);
            this.bestResultLabel.TabIndex = 1;
            this.bestResultLabel.Text = "Лучший счет:";
            this.bestResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersResultLabel
            // 
            this.usersResultLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.usersResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersResultLabel.Location = new System.Drawing.Point(93, 24);
            this.usersResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usersResultLabel.Name = "usersResultLabel";
            this.usersResultLabel.Size = new System.Drawing.Size(53, 52);
            this.usersResultLabel.TabIndex = 2;
            this.usersResultLabel.Text = "ТОП игроков";
            this.usersResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usersResultLabel.Click += new System.EventHandler(this.usersResultLabel_Click);
            // 
            // endGameLabel
            // 
            this.endGameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.endGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endGameLabel.Location = new System.Drawing.Point(150, 24);
            this.endGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(61, 52);
            this.endGameLabel.TabIndex = 3;
            this.endGameLabel.Text = "Закончить игру";
            this.endGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endGameLabel.Click += new System.EventHandler(this.endGameLabel_Click);
            // 
            // restartLabel
            // 
            this.restartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartLabel.Location = new System.Drawing.Point(215, 24);
            this.restartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(53, 52);
            this.restartLabel.TabIndex = 4;
            this.restartLabel.Text = "Начать заново";
            this.restartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartLabel.Click += new System.EventHandler(this.restartLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem1,
            this.режимИгрыToolStripMenuItem,
            this.правилаИгрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem1
            // 
            this.играToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьЗановоToolStripMenuItem,
            this.закончитьИгруToolStripMenuItem,
            this.выйтиИзИгрыToolStripMenuItem});
            this.играToolStripMenuItem1.Name = "играToolStripMenuItem1";
            this.играToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem1.Text = "Игра";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.начатьЗановоToolStripMenuItem.Text = "Начать заново";
            this.начатьЗановоToolStripMenuItem.Click += new System.EventHandler(this.начатьЗановоToolStripMenuItem_Click);
            // 
            // закончитьИгруToolStripMenuItem
            // 
            this.закончитьИгруToolStripMenuItem.Name = "закончитьИгруToolStripMenuItem";
            this.закончитьИгруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закончитьИгруToolStripMenuItem.Text = "Закончить игру";
            this.закончитьИгруToolStripMenuItem.Click += new System.EventHandler(this.закончитьИгруToolStripMenuItem_Click);
            // 
            // режимИгрыToolStripMenuItem
            // 
            this.режимИгрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьРазмерПоляToolStripMenuItem});
            this.режимИгрыToolStripMenuItem.Name = "режимИгрыToolStripMenuItem";
            this.режимИгрыToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.режимИгрыToolStripMenuItem.Text = "Режимы игры";
            // 
            // изменитьРазмерПоляToolStripMenuItem
            // 
            this.изменитьРазмерПоляToolStripMenuItem.Name = "изменитьРазмерПоляToolStripMenuItem";
            this.изменитьРазмерПоляToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.изменитьРазмерПоляToolStripMenuItem.Text = "Изменить размер поля";
            this.изменитьРазмерПоляToolStripMenuItem.Click += new System.EventHandler(this.изменитьРазмерПоляToolStripMenuItem_Click);
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // выйтиИзИгрыToolStripMenuItem
            // 
            this.выйтиИзИгрыToolStripMenuItem.Name = "выйтиИзИгрыToolStripMenuItem";
            this.выйтиИзИгрыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выйтиИзИгрыToolStripMenuItem.Text = "Выйти из игры";
            this.выйтиИзИгрыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзИгрыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(493, 534);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.endGameLabel);
            this.Controls.Add(this.usersResultLabel);
            this.Controls.Add(this.bestResultLabel);
            this.Controls.Add(this.scoreLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label bestResultLabel;
        private System.Windows.Forms.Label usersResultLabel;
        private System.Windows.Forms.Label endGameLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьРазмерПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закончитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзИгрыToolStripMenuItem;
    }
}

