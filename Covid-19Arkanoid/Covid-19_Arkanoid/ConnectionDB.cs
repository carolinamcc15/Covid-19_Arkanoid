using System;
using System.Data;
using Npgsql;

namespace Covid_19_Arkanoid
{
    public static class ConnectionDB
    {
        private static string sConnection = 
            "Server=localhost;Port=5432;User Id=postgres;Password=Carolinac15.;Database=Arkanoid;";
        /*private static String host = "ec2-18-233-32-61.compute-1.amazonaws.com",
            database = "ddmitfc6317dag",
            userID = "ywyfqbsawivlfl",
            password = "68a3a6949e9c43aa093a63d5d768de9ca07b6de8684601e448ff07c1c2780196";
            

        private static String sConnection = $"Host={host};Port = 5432; User Id = {userID}; Password={password};Database={database};"+ "sslmode=Require;Trust Server Certificate=true";
*/
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}