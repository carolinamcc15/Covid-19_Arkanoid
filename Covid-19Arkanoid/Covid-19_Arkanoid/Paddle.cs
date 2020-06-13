using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public class Paddle : PictureBox
    {
        public Paddle(int width, int height, Image backImage)
        {
            Size = new Size(width,height);
            BackgroundImage = backImage;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}