namespace GeniyIdiotGameWindowsFormsApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.questionNextButton = new System.Windows.Forms.Button();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРезультатыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            resources.ApplyResources(this.questionNumberLabel, "questionNumberLabel");
            this.questionNumberLabel.Name = "questionNumberLabel";
            // 
            // questionTextLabel
            // 
            resources.ApplyResources(this.questionTextLabel, "questionTextLabel");
            this.questionTextLabel.Name = "questionTextLabel";
            // 
            // questionNextButton
            // 
            resources.ApplyResources(this.questionNextButton, "questionNextButton");
            this.questionNextButton.Name = "questionNextButton";
            this.questionNextButton.UseVisualStyleBackColor = true;
            this.questionNextButton.Click += new System.EventHandler(this.questionNextButton_Click);
            // 
            // userAnswerTextBox
            // 
            resources.ApplyResources(this.userAnswerTextBox, "userAnswerTextBox");
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьРезультатыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            resources.ApplyResources(this.показатьРезультатыToolStripMenuItem, "показатьРезультатыToolStripMenuItem");
            this.показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            resources.ApplyResources(this.файлToolStripMenuItem1, "файлToolStripMenuItem1");
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьРезультатыToolStripMenuItem1,
            this.запуститьЗановоToolStripMenuItem,
            this.выходИзИгрыToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            // 
            // показатьРезультатыToolStripMenuItem1
            // 
            resources.ApplyResources(this.показатьРезультатыToolStripMenuItem1, "показатьРезультатыToolStripMenuItem1");
            this.показатьРезультатыToolStripMenuItem1.Name = "показатьРезультатыToolStripMenuItem1";
            this.показатьРезультатыToolStripMenuItem1.Click += new System.EventHandler(this.показатьРезультатыToolStripMenuItem1_Click);
            // 
            // запуститьЗановоToolStripMenuItem
            // 
            resources.ApplyResources(this.запуститьЗановоToolStripMenuItem, "запуститьЗановоToolStripMenuItem");
            this.запуститьЗановоToolStripMenuItem.Name = "запуститьЗановоToolStripMenuItem";
            this.запуститьЗановоToolStripMenuItem.Click += new System.EventHandler(this.запуститьЗановоToolStripMenuItem_Click);
            // 
            // выходИзИгрыToolStripMenuItem
            // 
            resources.ApplyResources(this.выходИзИгрыToolStripMenuItem, "выходИзИгрыToolStripMenuItem");
            this.выходИзИгрыToolStripMenuItem.Name = "выходИзИгрыToolStripMenuItem";
            this.выходИзИгрыToolStripMenuItem.Click += new System.EventHandler(this.выходИзИгрыToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            resources.ApplyResources(this.редактированиеToolStripMenuItem, "редактированиеToolStripMenuItem");
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВопросToolStripMenuItem,
            this.удалитьВопросToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            // 
            // добавитьВопросToolStripMenuItem
            // 
            resources.ApplyResources(this.добавитьВопросToolStripMenuItem, "добавитьВопросToolStripMenuItem");
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // удалитьВопросToolStripMenuItem
            // 
            resources.ApplyResources(this.удалитьВопросToolStripMenuItem, "удалитьВопросToolStripMenuItem");
            this.удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            this.удалитьВопросToolStripMenuItem.Click += new System.EventHandler(this.удалитьВопросToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.questionNextButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionNextButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button questionNextButton;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьРезультатыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem показатьРезультатыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запуститьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВопросToolStripMenuItem;
    }
}

