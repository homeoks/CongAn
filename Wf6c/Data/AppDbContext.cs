using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CongAn.Data
{
    public static class AppDbContext
    {
        public static SqliteConnection connection;

        static AppDbContext()
        {
            string cs = @"Data Source = data.db;";

            connection = new SqliteConnection(cs);
            connection.Open();
        }

        public static object ExcuteQuery(string query)
        {
            var cmd = new SqliteCommand(query, connection);
            return cmd.ExecuteScalar();
        }  

        public static SqliteDataReader ExcuteSelect(string query)
        {
            var cmd = new SqliteCommand(query, connection);
            return cmd.ExecuteReader();
        }
    }
}
