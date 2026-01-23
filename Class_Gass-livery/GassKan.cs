using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Class_Gass_livery
{
    public class GassKan : Transaksi
    {
        private List<Shop> tenant = new List<Shop>();
        private List<Menu> menus = new List<Menu>();
        private int id_gasskan;
        private int jumlah;
        private float rating_menu;
        private sbyte halal; 

        public GassKan(Transaksi transaksi,
                       int jumlah, float rating_menu, List<Shop> tenant, List<Menu> menus, sbyte hahal) 
               : base (transaksi)
        {
            Jumlah = jumlah;
            Rating_menu = rating_menu;
            Tenant = tenant;
            Menus = menus;
            Halal = hahal;
        }

        public GassKan(Transaksi transaksi, User user, Driver driver, GassKan gassKan) : base(transaksi)
        {
            Jumlah = gassKan.Jumlah;
            Rating_menu = gassKan.rating_menu;
            Tenant = gassKan.tenant;
            Menus = gassKan.menus;
            Halal = gassKan.halal;
        }

        public int Jumlah { get => jumlah; set => jumlah = value; }
        public float Rating_menu { get => rating_menu; set => rating_menu = value; }
        public List<Shop> Tenant { get => tenant; set => tenant = value; }
        public List<Menu> Menus { get => menus; set => menus = value; }
        public sbyte Halal { get => halal; set => halal = value; }
        public int Id_gasskan { get => id_gasskan; set => id_gasskan = value; }

        public static List<GassKan> BacaData()
        {
            string select = "SELECT * FROM gass_kan;";
            MySqlDataReader data = ConnectDB.Select(select);

            // Gunakan list sementara untuk menampung ID agar tidak kena "Nested Reader Error"
            List<GassKan> listGassKan = new List<GassKan>();

            // Kita buat list penampung data mentah dulu dari DB
            var dataMentah = new List<dynamic>();

            while (data.Read())
            {
                dataMentah.Add(new
                {
                    IdGassKan = (int)data["id_gasskan"],
                    IdTransaksi = (int)data["id_transaksi"],
                    IdTenant = (int)data["id_tenant"],
                    IdMenu = (int)data["id_menu"],
                    Jumlah = (int)data["jumlah"],
                    Rating = (float)data["rating_menu"],
                    Halal = (sbyte)data["hahal_food"]
                });
            }
            data.Close(); 

            foreach (var item in dataMentah)
            {
                Transaksi trans = Transaksi.BacaData($"SELECT * FROM transaksi WHERE id_transaksi={item.IdTransaksi}")[0];
                List<Shop> t = Shop.Bacadata($"SELECT * FROM tenant WHERE id_tenant={item.IdTenant}");
                List<Menu> m = Menu.BacaData($"SELECT * FROM menu WHERE id_menu={item.IdMenu}");

                GassKan gk = new GassKan(trans, item.Jumlah, item.Rating, t, m, item.Halal);
                gk.Id_gasskan = item.IdGassKan;
                listGassKan.Add(gk);
            }

            return listGassKan; 
        }

        public static List<GassKan> BacaData(string select)
        {
            MySqlDataReader data = ConnectDB.Select(select);

            // Gunakan list sementara untuk menampung ID agar tidak kena "Nested Reader Error"
            List<GassKan> listGassKan = new List<GassKan>();

            // Kita buat list penampung data mentah dulu dari DB
            var dataMentah = new List<dynamic>();

            while (data.Read())
            {
                dataMentah.Add(new
                {
                    IdGassKan = (int)data["id_gasskan"],
                    IdTransaksi = (int)data["id_transaksi"],
                    IdTenant = (int)data["id_tenant"],
                    IdMenu = (int)data["id_menu"],
                    Jumlah = (int)data["jumlah"],
                    Rating = (float)data["rating_menu"],
                    Halal = (sbyte)data["hahal_food"]
                });
            }
            data.Close();

            foreach (var item in dataMentah)
            {
                Transaksi trans = Transaksi.BacaData($"SELECT * FROM transaksi WHERE id_transaksi={item.IdTransaksi}")[0];
                List<Shop> t = Shop.Bacadata($"SELECT * FROM tenant WHERE id_tenant={item.IdTenant}");
                List<Menu> m = Menu.BacaData($"SELECT * FROM menu WHERE id_menu={item.IdMenu}");

                GassKan gk = new GassKan(trans, item.Jumlah, item.Rating, t, m, item.Halal);
                gk.Id_gasskan = item.IdGassKan;
                listGassKan.Add(gk);
            }

            return listGassKan;
        }

        public static int CreateID()
        {
            int noID = 0;
            string select = $"SELECT id_gasskan FROM gass_kan WHERE id_gasskan LIKE '{DateTime.Now.ToString("yyMMdd")}%' ORDER BY id_gasskan DESC LIMIT 1; ";
            MySqlDataReader read = ConnectDB.Select(select);

            if (read.Read())
            {
                string lastID = read.GetValue(0).ToString().Substring(6);
                noID = int.Parse(lastID) + 1;
            }
            int id = int.Parse($"{DateTime.Now.ToString("yyMMdd")}{noID.ToString().PadLeft(3, '0')}");
            return id;
        }

        public static void MasukData(GassKan gassKan)
        {

        }
    }
}
