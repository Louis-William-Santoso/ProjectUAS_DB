using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public class GassRide : Transaksi
    {
        private int id_gassride;
        private int totalBayar;
        private sbyte driverWanita;
        private sbyte kendaraanBaru;

        public GassRide(Transaksi transaksi,
                        GassRide gassRide)
                        : base(transaksi)
        {
            Id_gassride = gassRide.Id_gassride;
            totalBayar = gassRide.TotalBayar;
            driverWanita = gassRide.DriverWanita;
            kendaraanBaru = gassRide.KendaraanBaru;
        }

        public GassRide(Transaksi transaksi,
                        int id_gassride,int totalBayar, sbyte driverWanita, sbyte kendaraanBaru)
                        : base(transaksi)
        {
            Id_gassride = id_gassride;
            TotalBayar = totalBayar;
            DriverWanita = driverWanita;
            KendaraanBaru = kendaraanBaru;
        }

        public int TotalBayar { get => totalBayar; set => totalBayar = value; }
        public sbyte DriverWanita { get => driverWanita; set => driverWanita = value; }
        public sbyte KendaraanBaru { get => kendaraanBaru; set => kendaraanBaru = value; }
        public int Id_gassride { get => id_gassride; set => id_gassride = value; }
    
        public static List<GassRide> BacaData()
        {
            string perintah = $"SELECT * FROM gass_ride;";
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<GassRide> ListGassRide = new List<GassRide>();

            while (data.Read())
            { 
                Transaksi transaksi = (Transaksi.BacaData($"SELECT * FROM transaksi where id_transaksi={data["id_transaksi"]};"))[0];

                GassRide dataGassRide = new GassRide(
                    transaksi,
                    (int)data["id_gassride"],
                    (int)data["total_bayar"],
                    (sbyte)data["driver_wanita"],
                    (sbyte)data["kendaraan_baru"]
                );
                ListGassRide.Add(dataGassRide);
            }
            return ListGassRide;
        }

        public static List<GassRide> BacaData(string perintah)
        {
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<GassRide> ListGassRide = new List<GassRide>();

            while (data.Read())
            {
                Transaksi transaksi = (Transaksi.BacaData($"SELECT * FROM transaksi where id_transaksi={data["id_transaksi"]};"))[0];

                GassRide dataGassRide = new GassRide(
                    transaksi,
                    (int)data["id_gassride"],
                    (int)data["total_bayar"],
                    (sbyte)data["driver_wanita"],
                    (sbyte)data["kendaraan_baru"]
                );
                ListGassRide.Add(dataGassRide);
            }
            return ListGassRide;
        }

        public static void MasukData(GassRide gassRide)
        {
            Transaksi temp = gassRide;
            Transaksi.MasukData(temp);
            string query = $"INSERT INTO `gass_ride` (`id_gassride`, `id_transaksi`, `driver_wanita`, `kendaraan_baru`, `total_bayar`) " +
                           $"VALUES('{gassRide.Id_gassride}', '{gassRide.Id_transaksi}', '{gassRide.DriverWanita}', '{gassRide.KendaraanBaru}', '{gassRide.totalBayar}');";
            
            ConnectDB.InputData(query);
        }

        public static int CreateID()
        {
            int noID = 0;
            string select = $"SELECT id_gassride FROM gass_ride WHERE id_gassride LIKE '{DateTime.Now.ToString("yyMMdd")}%' ORDER BY id_gassride DESC LIMIT 1; ";
            MySqlDataReader read = ConnectDB.Select(select);

            if (read.Read())
            {
                string lastID = read.GetValue(0).ToString().Substring(6);
                noID = int.Parse(lastID) + 1;
            }
            int id = int.Parse($"{DateTime.Now.ToString("yyMMdd")}{noID.ToString().PadLeft(3, '0')}");
            return id;
        }
    }
}
