using System;
using System.Drawing;
using System.Windows.Forms;
using Covid_19_Arkanoid.Modelo;

namespace Covid_19_Arkanoid.Vista
{
    public partial class Skin : UserControl
    {
        private byte _aux = 0;
        private Image[] _skin;
        private Player _player;
        
        public Skin(Player player)
        {
            _player = player;
            InitializeComponent();
            //Se llena el arreglo con las imágenes de skin
            _skin = new []
            {
                Image.FromFile("../../Resources/Pink_Kirby.png"),
                Image.FromFile("../../Resources/Bear.png"),
                Image.FromFile("../../Resources/Soccer.png"),
                Image.FromFile("../../Resources/Owl.png"),
                Image.FromFile("../../Resources/Kirby_Celeste.png")
            };
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
        
        private void ButtonRight_Click(object sender, EventArgs e)
        {
            //Cálculos matemáticos para mostrar la skin siguiente
                ++_aux;
                _aux %= 5;
                picSkin.Image = _skin[_aux];
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            //Cálculos matemáticos para mostrar la skin anterior
            _aux += 4;
            _aux %= 5;
            picSkin.Image = _skin[_aux];
        }

        private void BtnDoneS_Click(object sender, EventArgs e)
        {
            Game game = new Game(picSkin.Image, _player);
            game.Dock = DockStyle.Fill;
            Parent.Controls.Add(game);
            
            Parent.Controls.Remove(this);
        }

        private void Skin_Load(object sender, EventArgs e)
        {
            //Se asigna el fondo y la imagen de skin predeterminada
            BackgroundImage = Image.FromFile("../../Resources/Skin.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            
            picSkin.Image = Image.FromFile("../../Resources/Pink_Kirby.png");
        }
    }
}