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
        private int jumlah;
        private float rating_menu;

        public GassKan(int id_transaksi, User user, Driver driver, DateTime tanggal, float rating_driver, string titik_jemput, string titik_antar, int jarak,
                       int jumlah, float rating_menu, List<Shop> tenant, List<Menu> menus) 
               : base (id_transaksi, user, driver, tanggal, rating_driver, titik_jemput, titik_antar, jarak)
        {
            Jumlah = jumlah;
            Rating_menu = rating_menu;
            Tenant = tenant;
            Menus = menus;
        }

        public int Jumlah { get => jumlah; set => jumlah = value; }
        public float Rating_menu { get => rating_menu; set => rating_menu = value; }
        public List<Shop> Tenant { get => tenant; set => tenant = value; }
        public List<Menu> Menus { get => menus; set => menus = value; }

        /*public static List<GassKan> BacaData()
        {
            string select = "SELECT * FROM gass_kan;";
            List<GassKan> gassKan = new List<GassKan>();
            MySqlDataReader data = ConnectDB.Select(select);

            while (data.Read())
            {
                User dataUser = User.Bacadata($"select * from users where id_users = {data["id_users"]};")[0];
                Driver dataDriver = Driver.BacaData($"select * from driver where id_driver={data["id_driver"]};")[0];
                List<Shop> listShops = new List<Shop>();
                List<Menu> listMenu = new List<Menu>();

                string selectShop = $"SELECT * FROM tenant where id_tenant={data["id_tenant"]};";
                string selectMenu = $"select* from menu where id_menu={data["id_menu"]};";

                MySqlDataReader dataShops = ConnectDB.Select(selectShop);
                MySqlDataReader dataMenu = ConnectDB.Select(selectMenu);

                GassKan gk = new GassKan(
                    
                );

                gassKan.Add( gk );
            }
        }*/
    }
}
