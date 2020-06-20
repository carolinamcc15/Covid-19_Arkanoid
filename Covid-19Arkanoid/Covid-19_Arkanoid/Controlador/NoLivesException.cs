using System;

namespace Covid_19_Arkanoid
{
    public class NoLivesException: Exception
    {
        public NoLivesException(string message) : base(message)
        {
        }
    }
}