using System;

namespace Covid_19_Arkanoid
{
    public class Player
    {
        private String name;
        private int score;
        private int historicalScore;
        private int lives;
        private Ball ball;
        private Paddle paddle;

        public Player(string name, int score, int historicalScore, int lives, Ball ball, Paddle paddle)
        {
            this.name = name;
            this.score = score;
            this.historicalScore = historicalScore;
            this.lives = lives;
            this.ball = ball;
            this.paddle = paddle;
        }

        public void Die()
        {
            --lives;
        }
    }
}