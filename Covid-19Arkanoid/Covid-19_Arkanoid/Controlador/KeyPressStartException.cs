using System;

namespace Covid_19_Arkanoid
{
    public class KeyPressStartException : Exception
    {
        public KeyPressStartException(string message) : base(message)
        {
        }
    }
}