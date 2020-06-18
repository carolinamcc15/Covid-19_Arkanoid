using System.Drawing;

namespace Covid_19_Arkanoid
{
    public static class GameController
    {
        public static int VerticalMovement = 6;
        public static int HorizontalMovement = 6;
        public static int Lives = 3;
        public static bool OnGame;

        public static void InitializeGame()
        {
            VerticalMovement = HorizontalMovement = 6;
            Lives = 3;
            OnGame = false;
        }
    }
}