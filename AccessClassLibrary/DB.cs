using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessClassLibrary
{
    public class DB
    {
        public static string connectionstring
        { 
            get
            {
                return "server = localhost ; port = 3306; username = root; password =; database = stinger_users_db; pooling = false; convert zero datetime = True";
            }
        }

        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password =; database = stinger_users_db; pooling = false; convert zero datetime = True");

        // function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // function to return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    
    }
}
