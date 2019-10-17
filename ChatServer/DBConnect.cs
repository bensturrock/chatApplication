using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "lochnagar.abertay.ac.uk";
            database = "sql1806055";
            uid = "sql1806055";
            password = "3SjwV6FUwTPL";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        
        //open connection to database
        private bool OpenConnection()
        {
            return false;
        }

        //Close connection to database
        private bool CloseConnection()
        {
            return false;
        }
        
    }
}
