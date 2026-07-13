using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace JobTracker.Data
{
    public class Database
    {
        private readonly string connectionString= "server=localhost;database=JobTracker;user=root;password= 22Chritos22+;";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
