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
                Player player = new Player();
                player.PlayerId = Convert.ToInt32(row[0].ToString());
                player.Name = row[1].ToString();
                listPlayers.Add(player);
            }

            return listPlayers;
        }

        public static void InsertScore(int score, int id)
        {
            String query = String.Format("INSERT INTO SCORE(score, playerID) VALUES({0}, {1});", score, id);
            ConnectionDB.ExecuteNonQuery(query);
        }
        public static DataTable GetTop10()
        {
            String sql = String.Format("SELECT pl.nickname, sc.score FROM PLAYER pl, SCORE sc " +
                                       "WHERE pl.playerID = sc.playerID ORDER BY score DESC FETCH FIRST 10 ROWS ONLY;");
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            return dt;
        }
        public static int BestScore(int id)
        {
            String query = String.Format("SELECT MAX(score) FROM score WHERE playerid = {0};", id);
            DataTable dt = ConnectionDB.ExecuteQuery(query);
            
            DataRow row = dt.Rows[0];
            int score = 0;
            
            score = Convert.ToInt32(row[0].ToString());

            return score;
        }
        public static List<Player> GetTop10Players()
        {
            String query = $"SELECT nickname FROM PLAYER pl, SCORE sc WHERE pl.playerID = sc.playerID " +
                           "ORDER BY score DESC FETCH FIRST 10 ROWS ONLY;";
            
            DataTable dataT = ConnectionDB.ExecuteQuery(query);
            var listTop10Players = new List<Player>();
            foreach (DataRow row in dataT.Rows)
            {
                Player pl = new Player();
                pl.Name = row[0].ToString();
                listTop10Players.Add(pl);
            }
            return listTop10Players;
        }
        
    }
}