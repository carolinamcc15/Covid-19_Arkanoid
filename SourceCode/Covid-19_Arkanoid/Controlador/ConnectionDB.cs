using System;
using System.Data;
using Npgsql;

namespace Covid_19_Arkanoid.Controlador
{
    //Clase utilizada para la conexión con PostgreSQL
    public static class ConnectionDb
    {
        private static String _host = "localhost", _database = "", _userId = "",
            _password = "";

        private static String _connectionString = $"Host={_host};" +
                                                 $"Port = 5432;" +
                                                 $" User Id = {_userId};" +
                                                 $" Password={_password};" +
                                                 $"Database={_database};";
                                                 


        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}