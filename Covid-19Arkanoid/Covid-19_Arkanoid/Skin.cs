using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Covid_19_Arkanoid
{
    public partial class Skin : UserControl
    {
        private byte aux = 0;
        private Image[] skin;
        private String username;
        private int id;
        public Skin(String username, int id)
        {
            this.username = username;
            this.id = id;
            InitializeComponent();
            skin = new Image[5];
            skin[0] = Image.FromFile("../../Resources/Pink_Kirby.png");
            skin[1] = Image.FromFile("../../Resources/Bear.png");
            skin[2] = Image.FromFile("../../Resources/Soccer.png");
            skin[3] = Image.FromFile("../../Resources/Owl.png");
            skin[4] = Image.FromFile("../../Resources/Kirby_Celeste.png");
        }
        
        private void ButtonRight_Click(object sender, EventArgs e)
        {
            ++aux;
            aux %= 5;
            picSkin.Image = skin[aux];
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            aux = Convert.ToByte((4 + aux) % 5);
            picSkin.Image = skin[aux];
        }

        private void BtnDoneS_Click(object sender, EventArgs e)
        {
            Game game = new Game(picSkin.Image,username,id);
            game.Dock = DockStyle.Fill;
            
            Parent.Controls.Add(game);
            Parent.Controls.Remove(this);
        }

        private void Skin_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("../../Resources/Skin.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            
            picSkin.Image = Image.FromFile("../../Resources/Pink_Kirby.png");
            
        }
    }
}