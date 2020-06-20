using System;
using System.Data;
using Npgsql;

namespace Covid_19_Arkanoid.Controlador
{
    //Clase utilizada para la conexión con PostgreSQL
    public static class ConnectionDB
    {
        private static String host = "ec2-18-211-48-247.compute-1.amazonaws.com",
            database = "dfvsa0ocr7doc4",
            userID = "sqerjfkehrlrza",
            password = "88c27136382afdfa8f6c143c5bcb4d7a84ea5ffbe03c04e17bf07cad12dd3831";

        private static String connectionString = $"Host={host};Port = 5432; User Id = {userID}; Password={password};" +
                                            $"Database={database};"+ "sslmode=Require;Trust Server Certificate=true";

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