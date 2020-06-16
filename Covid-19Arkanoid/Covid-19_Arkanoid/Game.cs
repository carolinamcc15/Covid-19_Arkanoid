using System;
using System.Collections.Generic;
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
        private int id;
        public Game(Image skin, String name, int id)
        {
            this.id = id;
            InitializeComponent();
            player = new Player(name, skin, id);
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
                timerArkanoid.Stop();
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
                    //Se crean nuevos rectángulos para verificar si pega en los laterales del bloque
                    if (player.Ball.Bounds.IntersectsWith(
                            new Rectangle(block.Location,new Size(3,block.Height))) || 
                        player.Ball.Bounds.IntersectsWith(
                            new Rectangle(block.Location.X + block.Width, block.Location.Y,
                                3, block.Height))) 
                    {
                        player.Ball.HorizontalMovement *= -1;    
                    }
                    else
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
                        player.Ball.HorizontalMovement = new Random().Next(-6,-4);
                        
                    }
                }else if (player.Ball.HorizontalMovement<0)
                {
                    player.Ball.HorizontalMovement = new Random().Next(4,6);
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
            PlayerDAO.InsertScore(player.Score, id);
            player.HistoricalScore = PlayerDAO.BestScore(id);
            string top = "No";
            List<Player> top10 = new List<Player>();
            top10 = PlayerDAO.GetTop10Players();
            top10.ForEach(s =>
            {
                if (string.Equals(s.Name, player.Name, StringComparison.OrdinalIgnoreCase))
                {
                    top = "Yes";
                }
            });

            String result = "Score: " + player.Score + "\nBest score: " + player.HistoricalScore + "\nTop 10: " + top;
            PlayerDAO.InsertScore(player.Score, id);
            if (MessageBox.Show(result,"ARKANOID",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
            {
                Parent.Hide();
            }
        }
    }
}