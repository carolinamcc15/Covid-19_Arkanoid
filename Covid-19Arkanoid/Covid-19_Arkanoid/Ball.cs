using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public class Ball : PictureBox
    {
        private Image skin;
        private Point location;
        private int verticalMovement;
        private int horizontalMovement;

        public Ball(Image skin, Point location, int verticalMovement, int horizontalMovement)
        {
            this.skin = skin;
            this.location = location;
            this.verticalMovement = verticalMovement;
            this.horizontalMovement = horizontalMovement;
        }

        public void Bounce()
        {
            
        }
    }
    
}