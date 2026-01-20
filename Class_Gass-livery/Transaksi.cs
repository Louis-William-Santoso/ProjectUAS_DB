using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public abstract class Transaksi
    {
        private int id_transaksi;
        private User user;
        private Driver driver;
        private DateTime tanggal;
        private float rating_driver;
        private string titik_jemput;
        private string titik_antar;
        private int jarak;

        protected Transaksi(int id_transaksi, User user, Driver driver, DateTime tanggal, float rating_driver, string titik_jemput, string titik_antar, int jarak)
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

        protected Transaksi(Transaksi transaksi, User user, Driver driver)
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

        public int Id_transaksi { get => id_transaksi; set => id_transaksi = value; }
        public User Users { get => user; set => user = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public float Rating_driver { get => rating_driver; set => rating_driver = value; }
        public string Titik_jemput { get => titik_jemput; set => titik_jemput = value; }
        public string Titik_antar { get => titik_antar; set => titik_antar = value; }
        public int Jarak { get => jarak; set => jarak = value; }

        /*public static List<Transaksi> BacaData()
        {
            string perintah = "SELECT * FROM transaksi;";
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<Transaksi> listTransaksi = new List<Transaksi>();
            
            while (data.Read()) 
            {
                User userData = (User.Bacadata($"select * from users where id_users={data["id_users"]};"))[0];
                Transaksi transaksi = new Transaksi(
                    (int)data["id_tenant"],
                    userData,
                    ()
                );
            }
        }*/
    }
}
