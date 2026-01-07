using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class_Gass_livery
{
    public class Driver
    {
        private string idDriver;
        private string idUser;
        private int pendapatan;
        private float rating;
        private string description;
        private List<Kendaraan> listKendaraan;

        public Driver(string idDriver, string idUser, int pendapatan, List<Kendaraan> listKendaraan, string description="")
        {
            IdDriver = idDriver;
            IdUser = idUser;
            Pendapatan = pendapatan;
            Description = description;
            ListKendaraan = listKendaraan;
        }

        public string IdDriver { get => idDriver; set => idDriver=value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public int Pendapatan { get => pendapatan; set => pendapatan = value; }
        public float Rating { get => rating; }
        public List<Kendaraan> ListKendaraan { get => listKendaraan; set => listKendaraan = value; }
        public string Description { get => description; set => description = value; }
        
        public static List<Driver> BacaData() 
        {
            string select = "select * from driver;";
            MySqlDataReader data = ConnectDB.Select(select);
            List<Driver> listDriver = new List<Driver>();

            while (data.Read())
            {
                List<Kendaraan> listKendaraan = Kendaraan.BacaData("select * from kendaraan;");
                /*Driver temp = new Driver(
                    (int)data["id_driver"],
                    (int)data["id_users"],
                    (int)data["pendapatan"]
                    );*/
            }
            return listDriver;
        }
    }
}
