using System;

namespace Covid_19_Arkanoid.Controlador
{
    public class UsernameLengthException : Exception
    {
        public UsernameLengthException(String message): base(message){}
    }
}