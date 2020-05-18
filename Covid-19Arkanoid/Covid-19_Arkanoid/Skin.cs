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
            
            skin[0] = global::Covid_19_Arkanoid.Properties.Resources.Pink_Kirby;
            skin[1] = global::Covid_19_Arkanoid.Properties.Resources.Bear;
            skin[2] = global::Covid_19_Arkanoid.Properties.Resources.Soccer;
            skin[3] = global::Covid_19_Arkanoid.Properties.Resources.Owl;
            skin[4] = global::Covid_19_Arkanoid.Properties.Resources.Kirby_Celeste;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aux == 4)
            {
                picSkin.Image = skin[0];
                aux = 0;
            }
            else
            {
                picSkin.Image = skin[aux+1];
                aux++;
            }
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(aux == 0)
            {
                picSkin.Image = skin[4];
                aux = 4;
            }
            else
            {
                picSkin.Image = skin[aux-1];
                aux--;
            }
        }
        
    }
}