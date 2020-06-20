using System;

namespace Covid_19_Arkanoid
{
    public class ClickLBoardException : Exception
    {
        public ClickLBoardException(string message) : base(message)
        {
        }
    }
}