using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MySql.Data.MySqlClient;

namespace Class_Gass_livery
{
    public class ConnectDB
    {
        public MySqlConnection connection;

        public void Connect()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            connection.Open();
        }

        public static bool ConnectionStatus(ConnectDB connection)
        {
            if (connection.connection.State == System.Data.ConnectionState.Open) return true;
            else return false;
        }

        public ConnectDB(string server, string db, string usr, string passwd)
        {
            string info = $"Server={server};Database={db};Uid={usr};Pwd={passwd};";
            connection = new MySqlConnection(info);
            Connect();
        }

        public ConnectDB()
        {
            string info = "Server=localhost;Database=gass_livery;Uid=root;Pwd=;";
            connection = new MySqlConnection(info);
            Connect();
        }

        //Select Methode
        public static MySqlDataReader Select(string perintah)
        {
            ConnectDB con = new ConnectDB();
            MySqlCommand command = new MySqlCommand(perintah, con.connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int InputData(string perintah)
        {
            ConnectDB db = new ConnectDB();
            MySqlCommand cmd = new MySqlCommand(perintah, db.connection);
            int jumlahDataBerubah = cmd.ExecuteNonQuery();
            return jumlahDataBerubah;
        }
    }
}
