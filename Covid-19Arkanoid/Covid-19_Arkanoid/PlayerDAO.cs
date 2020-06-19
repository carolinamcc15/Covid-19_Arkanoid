using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Covid_19_Arkanoid
{
    public static class PlayerDAO
    {
        
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

        public static Player CurrentPlayer(String nick)
        {
            Player current = new Player();

            //Consulta para verificar existencia de nickname ingresado
            String validate = String.Format("SELECT * FROM PLAYER WHERE UPPER(nickname) = UPPER('{0}');", nick);
            //Consulta para insertar nuevo usuario con su respectivo nickname
            String insert = String.Format("INSERT INTO PLAYER(nickname) VALUES('{0}');", nick);

            DataTable dt = ConnectionDB.ExecuteQuery(validate);

            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                current.PlayerId = Convert.ToInt32(row[0]);
                current.Name = row[1].ToString();
                
                MessageBox.Show("Welcome back!", "ARKANOID", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                return current;
            }
            else
            {
                ConnectionDB.ExecuteNonQuery(insert);
                MessageBox.Show("User registered successfully!", "ARKANOID", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                List<Player> players = PlayerDAO.GetPlayers();
                foreach(var pl in players)
                {
                    if (pl.Name.Equals(nick))
                    {
                        current = pl;
                    }
                }
                return current;
            }
        }

        public static void InsertScore(int score, int id)
        {
            String query = String.Format("INSERT INTO SCORE(score, playerID) VALUES({0}, {1});", score, id);
            ConnectionDB.ExecuteNonQuery(query);
        }
        
        public static DataTable GetTop10()
        {
            String sql = String.Format("SELECT pl.nickname, sc.score FROM PLAYER pl, SCORE sc " +
                                       "WHERE pl.playerID = sc.playerID ORDER BY score DESC LIMIT 10;");
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
                           "ORDER BY score DESC LIMIT 10;";
            
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