using System;
using System.Collections.Generic;
using System.Data;

namespace Covid_19_Arkanoid
{
    public static class PlayerDAO
    {
        public static void InsertPlayer(string nick)
        {
            String query = String.Format("INSERT INTO PLAYER(nickname) VALUES('{0}');", nick);
            ConnectionDB.ExecuteNonQuery(query);
        }
        
        public static List<Player> GetPlayers()
        {
            String query = $"SELECT * FROM PLAYER;";
            DataTable dataT = ConnectionDB.ExecuteQuery(query);
            var listPlayers = new List<Player>();
            foreach (DataRow row in dataT.Rows)
            {
                Player pl = new Player();
                pl.playerID = Convert.ToInt32(row[0].ToString());
                pl.Name = row[1].ToString();
                listPlayers.Add(pl);
            }
            return listPlayers;
        }
        
        public static void InsertScore(int score, int id)
        {
            String query = String.Format("INSERT INTO SCORE(score, playerID) VALUES({0}, {1});", score, id);
            ConnectionDB.ExecuteNonQuery(query);
        }
    }
}