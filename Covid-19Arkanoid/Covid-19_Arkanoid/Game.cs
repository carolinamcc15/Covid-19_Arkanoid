using System;
using System.Drawing;
using System.Windows.Forms;
using Covid_19_Arkanoid.Properties;

namespace Covid_19_Arkanoid
{
    public partial class Game : UserControl
    {
        private Player player;
        private Block[,] blocks;
        private bool onGame;
        private int remainingBlocks;
        private PictureBox[] pic;
        public Game(Image skin, String name)
        {   
            
            InitializeComponent();
            player = new Player(name, skin);
            onGame = false;
            remainingBlocks = 0;
        }


        private void Game_Load(object sender, EventArgs e)
        {
            PlaceControls();
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            player.Paddle.Left = e.X - (player.Paddle.Width / 2);
        }

        private void Game_Click(object sender, EventArgs e)
        {
            if (!onGame)
            {
                MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
                timerArkanoid.Start();
                onGame = true;
            }
        }
        private void PlaceControls()
        {
            int width = Convert.ToInt32((Parent.ClientSize.Width * 0.75)/8);
            int heigth = Convert.ToInt32((Parent.ClientSize.Height * 0.3)/6);
            if (remainingBlocks == 0)
            {
                Controls.Clear();
                pic  = new PictureBox[player.Lives + 1];
                for (int i = 0; i < player.Lives; i++)
                {
                    pic[i] = new PictureBox();
                    pic[i].BackColor = Color.Transparent;
                    pic[i].BackgroundImage = Resources.Life;
                    pic[i].BackgroundImageLayout = ImageLayout.Stretch;
                    pic[i].Size = new Size(70,70);
                    pic[i].Location = new Point(20 + (i * 70), 5);
                    Controls.Add(pic[i]);
                }
                blocks = new Block[6,8];
                remainingBlocks = 6 * 8;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        blocks[i,j] = new Block(1, width, heigth, Resources.Bloque_menta);
                        blocks[i,j].Location = new Point( (i + 2)* width, (j + 3) * heigth);
                        Controls.Add(blocks[i,j]);
                    }
                }
            }
            Controls.Remove(pic[player.Lives]);
            player.Ball.VerticalMovement *= -1;
            Controls.Add(player.Ball);
            Controls.Add(player.Paddle);
            player.Ball.Location = new Point(Parent.ClientSize.Width/2 - player.Ball.Width/2,
                Parent.ClientSize.Height - 80);
            player.Paddle.Location = new Point(Parent.ClientSize.Width/2 - player.Paddle.Width/2,
                Parent.ClientSize.Height - 50);
            
            
        }

        private void timerArkanoid_Tick(object sender, EventArgs e)
        {
            if (remainingBlocks == 0 || player.Lives == 0)
            {
                FinishGame();
            }
            player.Ball.Top += player.Ball.VerticalMovement;
            player.Ball.Left += player.Ball.HorizontalMovement;
            foreach (var block in blocks)
            {
                if (player.Ball.Bounds.IntersectsWith(block.Bounds) && block.Visible)
                {
                    player.Score += 10;
                    --remainingBlocks;
                    block.Dispose();
                    player.Ball.VerticalMovement *= -1;
                }
            }

            if (player.Ball.Bounds.IntersectsWith(player.Paddle.Bounds))
            {
                if (player.Ball.Location.X >= player.Paddle.Location.X && 
                    player.Ball.Location.X <(player.Paddle.Location.X + player.Paddle.Width/2))
                {
                    if (player.Ball.HorizontalMovement>0)
                    {
                        player.Ball.HorizontalMovement = new Random().Next(-6,-3);
                        
                    }
                }else if (player.Ball.HorizontalMovement<0)
                {
                    player.Ball.HorizontalMovement = new Random().Next(3,6);
                }
                player.Ball.VerticalMovement *= -1;
            }

            if (player.Ball.Top < Parent.ClientSize.Height * 0.15)
            {
                player.Ball.VerticalMovement *= -1;
            }

            if (player.Ball.Right > Parent.ClientSize.Width || player.Ball.Left <0)
            {
                player.Ball.HorizontalMovement *= -1;
            }

            if (player.Ball.Bottom > Parent.ClientSize.Height)
            {
                timerArkanoid.Stop();
                player.Die();
                if (player.Lives == 0)
                {
                    FinishGame();
                }
                onGame = false;
                MouseMove -= new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
                PlaceControls();
            }
        }
        private void FinishGame()
        {
            String result = "Score: " + player.Score + "\nBest score: " + player.HistoricalScore + "\nTop: ";
            if (MessageBox.Show(result,"ARKANOID",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
            {
                Parent.Hide();
            }
        }
    }
}