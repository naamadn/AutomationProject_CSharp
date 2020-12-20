using MySqlConnector;
using System;

namespace AutomationProject_CSharp.Utilities
{
    public class manageDB : commonOps
    {
        public static void initConnection(string dbUrl, string dbName, string user, string password)
        {
            string connStr = dbUrl + dbName + user + password;
            conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occurred while connecting to DB. see details: " + e.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occurred while closing the DB. see details: " + e.Message);
            }
        }
    }
}
