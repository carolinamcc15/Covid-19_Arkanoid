using System;
using System.Data;
using Npgsql;

namespace Covid_19_Arkanoid
{
    public static class ConnectionDB
    {
        private static String host = "ec2-52-70-15-120.compute-1.amazonaws.com",
            database = "d4gavmo6r44oo2",
            userID = "npddexdjtdebkd",
            password = "1c002a94d0d65d4525f82522e4945a523cb386a354726f8c3c90027cffceef89";

        private static String sConnection = $"Host={host};Port = 5432; User Id = {userID}; Password={password};" +
                                            $"Database={database};"+ "sslmode=Require;Trust Server Certificate=true";
        
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