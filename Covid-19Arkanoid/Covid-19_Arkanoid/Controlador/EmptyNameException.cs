using System;

namespace Covid_19_Arkanoid.Controlador
{
    public class EmptyNameException : Exception
    {
        public EmptyNameException(string message) : base(message)
        {
        }
    }
}