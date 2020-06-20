namespace Covid_19_Arkanoid.Controlador
{
    //Clase que contiene valores importantes para la ejecución del juego. 
    public static class GameController
    {
        public static int VerticalMovement = 6;
        public static int HorizontalMovement = 6;
        public static int Lives = 3;
        public static bool OnGame;

        //Reinicia los valores de las variables.
        public static void InitializeGame()
        {
            VerticalMovement = HorizontalMovement = 6;
            Lives = 3;
            OnGame = false;
        }
    }
}