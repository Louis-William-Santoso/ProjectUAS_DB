using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public class Transaksi
    {
        private string id_transaksi;
        private User user;
        private Driver driver;
        private DateTime tanggal;
        private float rating_driver;
        private string titik_jemput;
        private string titik_antar;
        private int jarak;
        private string verifikasi;

        public Transaksi(string id_transaksi, User user, Driver driver, DateTime tanggal, float rating_driver, string titik_jemput, string titik_antar, int jarak)
        {
            Id_transaksi = id_transaksi;
            this.Users = user;
            this.Driver = driver;
            Tanggal = tanggal;
            Rating_driver = rating_driver;
            Titik_jemput = titik_jemput;
            Titik_antar = titik_antar;
            Jarak = jarak;
        }

        public Transaksi(Transaksi transaksi, User user, Driver driver)
        {
            Id_transaksi = transaksi.id_transaksi;
            this.Users = user;
            this.Driver = driver;
            Tanggal = transaksi.Tanggal;
            Rating_driver = transaksi.rating_driver;
            Titik_jemput = transaksi.titik_jemput;
            Titik_antar = transaksi.titik_antar;
            Jarak = transaksi.jarak;
        }

        public string Id_transaksi { get => id_transaksi; set => id_transaksi = value; }
        public User Users { get => user; set => user = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public float Rating_driver { get => rating_driver; set => rating_driver = value; }
        public string Titik_jemput { get => titik_jemput; set => titik_jemput = value; }
        public string Titik_antar { get => titik_antar; set => titik_antar = value; }
        public int Jarak { get => jarak; set => jarak = value; }
        public string Verifikasi { get => verifikasi; set => verifikasi = value; }

        public static List<Transaksi> BacaData()
        {
            string perintah = "SELECT * FROM transaksi;";
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<Transaksi> listTransaksi = new List<Transaksi>();
            
            while (data.Read()) 
            {
                User userData = (User.Bacadata($"select * from users where id_users={data["id_users"]};"))[0];
                Driver driverData = (Driver.BacaData($"SELECT * FROM driver where id_driver={data["id_driver"]};"))[0];
                
                Transaksi transaksi = new Transaksi(
                    data["id_transaksi"].ToString(),
                    userData,
                    driverData,
                    (DateTime)data["tanggal"],
                    (float)data["rating_driver"],
                    data["titik_jemput"].ToString(),
                    data["titik_antar"].ToString(),
                    (int)data["jarak"]
                );
                transaksi.Verifikasi = data["verifikasi"].ToString();

                listTransaksi.Add(transaksi);
            }
            return listTransaksi;
        }

        public static List<Transaksi> BacaData(string perintah)
        {
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<Transaksi> listTransaksi = new List<Transaksi>();

            while (data.Read())
            {
                User userData = (User.Bacadata($"select * from users where id_users={data["id_users"]};"))[0];
                Driver driverData = (Driver.BacaData($"SELECT * FROM driver where id_driver={data["id_driver"]};"))[0];

                Transaksi transaksi = new Transaksi(
                    data["id_transaksi"].ToString(),
                    userData,
                    driverData,
                    (DateTime)data["tanggal"],
                    (float)data["rating_driver"],
                    data["titik_jemput"].ToString(),
                    data["titik_antar"].ToString(),
                    (int)data["jarak"]
                );
                transaksi.Verifikasi = data["verifikasi"].ToString();

                listTransaksi.Add(transaksi);
            }
            return listTransaksi;
        }

        public static void MasukData(Transaksi transaksi)
        {
            string query = $"INSERT INTO `transaksi` (`id_transaksi`, `id_users`, `id_driver`, `rating_driver`, `titik_jemput`, `titik_antar`, `jarak`, `verifikasi`) " +
                           $"VALUES ('{transaksi.Id_transaksi}', '{transaksi.Users.ID_user}', '{transaksi.Driver.IdDriver}'', '{transaksi.Rating_driver}', '{transaksi.Titik_jemput}', " +
                           $"'{transaksi.titik_antar}', '{transaksi.Jarak}', '{transaksi.Verifikasi}');";
            //Connect DB.InputData(query);
        }

        public static string CreateID()
        {
            string noID ="";
            //string select = $"SELECT id_transaksi FROM transaksi WHERE id_transaksi LIKE '{DateTime.Now.ToString("yyMMdd")}%' ORDER BY id_transaksi DESC LIMIT 1; ";
            //MySqlDataReader read = ConnectDB.Select(select);

            //if (read.Read())
            //{
            //    string lastID = read.GetValue(0).ToString().Substring(6);
            //    noID = $"{int.Parse(lastID) + 1}";
            //}
            //int id = int.Parse($"{DateTime.Now.ToString("yyMMdd")}{noID.PadLeft(3, '0')}");
            return noID;
        }

        public static double HitungJarak(Address awal, Address akhir)
        {
            // Jari-jari bumi dalam Kilometer
            double R = 6371;
            double lat1 = awal.Latitude;
            double lon1 = awal.Longitude;
            double lat2 = akhir.Latitude;
            double lon2 = akhir.Longitude;
            // Ubah Latitude & Longitude ke Radian
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Hasil akhirnya dalam KM
            return R * c;
        }

        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
