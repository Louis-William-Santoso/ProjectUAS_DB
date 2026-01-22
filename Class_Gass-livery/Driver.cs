using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class_Gass_livery
{
    public class Driver : User
    {
        private int idDriver;
        private long pendapatan;
        private float rating;
        private string description;
        private string status;
        private List<Kendaraan> listKendaraan;

        public Driver(User user, int idDriver, long pendapatan, List<Kendaraan> listKendaraan, string description="", string status="active")
                    : base (user)
        {
            IdDriver = idDriver;
            Pendapatan = pendapatan;
            Description = description;
            ListKendaraan = listKendaraan;
            Status = status;
        }

        public Driver(User user, Driver driver):base(user)
        {
            IdDriver = driver.IdDriver;
            Pendapatan = driver.Pendapatan;
            Description = driver.Description;
            ListKendaraan = driver.listKendaraan;
            Status = driver.Status;
        }

        public int IdDriver { get => idDriver; set => idDriver=value; }
        public long Pendapatan { get => pendapatan; set => pendapatan = value; }
        public float Rating { get => rating; }
        public List<Kendaraan> ListKendaraan { get => listKendaraan; set => listKendaraan = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }

        public static List<Driver> BacaData() 
        {
            string select = "select * from driver;";
            MySqlDataReader data = ConnectDB.Select(select);
            List<Driver> listDriver = new List<Driver>();

            while (data.Read())
            {
                string selectKendaraan = $"SELECT * FROM kendaraan where id_driver={data["id_driver"]};";
                List<Kendaraan> listKendaraan = Kendaraan.BacaData(selectKendaraan);

                string selectUser = $"SELECT * FROM users where id_users={data["id_user"]};";
                User user = (User.Bacadata(selectUser))[0];

                Driver temp = new Driver(
                    user,
                    (int)data["id_driver"],
                    (long)data["pendapatan"],
                    listKendaraan,
                    (string)data["description"],
                    (string)data["status"]
                    );
                listDriver.Add(temp);
            }
            return listDriver;
        }

        public static List<Driver> BacaData(string perintah)
        {
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<Driver> listDriver = new List<Driver>();

            while (data.Read())
            {
                string selectKendaraan = $"SELECT * FROM kendaraan where id_driver={data["id_driver"]};";
                List<Kendaraan> listKendaraan = Kendaraan.BacaData(selectKendaraan);

                string selectUser = $"SELECT * FROM users where id_users={data["id_user"]};";
                User user = (User.Bacadata(selectUser))[0];

                Driver temp = new Driver(
                    user,
                    (int)data["id_driver"],
                    (long)data["pendapatan"],
                    listKendaraan,
                    (string)data["description"],
                    (string)data["status"]
                    );
                listDriver.Add(temp);
            }
            return listDriver;
        }

        public static void Masukdata(Driver data)
        {
            string perintah = $"INSERT INTO `driver` " +
                              $"(`id_driver`, `id_user`, `pendapatan`, `review`, `description`, `status`) " +
                              $"VALUES ('{data.IdDriver}', '{data.ID_user}', '{data.Pendapatan}', '{data.Rating}', '{data.Description}', '{data.status}');";
            //ConnectDB.InputData(perintah);
            User dataUser = (User)data; 
            User.MasukData(dataUser);
            ConnectDB.InputData(perintah);
        }
    }
}
