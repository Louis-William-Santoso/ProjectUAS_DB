using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public class Kendaraan
    {
        private string idKendaraan;
        private int idDriver;
        private DateTime tahunProduksi;
        private string jenis;

        public Kendaraan(string idKendaraan, int idDriver, DateTime tahunProduksi, string jenis)
        {
            IdKendaraan = idKendaraan;
            IdDriver = idDriver;
            TahunProduksi = tahunProduksi;
            Jenis = jenis;
        }

        public string IdKendaraan { get => idKendaraan; set => idKendaraan = value; }
        public int IdDriver { get => idDriver; set => idDriver = value; }
        public DateTime TahunProduksi { get => tahunProduksi; set => tahunProduksi = value; }
        public string Jenis { get => jenis; set => jenis = value; }

        public static List<Kendaraan> BacaData()
        {
            string select = "select * from kendaraan;";
            MySqlDataReader kendaraan = ConnectDB.Select(select);
            List<Kendaraan> listData = new List<Kendaraan>();

            while (kendaraan.Read()) 
            {
                Kendaraan temp = new Kendaraan(
                    kendaraan["id_kendaraan"].ToString(),
                    (int)kendaraan["id_driver"],
                    (DateTime)kendaraan["tahun_produksi"],
                    (string)kendaraan["jenis"]);
                listData.Add(temp);
            }

            return listData;
        }

        public static List<Kendaraan> BacaData(string perintah)
        {
            MySqlDataReader kendaraan = ConnectDB.Select(perintah);
            List<Kendaraan> listData = new List<Kendaraan>();

            while (kendaraan.Read())
            {
                Kendaraan temp = new Kendaraan(
                    kendaraan["id_kendaraan"].ToString(),
                    (int)kendaraan["id_driver"],
                    (DateTime)kendaraan["tahun_produksi"],
                    (string)kendaraan["jenis"]);
                listData.Add(temp);
            }

            return listData;
        }
    }
}
