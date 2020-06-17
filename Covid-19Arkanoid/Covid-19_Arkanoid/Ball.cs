using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public class Ball : PictureBox
    {
        private Image _skin;
        public int VerticalMovement { get; set; }
        public int HorizontalMovement { get; set; }

        public Ball(Image skin, int VerticalMovement, int HorizontalMovement)
        {
            Size = new Size(30,30);
            BackgroundImage = skin;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
            this.VerticalMovement = VerticalMovement;
            this.HorizontalMovement = HorizontalMovement;
        }
    }
}