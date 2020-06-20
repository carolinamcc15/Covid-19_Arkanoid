using System;

namespace Covid_19_Arkanoid.Controlador
{
    public class ClickLeftBoardException : Exception
    {
        public ClickLeftBoardException(string message) : base(message)
        {
        }
    }
}