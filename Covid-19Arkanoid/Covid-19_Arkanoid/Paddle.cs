using System.Drawing;

namespace Covid_19_Arkanoid
{
    public class Paddle
    {
        private int width;
        private int height;
        private Image backImage;

        public Paddle(int width, int height, Image backImage)
        {
            this.width = width;
            this.height = height;
            this.backImage = backImage;
        }
    }
}