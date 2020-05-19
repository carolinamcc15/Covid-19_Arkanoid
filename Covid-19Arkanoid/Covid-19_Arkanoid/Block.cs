using System.Drawing;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public class Block : PictureBox
    {
        private int hardness;
        private int width;
        private int height;
        private Image backImage;

        public Block(int hardness, int width, int height, Image backImage)
        {
            this.hardness = hardness;
            this.width = width;
            this.height = height;
            this.backImage = backImage;
        }

        public int ReduceHardness()
        {
            return --hardness;
        }
        
    }
}