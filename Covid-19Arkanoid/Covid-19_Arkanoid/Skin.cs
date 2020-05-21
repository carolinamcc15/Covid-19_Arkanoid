using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Covid_19_Arkanoid
{
    public partial class Skin : UserControl
    {
        byte aux = 0;
        private Image[] skin = new Image[5];
        
        public Skin()
        {
            InitializeComponent();
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
            Hide();
            Game g = new Game();
            g.Dock = DockStyle.Fill;
            Parent.Controls.Add(g);
        }
    }
}