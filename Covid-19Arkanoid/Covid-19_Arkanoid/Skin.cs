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
        public Skin(String username)
        {
            this.username = username;
            InitializeComponent();
            skin = new Image[5];
            skin[0] = Properties.Resources.Pink_Kirby;
            skin[1] = Properties.Resources.Bear;
            skin[2] = Properties.Resources.Soccer;
            skin[3] = Properties.Resources.Owl;
            skin[4] = Properties.Resources.Kirby_Celeste;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ++aux;
            aux %= 5;
            picSkin.Image = skin[aux];
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            aux = Convert.ToByte((4 + aux) % 5);
            picSkin.Image = skin[aux];
        }

        private void btnDoneS_Click(object sender, EventArgs e)
        {
            Game game = new Game(picSkin.Image,username);
            game.Dock = DockStyle.Fill;
            Parent.Controls.Add(game);
            Parent.Controls.Remove(this);
        }
    }
}