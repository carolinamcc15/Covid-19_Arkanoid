using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class Game : UserControl
    {
        private PictureBox _paddle;
        private PictureBox _ball;
        private Player player;
        private Block[,] _blocks;
        private int _remainingBlocks;
        private PictureBox[] _picHearts;
        private Label sc;
        
        public Game(Image skin, String name, int id)
        {
            InitializeComponent();
            
            player = new Player(name,id);
            
            _paddle = new PictureBox();
            _paddle.BackgroundImage = Image.FromFile("../../Resources/Paleta.png");
            _paddle.BackgroundImageLayout = ImageLayout.Stretch;
            _paddle.Size = new Size(150,15);
            _paddle.BackColor = Color.Transparent;
            
            _ball = new PictureBox();
            _ball.BackgroundImage = skin;
            _ball.BackgroundImageLayout = ImageLayout.Stretch;
            _ball.Size = new Size(25,25);
            _ball.BackColor = Color.Transparent;
            
            sc = new Label();
            sc.Text = player.Score.ToString();
            GameController.OnGame = false;
            _remainingBlocks = 0;
            
        }
        
        private void Game_Load(object sender, EventArgs e)
        {
            Width = Parent.ClientSize.Width;
            Height = Parent.ClientSize.Height;
            PlaceControls();
            
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
           _paddle.Left = e.X - (_paddle.Width/2);
        }
        
        
        private void Game_Click(object sender, EventArgs e)
        {
            if (!GameController.OnGame)
            {
                    MouseMove += Game_MouseMove;
                    timerArkanoid.Start();
                    GameController.OnGame = true;
            }
        }
        
        private void Game_KeyPress(object sender, EventArgs e)
        {
            try
            {
                throw new KeyPressStartException("De click en la pantalla para iniciar el juego y " +
                                                 "utiliza el mouse para moverte.");
            }
            catch (KeyPressStartException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        
        private void PlaceControls()
        {
            int width = Convert.ToInt32((Parent.ClientSize.Width * 0.75)/8);
            int heigth = Convert.ToInt32((Parent.ClientSize.Height * 0.3)/6);
            
            if (_remainingBlocks == 0)
            {
                Controls.Clear();
                GameController.InitializeGame();
                _picHearts  = new PictureBox[GameController.Lives + 1];
                for (int i = 0; i < GameController.Lives; i++)
                {
                    _picHearts[i] = new PictureBox();
                    _picHearts[i].BackColor = Color.Transparent;
                    _picHearts[i].BackgroundImage = Image.FromFile("../../Resources/Life.png");
                    _picHearts[i].BackgroundImageLayout = ImageLayout.Stretch;
                    _picHearts[i].Size = new Size(70,70);
                    _picHearts[i].Location = new Point(20 + (i * 70), 5);
                    Controls.Add(_picHearts[i]);
                }
                
                _blocks = new Block[6,8];
                _remainingBlocks = 6 * 8;
                
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Image image = Image.FromFile("../../Resources/" + (j%2==0?j:j-1) +".png");
                        _blocks[i, j] = new Block(new Random().Next(1,9)>5 ?2:1, 25-(j%2==0?j:j-1)/2*5, 
                            width, heigth, image);
                        _blocks[i,j].Location = new Point( (i + 2)* width + width/4, (j + 3) * heigth);
                        Controls.Add(_blocks[i,j]);
                    }
                }
            }
            
            Controls.Remove(_picHearts[GameController.Lives]);
            
            GameController.VerticalMovement *= -1;
            
            Controls.Add(_ball);
            Controls.Add(_paddle);
            
            _ball.Location = new Point(Width/2 - _ball.Width/2,
                Height - 75);
            _paddle.Location = new Point(Width/2 - _paddle.Width/2,
                Height - 50);
            
            sc.Location = new Point(Width-285, 20);
            sc.Size = new Size(300, 50);
            sc.Font = new Font("Volleyball", 21F);
            sc.BackColor = Color.Transparent;
            sc.ForeColor = Color.White;
            
            Controls.Add(sc);
        }

        private void timerArkanoid_Tick(object sender, EventArgs e)
        {
            if (_remainingBlocks == 0)
            {
                timerArkanoid.Stop();
                FinishGame(true);
            }
            
            _ball.Top += GameController.VerticalMovement;
            _ball.Left += GameController.HorizontalMovement;
            
            if (_ball.Bottom > Height)
            {
                timerArkanoid.Stop();
                GameController.Lives--;
                PlaceControls();
                if (GameController.Lives == 0)
                {
                    FinishGame(false);
                    return;
                }
                GameController.OnGame = false;
                MouseMove -= Game_MouseMove;
            }
            if (_ball.Bounds.IntersectsWith(_paddle.Bounds))
            {
                if (_ball.Location.X >= _paddle.Location.X && 
                    _ball.Location.X <(_paddle.Location.X + _paddle.Width/2))
                {
                    if (GameController.HorizontalMovement>0)
                    {
                        GameController.HorizontalMovement = new Random().Next(-7,-5);
                        
                    }
                }
                else if (GameController.HorizontalMovement<0)
                {
                    GameController.HorizontalMovement = new Random().Next(5,7);
                }
                GameController.VerticalMovement *= -1;
            }

            if (_ball.Top < Height * 0.15)
            {
                GameController.VerticalMovement *= -1;
            }

            if (_ball.Right > Width || _ball.Left <0)
            {
                GameController.HorizontalMovement *= -1;
            }

            foreach (var block in _blocks)
            {
                if (_ball.Bounds.IntersectsWith(block.Bounds) && block.Visible)
                {
                    player.Score += block.Score;
                    _remainingBlocks += block.Hit();
                    sc.Text = player.Score.ToString();

                    //Se crean nuevos rectángulos para verificar si pega en los laterales del bloque.
                    if (_ball.Bounds.IntersectsWith(
                            new Rectangle(block.Location,new Size(0,block.Height))) || 
                        _ball.Bounds.IntersectsWith(
                            new Rectangle(block.Location.X + block.Width, block.Location.Y,
                                0, block.Height))) 
                    {
                        GameController.HorizontalMovement *= -1;    
                    }
                    else
                        GameController.VerticalMovement *= -1;
                }
            }
        }

        private void FinishGame(bool win)
        {
            /*if (win)
            {
                PlayerDAO.InsertScore(player.Score, player.PlayerId);
                int HistoricalScore = PlayerDAO.BestScore(player.PlayerId);

                //La variable top almacena si el jugador se encuentra posicionado en el Top 10 o no.
                bool top = false;
                List<Player> top10 = PlayerDAO.GetTop10Players();

                top10.ForEach(s =>
                {
                    if (string.Equals(s.Name, player.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        top = true;
                    }
                });

                String result =
                    $"Score: {player.Score} \nBest score: {HistoricalScore} \nTop 10: {(top ? "Yes" : "No")}";
                if (MessageBox.Show(result, "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show($"You've lost. Thank you for playing! \nScore: {player.Score}", "ARKANOID", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                Close();
            }
            */
            try
            {
                if (win)
                {
                    PlayerDAO.InsertScore(player.Score, player.PlayerId);
                    int HistoricalScore = PlayerDAO.BestScore(player.PlayerId);

                    //La variable top almacena si el jugador se encuentra posicionado en el Top 10 o no.
                    bool top = false;
                    List<Player> top10 = PlayerDAO.GetTop10Players();

                    top10.ForEach(s =>
                    {
                        if (string.Equals(s.Name, player.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            top = true;
                        }
                    });

                    String result =
                        $"Score: {player.Score} \nBest score: {HistoricalScore} \nTop 10: {(top ? "Yes" : "No")}";
                    if (MessageBox.Show(result, "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        == DialogResult.OK)
                    {
                        Close();
                    }
                }
                else
                {
                    throw new NoLivesException($"You've lost. Thank you for playing! \nScore: {player.Score}");
                } 
            }
            catch (NoLivesException ex)
            {
                MessageBox.Show(ex.Message,"ARKANOID", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                    Close();
            }
        }

        private void Close()
        {
            Parent.Hide();
            ((Form) Parent).Close();
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    }
}