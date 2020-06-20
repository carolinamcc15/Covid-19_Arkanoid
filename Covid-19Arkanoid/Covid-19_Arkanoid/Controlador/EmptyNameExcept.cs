using System;

namespace Covid_19_Arkanoid
{
    public class EmptyNameExcept : Exception
    {
        public EmptyNameExcept(string message) : base(message)
        {
        }
    }
}