﻿using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public class Block : PictureBox
    {
        private int _hardness;
        public Block(int hardness, int width, int height, Image backImage)
        {
            _hardness = hardness;
            Size = new Size(width, height);
            BackgroundImage = backImage;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public int Hit()
        {
            --_hardness;
            if (_hardness == 0)
            {
               Dispose();
               return -1;
            }
            BackgroundImage = Image.FromFile("../../Resources/Bloque_naranja.png");
            return 0;
        }
        
    }
}