using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid.Modelo
{
    public class Block : PictureBox
    {
        private int _hardness;
        public int Score { get;}

        public Block(int hardness, int score, int width, int height, Image backImage)
        {
            _hardness = hardness;
            Score = score;
            Size = new Size(width, height);
            BackgroundImage = backImage;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public int Hit()
        {
            --_hardness;
            if (_hardness == 0) // Si el bloque ya no tiene niveles de dureza 
            {
               Dispose();
               return -1;
            }
            //Si aún tiene niveles de dureza, cambia el color del bloque
            BackgroundImage = Image.FromFile("../../Resources/Bloque_naranja.png");
            return 0;
        }
    }
}