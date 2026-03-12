using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Data
{ 
    public static class BadDb
    {
        private static string _connectionString = string.Empty;
        public static string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value ?? throw new ArgumentNullException(nameof(value));
        }


        public static int ExecuteNonQueryUnsafe(string sql)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(sql, conn);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static IDataReader ExecuteReaderUnsafe(string sql)
        {
            var conn = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(sql, conn);
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}