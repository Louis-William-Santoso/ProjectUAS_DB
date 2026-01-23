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

        public GassKan(Transaksi transaksi,
                       int jumlah, float rating_menu, List<Shop> tenant, List<Menu> menus) 
               : base (transaksi)
        {
            Jumlah = jumlah;
            Rating_menu = rating_menu;
            Tenant = tenant;
            Menus = menus;
        }

        public GassKan(Transaksi transaksi, User user, Driver driver, GassKan gassKan) : base(transaksi)
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

        //public static List<GassKan> BacaData()
        //{
        //    string select = "SELECT * FROM gass_kan;";
        //    List<GassKan> gassKan = new List<GassKan>();
        //    MySqlDataReader data = ConnectDB.Select(select);

        //    while (data.Read())
        //    {
        //        Transaksi transaksi = (Transaksi.BacaData($"SELECT * FROM transaksi where id_transaksi={data["id_transaksi"]};"))[0];
        //        User dataUser = User.Bacadata($"select * from users where id_users = {data["id_users"]};")[0];
        //        Driver dataDriver = Driver.BacaData($"select * from driver where id_driver={data["id_driver"]};")[0];
                

        //        GassKan gk = new GassKan(
                    
        //        );

        //        gassKan.Add( gk );
        //    }
        //}
    }
}
