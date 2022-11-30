using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace E_Automize
{
    public class Authentication
    {
        public string connectionString { get; set; }
        private string connection;
        public void getConnection()
        {
            connection = @"Data Source=users.db; Version=3";
            connectionString = connection;
        }

        public void createDatabase()
        {
            if (!File.Exists("users.db"))
            {
                File.Create("users.db");

                getConnection();
                using (SQLiteConnection con = new SQLiteConnection(connection, true))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();

                    string query = @"CREATE TABLE users (ID INTEGER PRIMARY KEY AUTOINCREMENT, Username Text(25), Password Text(25), Email Text(25))";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                return;
            }
        }
    }
}
