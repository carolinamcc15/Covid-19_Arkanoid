using System;
using System.Drawing;
using Covid_19_Arkanoid.Properties;

namespace Covid_19_Arkanoid
{
    public class Player
    {
        public String Name{ get;}
        public int Score{ get; set; }
        public int HistoricalScore{ get; }
        public int Lives { get; set; }
        public Ball Ball { get; }
        public Paddle Paddle{ get; }

        public Player(string name,Image skin)
        {
            this.Name = name;
            Score = 0;
            HistoricalScore = 0;
            Lives = 3;
            Ball = new Ball(skin, 5,5 );
            Paddle = new Paddle(200,20,Resources.Paleta);
        }
        public Player(string name, int score, int historicalScore, int lives, Ball ball, Paddle paddle)
        {
            this.Name = name;
            this.Score = score;
            this.HistoricalScore = historicalScore;
            this.Lives = lives;
            this.Ball = ball;
            this.Paddle = paddle;
        }

        public void Die()
        {
            --Lives;
        }
    }
}