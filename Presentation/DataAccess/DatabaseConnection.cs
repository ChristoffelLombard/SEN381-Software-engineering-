using Microsoft.Data.SqlClient;
using System;

namespace DataAccess
{
    public static class DatabaseConnection
    {
        private const string DefaultConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=CityMakerspaceDB;Integrated Security=True;";

        private static string ConnectionString =>
            Environment.GetEnvironmentVariable("CIVICCONNECT_DB_CONN")
            ?? DefaultConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
