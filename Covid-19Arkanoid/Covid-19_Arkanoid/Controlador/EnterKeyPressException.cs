using System;

namespace Covid_19_Arkanoid.Controlador
{
    public class EnterKeyPressException : Exception
    {
        public EnterKeyPressException(string message) : base(message)
        {
        }
    }
}