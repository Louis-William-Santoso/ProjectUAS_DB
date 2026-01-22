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
        

        public GassKan(Transaksi transaksi, User user, Driver driver,
                       int jumlah, float rating_menu, List<Shop> tenant, List<Menu> menus) 
               : base (transaksi, user,driver)
        {
            Jumlah = jumlah;
            Rating_menu = rating_menu;
            Tenant = tenant;
            Menus = menus;
        }

        public GassKan(Transaksi transaksi, User user, Driver driver, GassKan gassKan) : base(transaksi, user, driver)
        {
            Jumlah = jumlah;
            Rating_menu = rating_menu;
            Tenant = tenant;
            Menus = menus;
        }
        
        public int Id_gasskan { get => id_gasskan; set => id_gasskan = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public float Rating_menu { get => rating_menu; set => rating_menu = value; }
        public List<Shop> Tenant { get => tenant; set => tenant = value; }
        public List<Menu> Menus { get => menus; set => menus = value; }
        #region Methods Database

        public static int CreateID()
        {
            
            int noID = 1;
            string datePart = DateTime.Now.ToString("yyMMdd");

           
            string select = $"SELECT id_gasskan FROM gass_kan WHERE id_gasskan LIKE '{datePart}%' ORDER BY id_gasskan DESC LIMIT 1;";
            MySqlDataReader read = ConnectDB.Select(select);

            if (read.Read())
            {
               
                string lastID = read.GetValue(0).ToString();
                if (lastID.Length > 6)
                {
                    string sequencePart = lastID.Substring(6);
                    noID = int.Parse(sequencePart) + 1;
                }
            }

            
            int newID = int.Parse($"{datePart}{noID.ToString().PadLeft(3, '0')}");
            return newID;
        }

        public static void MasukData(GassKan gassKan)
        {
           
            Transaksi.MasukData(gassKan);

            
            int idMenu = 0;
            int idTenant = 0;

            if (gassKan.Menus.Count > 0) idMenu = gassKan.Menus[0].IdMenu;
            if (gassKan.Tenant.Count > 0) idTenant = gassKan.Tenant[0].IdTenant;

            string query = $"INSERT INTO `gass_kan` " +
                           $"(`id_gasskan`, `id_menu`, `id_tenant`, `id_transaksi`, `jumlah`, `rating_menu`) " +
                           $"VALUES ('{gassKan.Id_gasskan}', '{idMenu}', '{idTenant}', '{gassKan.Id_transaksi}', '{gassKan.Jumlah}', '{gassKan.Rating_menu}');";

            ConnectDB.InputData(query);
        }

        #endregion
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
