using System;
using System.Drawing;
using Covid_19_Arkanoid.Properties;

namespace Covid_19_Arkanoid
{
    public class Player
    {
        public int PlayerId { get; set; }
        public String Name{ get; set; }
        public int Score{ get; set; }
        public int HistoricalScore { get; set; }
        public int Lives { get; set; }
        public Ball Ball { get; }
        public Paddle Paddle{ get; }

        public Player(string name,Image skin, int id)
        {
            Name = name;
            Score = 0;
            HistoricalScore = 0;
            Lives = 3;
            Ball = new Ball(skin, 5,5 );
            Paddle = new Paddle(200,20,Resources.Paleta);
            id = 0;
        }
        public Player() { }

        public void Die()
        {
            --Lives;
        }
    }
}