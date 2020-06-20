using System;

namespace Covid_19_Arkanoid.Controlador
{
    public class NoLivesException: Exception
    {
        public NoLivesException(string message) : base(message)
        {
        }
    }
}