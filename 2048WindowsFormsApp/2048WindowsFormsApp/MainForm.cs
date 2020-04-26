using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public static bool NewName;
        public static int MapSize = 4;
        private int lastMapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score;
        private User user;
        private UserResult userResult;
        private bool gameOver = false;
        private int countEmptyClicks = 0;
        private int bestResult;

        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddNewUser();
            StartGame();
        }

        // Методы кнопок MainForm();
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                MessageBox.Show(GetGameOverText());
                GameOver();
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Right: PressKeyRight(); break;
                case Keys.Left: PressKeyLeft(); break;
                case Keys.Up: PressKeyUp(); break;
                case Keys.Down: PressKeyDonw(); break;
            }
            scoreLabel.Text = "Cчёт: " + score.ToString();
            if (bestResult < user.Result)
            {
                bestResultLabel.Text = "Лучший счёт: " + user.Result;
            }

            if (CheckEmptyTiles() == false)
            {
                CountGameOver();
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Right: GenerateNumber(); break;
                case Keys.Left: GenerateNumber(); break;
                case Keys.Up: GenerateNumber(); break;
                case Keys.Down: GenerateNumber(); break;
            }

        }
        private void usersResultLabel_Click(object sender, EventArgs e)
        {
            var userResultForm = new UsersResultForm(userResult.GetSortedListUsers());
            userResultForm.Show();
        }
        private void endGameLabel_Click(object sender, EventArgs e)
        {
            gameOver = true;
            MessageBox.Show(GetGameOverText());
            GameOver();
        }
        private void restartLabel_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void изменитьРазмерПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oldMapSize = MapSize;
            var mapSizeForm = new MapSizeForm();
            mapSizeForm.ShowDialog();
            if (oldMapSize != MapSize)
            {
                RestartGame();
            }
        }
        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserInfoForm.RulesGame());
        }
        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void закончитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameOver = true;
            MessageBox.Show(GetGameOverText());
            GameOver();
        }
        private void выйтиИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Методы нажатия стрелок;
        private void PressKeyRight()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = MapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    CalculateScore(number);
                                    ChangeLabel(i, j, number * 2);
                                    ChangeLabel(i, k, 0);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < MapSize; i++)
            {
                for (int j = MapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                ChangeLabel(i, k, 0);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void PressKeyLeft()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < MapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    CalculateScore(number);
                                    ChangeLabel(i, j, number * 2);
                                    ChangeLabel(i, k, 0);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < MapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                ChangeLabel(i, k, 0);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void PressKeyUp()
        {
            for (int j = 0; j < MapSize; j++)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < MapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    CalculateScore(number);
                                    ChangeLabel(i, j, number * 2);
                                    ChangeLabel(k, j, 0);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < MapSize; j++)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < MapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {

                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[i, j].BackColor = labelsMap[k, j].BackColor;
                                ChangeLabel(k, j, 0);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void PressKeyDonw()
        {
            for (int j = 0; j < MapSize; j++)
            {
                for (int i = MapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    CalculateScore(number);
                                    ChangeLabel(i, j, number * 2);
                                    ChangeLabel(k, j, 0);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < MapSize; j++)
            {
                for (int i = MapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[i, j].BackColor = labelsMap[k, j].BackColor;
                                ChangeLabel(k, j, 0);
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Методы логики игры;
        private void InitMap(int mapSize)
        {
            lastMapSize = mapSize;
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var label = CreateLabel(i, j);
                    Controls.Add(label);
                    labelsMap[i, j] = label;
                    if (j == mapSize - 1 && i == mapSize - 1)
                    {
                        this.ClientSize = new Size(CalculatePosition(mapSize + 1), CalculatePosition(mapSize + 1));
                    }
                }
            }
        }
        private void UtilMap()
        {
            for (int i = 0; i < lastMapSize; i++)
            {
                for (int j = 0; j < lastMapSize; j++)
                {
                    var label = labelsMap[i, j];
                    Controls.Remove(label);
                }
            }
        }
        private void GenerateNumber()
        {
            while (true)
            {
                var randomNumberLabel = random.Next(MapSize * MapSize);
                var indexRow = randomNumberLabel / MapSize;
                var indexColumn = randomNumberLabel % MapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomGenerateNumber = random.Next(1, 100);
                    if (randomGenerateNumber <= 90)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                        labelsMap[indexRow, indexColumn].BackColor = Color.Aqua;
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                        labelsMap[indexRow, indexColumn].BackColor = Color.Blue;
                    }
                    break;
                }
            }
        }
        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            SuspendLayout();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(80, 80);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = CalculatePosition(indexColumn);
            int y = CalculatePosition(indexRow);
            label.Text = null;
            label.Location = new Point(x, y);
            return label;
        }
        private int CalculatePosition(int index)
        {
            int position = 85 + index * (80 + 6);
            return position;
        }
        private void ChangeLabel(int indexRow, int indexColumn, int number)
        {
            if (number == 0)
            {
                var clearLabel = CreateLabel(indexRow, indexColumn);
                labelsMap[indexRow, indexColumn].Text = clearLabel.Text;
                labelsMap[indexRow, indexColumn].BackColor = clearLabel.BackColor;
            }
            else
            {
                labelsMap[indexRow, indexColumn].Text = number.ToString();
                switch (number)
                {
                    case 4: labelsMap[indexRow, indexColumn].BackColor = Color.Blue; break;
                    case 8: labelsMap[indexRow, indexColumn].BackColor = Color.Orange; break;
                    case 16: labelsMap[indexRow, indexColumn].BackColor = Color.DarkOrange; break;
                    case 32: labelsMap[indexRow, indexColumn].BackColor = Color.LightSalmon; break;
                    case 64: labelsMap[indexRow, indexColumn].BackColor = Color.IndianRed; break;
                    case 128: labelsMap[indexRow, indexColumn].BackColor = Color.Firebrick; break;
                    case 256: labelsMap[indexRow, indexColumn].BackColor = Color.Red; break;
                    case 512: labelsMap[indexRow, indexColumn].BackColor = Color.GreenYellow; break;
                    case 1024: labelsMap[indexRow, indexColumn].BackColor = Color.ForestGreen; break;
                    case 2048: labelsMap[indexRow, indexColumn].BackColor = Color.MediumSeaGreen; break;
                    case 4096: labelsMap[indexRow, indexColumn].BackColor = Color.Aquamarine; break;
                }
            }
        }
        private void CalculateScore(int number)
        {
            score += number * 2;
            user.Result = score;
        }
        private bool CheckEmptyTiles()
        {
            bool emptyTiles = false;
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        emptyTiles = true;
                        break;
                    }
                }
            }
            return emptyTiles;
        }

        // Методы начала, окончания игры и записи результатов;
        private string GetGameOverText()
        {
            return "Игра закончена. Ваш счёт: " + user.Result.ToString() + ". Чтобы попробовать ещё, нажмите начать заново";
        }
        private void GameOver()
        {
            var userResult = new UserResult(user.GetName(), user.Result);
            userResult.AddUserResult(userResult.Name, userResult.Result);
        }
        private void CountGameOver()
        {
            countEmptyClicks++;
            if (countEmptyClicks == 15)
            {
                gameOver = true;
            }
        }
        private void StartGame()
        {
            countEmptyClicks = 0;
            gameOver = false;
            InitMap(MapSize);
            GenerateNumber();
            userResult = new UserResult(user.GetName(), user.Result);
            bestResult = userResult.GetBestResult();
            bestResultLabel.Text = "Лучший счёт: " + bestResult;
        }
        private void AddNewUser()
        {
            score = 0;
            scoreLabel.Text = "Счет: " + Convert.ToString(score);
            var userInfo = new UserInfoForm();
            userInfo.ShowDialog();
            user = new User(userInfo.UserName);
        }
        private void RestartGame()
        {
            GameOver();
            UtilMap();
            var restartGameForm = new RestartGameForm();
            restartGameForm.ShowDialog();
            if (NewName == true)
            {
                AddNewUser();
            }
            else
            {
                score = 0;
                scoreLabel.Text = "Счет: " + Convert.ToString(score);
                user.Result = 0;
            }
            StartGame();
        }
    }
}
