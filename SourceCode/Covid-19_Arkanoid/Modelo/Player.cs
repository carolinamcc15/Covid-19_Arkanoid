using System;

namespace Covid_19_Arkanoid.Modelo
{
    public class Player
    {
        public int PlayerId { get; set; }
        public String Name{ get; set; }
        public int Score{ get; set; }
        
        public Player(string name, int id)
        {
            PlayerId = id;
            Name = name;
            Score = 0;
            
        }
        
        public Player() {}
        
    }
}