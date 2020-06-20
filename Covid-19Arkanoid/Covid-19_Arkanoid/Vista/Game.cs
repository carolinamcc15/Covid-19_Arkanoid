using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Covid_19_Arkanoid.Controlador;
using Covid_19_Arkanoid.Modelo;

namespace Covid_19_Arkanoid.Vista
{
    public partial class Game : UserControl
    {
        //Atributos readonly solo se instancian en el constructor
        private readonly PictureBox _paddle;
        private readonly PictureBox _ball;
        private readonly Player _player;
        private readonly Label _scoreLabel;
        private Block[,] _blocks;
        private PictureBox[] _picHearts;
        private int _remainingBlocks;
        
        public Game(Image skin, Player player)
        {
            InitializeComponent();
            
            _player = player;
            
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
            
            _scoreLabel = new Label();
            _scoreLabel.Font = new Font("Volleyball", 21F);
            _scoreLabel.BackColor = Color.Transparent;
            _scoreLabel.ForeColor = Color.White;
            
            GameController.OnGame = false;
            _remainingBlocks = 0;
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
        
        private void Game_Load(object sender, EventArgs e)
        {
            //Se asigna el tamaño del userControl Game al tamaño de la ventana y se colocan los controles 
            Width = Parent.ClientSize.Width;
            Height = Parent.ClientSize.Height;
            
            PlaceControls();
        }

        #region Events
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
                    _player.Score += block.Score;
                    _remainingBlocks += block.Hit();
                    _scoreLabel.Text = _player.Score.ToString();

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

        #endregion
        private void PlaceControls()
        {
            GameController.VerticalMovement *= -1;
            
            int blockWidth = Convert.ToInt32((Parent.ClientSize.Width * 0.75)/8);
            int blockHeight = Convert.ToInt32((Parent.ClientSize.Height * 0.3)/6);
            
            //Condición solo se cumple en la primera vida 
            if (_remainingBlocks == 0)
            {
                //Se limpian los controles que contenga el userControl, se restauran valores de variables de juego
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
                        /*Asignación de nivel de dureza aleatorio. Se asigna el score y la imagen del bloque según su
                         fila. La función matemática utilizada en el score el resultado de nuestros cálculos.*/
                        Image image = Image.FromFile("../../Resources/" + (j%2==0?j:j-1) +".png");
                        _blocks[i, j] = new Block(new Random().Next(1,9)>5 ?2:1, 25-(j%2==0?j:j-1)/2*5, 
                            blockWidth, blockHeight, image);
                        _blocks[i,j].Location = new Point((i + 2)*blockWidth+blockWidth/4,(j + 3) * blockHeight);
                        Controls.Add(_blocks[i,j]);
                    }
                }
                _scoreLabel.Location = new Point(Width-285, 20);
                _scoreLabel.Size = new Size(300, 50);
                

                Controls.Add(_ball);
                Controls.Add(_paddle);
                Controls.Add(_scoreLabel);
            }
            
            Controls.Remove(_picHearts[GameController.Lives]);

            _ball.Location = new Point(Width/2 - _ball.Width/2, Height - 75);
            _paddle.Location = new Point(Width/2 - _paddle.Width/2, Height - 50);
        }
        
        private void FinishGame(bool win)
        {
            try
            {
                if (win)
                {
                    PlayerDAO.InsertPlayerScore(_player.Score, _player.PlayerId);
                    int historicalScore = PlayerDAO.BestScore(_player.PlayerId);

                    //La variable top almacena si el jugador se encuentra posicionado en el Top 10 o no.
                    bool top = false;
                   
                    List<Player> top10 = PlayerDAO.GetTop10PlayersList();
                    top10.ForEach(s =>
                    {
                        if (string.Equals(s.Name, _player.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            top = true;
                        }
                    });

                    String result =
                        $"Score: {_player.Score} \nBest score: {historicalScore} " +
                        $"\n{(top ? "You got into the top 10!" : "You are not in the top 10. :(")}";
                    if (MessageBox.Show(result, "ARKANOID", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ((Form) Parent).Close();
                    }
                }
                else
                {
                    throw new NoLivesException($"You've lost. Thank you for playing! " +
                                               $"\nScore: {_player.Score}");
                } 
            }
            catch (NoLivesException ex)
            {
                MessageBox.Show(ex.Message,"ARKANOID", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                ((Form) Parent).Close();
            }
        }
    }
}