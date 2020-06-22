using System;

namespace Covid_19_Arkanoid.Controlador
{
    public class KeyPressStartException : Exception
    {
        public KeyPressStartException(string message) : base(message)
        {
        }
    }
}