using System;
using System.Collections.Generic;
using System.Data;
using Covid_19_Arkanoid.Modelo;

namespace Covid_19_Arkanoid.Controlador
{
    //Clase utilizada para obtener datos de los jugadores desde la base de datos.
    public static class PlayerDao
    {
        public static Player CurrentPlayer(string nick)
        {
            //Declaración de variable auxiliar utilizada para las distintas consultas.
            //Consulta para verificar existencia de nickname ingresado.
            String userQuerys = $"SELECT * FROM PLAYER WHERE nickname = '{nick}';";
            DataTable dt = ConnectionDb.ExecuteQuery(userQuerys);

            if (dt.Rows.Count == 1)
            {
                Player current = new Player();
                DataRow row = dt.Rows[0];
                current.PlayerId = Convert.ToInt32(row[0]);
                current.Name = row[1].ToString();

                return current;
            }
            //Si no se encontró el usuario ingresado
            InsertPlayer(nick);
            return new Player(nick,0); 
        }

        private static void InsertPlayer(String username)
        {
            //Consulta para insertar nuevo usuario con su respectivo nickname
            String query = $"INSERT INTO PLAYER(nickname) VALUES('{username}');";
            ConnectionDb.ExecuteNonQuery(query);
        }
        public static int GetId(String name)
        {
            String query = $"SELECT PlayerID from PLAYER WHERE nickname = '{name}';";
            var user = ConnectionDb.ExecuteQuery(query);
            
            return Convert.ToInt32(user.Rows[0][0]);
        }
        
        public static void InsertPlayerScore(int score, int id)
        {
            String query = $"INSERT INTO SCORE(score, playerID) VALUES({score}, {id});";
            ConnectionDb.ExecuteNonQuery(query);
        }
        
        public static DataTable GetTop10PlayersTable()
        {
            String query = $"SELECT pl.nickname, sc.score FROM PLAYER pl, SCORE sc " +
                                       "WHERE pl.playerID = sc.playerID ORDER BY score DESC LIMIT 10;";
            DataTable dt = ConnectionDb.ExecuteQuery(query);
            return dt;
        }
        
        public static int BestScore(int id)
        {
            String query = $"SELECT MAX(score) FROM score WHERE playerid = {id};";
            DataTable dt = ConnectionDb.ExecuteQuery(query);
            
            DataRow row = dt.Rows[0];
            int score = 0;
            
            score = Convert.ToInt32(row[0].ToString());

            return score;
        }
        
        public static List<Player> GetTop10PlayersList()
        {
            String query = $"SELECT nickname FROM PLAYER pl, SCORE sc WHERE pl.playerID = sc.playerID " +
                           "ORDER BY score DESC LIMIT 10;";
            
            DataTable dataT = ConnectionDb.ExecuteQuery(query);
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