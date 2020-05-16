using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public partial class Skin : UserControl
    {
        byte aux = 0;
        List<Image> skin = new List<Image>();
        public Skin()
        {
            InitializeComponent();
            skin.Add(global::Covid_19_Arkanoid.Properties.Resources.Pink_Kirby);
            skin.Add(global::Covid_19_Arkanoid.Properties.Resources.Bear);
            skin.Add(global::Covid_19_Arkanoid.Properties.Resources.Soccer);
            skin.Add(global::Covid_19_Arkanoid.Properties.Resources.Owl);
            skin.Add(global::Covid_19_Arkanoid.Properties.Resources.Kirby_Celeste);
            
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