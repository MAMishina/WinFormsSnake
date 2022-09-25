namespace WinFormsSnake
{
    public partial class SnakeForm1 : Form
    {
        private Circle food = new Circle();
        private List<Circle> snake = new List<Circle>();
        int maxWidth;
        int maxHeight;
        int score;
        int highScore;
        Random random = new Random();
        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;
        public SnakeForm1()
        {
            InitializeComponent();
            new Settings();
        }
        private void RestartGame()
        {
            snake.Clear();
            maxWidth = pictureBox1.Width/Settings.Width;
            maxHeight = pictureBox1.Height / Settings.Height;
            Startbutton1.Enabled = false;
            Snapbutton2.Enabled = false;
            score = 0;
            label1.Text = "score: " + score;
            Circle head = new Circle { X = 10, Y = 10 };
            snake.Add(head);
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                snake.Add(body);
            }
                food = new Circle { X = random.Next(2,maxWidth), Y = random.Next(2, maxHeight) };
                timer1.Start();
        }
        private void EatFood()
        {
            Circle body = new Circle { X = snake[snake.Count - 1].X, Y = snake[snake.Count - 1].Y };
            score += 1;
            label1.Text = "score: " + score;
            snake.Add(body);
            food = new Circle { X = random.Next(2, maxWidth), Y = random.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            timer1.Stop();
            Startbutton1.Enabled = true;
            Snapbutton2.Enabled = true;
            if(score > highScore)
            {
                highScore = score;
                label2.Text = "Record: " + highScore;
            }
        }

        private void Startbutton1_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void SnakeForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Left) && (Settings.direction != "right"))
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && Settings.direction != "left")
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && Settings.direction != "down")
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && Settings.direction != "up")
            {
                goDown = true;
            }
        }

        private void SnakeForm1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goLeft = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                goDown = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                goUp = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for(int i = 0; i < snake.Count; i++)
            {
                if(i==0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    snake[i].X * Settings.Width,
                    snake[i].Y * Settings.Height, 
                    Settings.Width,
                    Settings.Height
                    )
                    );
            }
            canvas.FillEllipse(Brushes.Orange, new Rectangle
                (
                food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width,
                Settings.Height
                )
                );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(goLeft )
            {
                Settings.direction = "left";

            }
            if(goRight)
            {
                Settings.direction = "right";
            }
            if(goDown)
            {
                Settings.direction = "down";
            }
            if(goUp)
            {
                Settings.direction = "up";
            }
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case "left":
                            snake[i].X--;
                            break;
                        case "right":
                            snake[i].X++;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                        case "Up": // меняем на "up" и все работает.
                            snake[i].Y--;
                            break;
                    }
                    if (snake[i].X < 0)
                    {
                        snake[i].X = maxWidth;
                    }
                    if (snake[i].X > maxWidth)
                    {
                        snake[i].X = 0;
                    }
                    if (snake[i].Y < 0)
                    {
                        snake[i].Y = maxHeight;
                    }
                    if (snake[i].Y > maxHeight)
                    {
                        snake[i].Y = 0;
                    }
                    if (snake[i].X == food.X && snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
            pictureBox1.Invalidate();
        }
    }
}
