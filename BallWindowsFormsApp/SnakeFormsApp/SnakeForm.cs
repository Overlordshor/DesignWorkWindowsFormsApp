using SnakeFormsApp;
using SnakeFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SnakeWindowsFormsApp
{
    public partial class SnakeForm : Form
    {
        private Food food;
        private List<Snake> snake;
        private Snake head => snake[0];
        private Direction direction = Direction.Right;
        private readonly Timer timer;
        private readonly int mapSize = 20;
        private Map[,] cellsMaps;
        private static Random random = new Random();
        public SnakeForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 150;
            timer.Tick += Timer_Tick;
        }
        private void SnakeForm_Load(object sender, EventArgs e)
        {
            CreateNewGame();
        }

        private void начатьНовуюИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && direction != Direction.Right)
            {
                direction = Direction.Left;
            }

            if (e.KeyCode == Keys.Right && direction != Direction.Left)
            {
                direction = Direction.Right;
            }

            if (e.KeyCode == Keys.Up && direction != Direction.Down)
            {
                direction = Direction.Top;
            }

            if (e.KeyCode == Keys.Down && direction != Direction.Top)
            {
                direction = Direction.Down;
            }
        }

        private void CreateNewGame()
        {
            InitMap();

            timer.Interval = 100;
            CreateSnake();

            timer.Start();

            AddFood();
        }

        private void RestartGame()
        {
            timer.Stop();
            DeleteSnake();
            food.Delete();
            CreateNewGame();
        }

        private void CreateSnake()
        {
            snake = new List<Snake>();
            var head = new Snake(this);
            SetPosition(head);
            
            var tail = new Snake(this);

            snake.Add(head);
            snake.Add(tail);
            head.Image = Resources.Head;

            lengthSnakeLabel.Text = "Длина змейки: " + snake.Count;
        }

        private void SetPosition(Snake figure)
        {
            figure.SetX(cellsMaps[random.Next(mapSize - 1), random.Next(mapSize - 1)]);
            figure.SetY(cellsMaps[random.Next(mapSize - 1), random.Next(mapSize - 1)]);
        }

        private void AddFood()
        {
            food = new Food(this);
            SetPosition(food);
            food.Draw();
        }

        private void MoveSnake()
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].SetCoordinate(snake[i - 1]);
                snake[i].Draw();
            }
            switch (direction)
            {
                case Direction.Top:
                    head.vy = -Math.Abs(head.vy);
                    head.MoveY();
                    break;
                case Direction.Down:
                    head.vy = Math.Abs(head.vy);
                    head.MoveY();
                    break;
                case Direction.Left:
                    head.vx = -Math.Abs(head.vx);
                    head.MoveX();
                    break;
                case Direction.Right:
                    head.vx = Math.Abs(head.vx);
                    head.MoveX();
                    break;
            }
        }      

        private void DeleteSnake()
        {
            for (int i = 0; i < snake.Count; i++)
            {
                snake[i].Delete();
            }
        }    

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (head.IntersectCircle(food))
            {
                var tail = new Snake(this);
                snake.Add(tail);
                food.Delete();
                lengthSnakeLabel.Text = "Длина змейки: " + snake.Count;
                AddFood();
                if (timer.Interval != 1)
                {
                    timer.Interval -= 1;
                }
            }
            for (int i = snake.Count - 1; i > 0; i--)
            {
                if (head.IntersectCircle(snake[i]))
                {
                    timer.Stop();
                    MessageBox.Show("Игра закончена, длина вашей змейки: " + snake.Count + ", нажмитие ОК, чобы начать новую игру.");
                    RestartGame();
                    return;
                }

            }
            MoveSnake();
        }
        private void InitMap()
        {
            cellsMaps = new Map[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newCell = CreateCell(i, j);
                    cellsMaps[i, j] = newCell;
                }
            }
        }
        private Map CreateCell(int indexRow, int indexColumn)
        {
            var cell = new Map();
            cell.SetX(indexRow);
            cell.SetY(indexColumn);
            return cell;
        }
    }
}