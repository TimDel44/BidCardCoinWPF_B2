using MySql.Data.MySqlClient;
using System;

namespace SolutionWPF
{
    class DALConnection
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        public static MySqlConnection connection;

        public static MySqlConnection OpenConnection()
        {
            if (connection == null) //  si la connexion est d�j� ouverte, il ne la refera pas 
            {
                server = "localhost";
                database = "testvisualstudiob2";
                uid = "bidcardcoin";
                password = "bidcardcoin";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }
    }
}
