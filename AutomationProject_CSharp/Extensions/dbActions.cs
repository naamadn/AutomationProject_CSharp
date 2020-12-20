using AutomationProject_CSharp.Utilities;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.Extensions
{
    public class dbActions : commonOps
    {
        public static List<String> getCredentials(String query)
        {
            List<string> credentials = new List<string>();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                credentials.Add(rdr[0].ToString());
                credentials.Add(rdr[1].ToString());
            }
            rdr.Close();
            return credentials;
        }
    }
}
