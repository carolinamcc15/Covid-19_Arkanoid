using System;
using System.Data;
using Npgsql;

namespace Covid_19_Arkanoid.Controlador
{
    //Clase utilizada para la conexión con PostgreSQL
    public static class ConnectionDB
    {
        private static String host = "localhost", database = "arkanoid", userID = "postgres",
            password = "";

        private static String connectionString = $"Host={host};" +
                                                 $"Port = 5432;" +
                                                 $" User Id = {userID};" +
                                                 $" Password={password};" +
                                                 $"Database={database};";
                                                 


        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}