using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Class_Gass_livery
{
    public class GassKan
    {
        private int idTransaksi;
        private string titikJemput;
        private string titikAntar;
        private int jarak;
        private List<Menu> menu;
        private List<Shop> tenant;
        private float ratingMenu;
        private float ratingDriver;

        public GassKan(int idTransaksi, string titikJemput, string titikAntar, int jarak, List<Menu> menu, List<Shop> tenant)
        {
            IdTransaksi = idTransaksi;
            TitikJemput = titikJemput;
            TitikAntar = titikAntar;
            Jarak = jarak;
            MenuOrder = menu;
            Tenant = tenant;
        }

        public int IdTransaksi { get => idTransaksi; set => idTransaksi = value; }
        public string TitikJemput { get => titikJemput; set => titikJemput = value; }
        public string TitikAntar { get => titikAntar; set => titikAntar = value; }
        public int Jarak { get => jarak; set => jarak = value; }
        public List<Menu> MenuOrder { get => menu; set => menu = value; }
        public List<Shop> Tenant { get => tenant; set => tenant = value; }
        public float RatingMenu { get => ratingMenu; set => ratingMenu = value; }
        public float RatingDriver { get => ratingDriver; set => ratingDriver = value; }
        
        public static List<GassKan> BacaData()
        {
            string gassKan = "select * from gass_kan;";
            MySqlDataReader dataGassKan = ConnectDB.Select(gassKan);
            List<GassKan> listData = new List<GassKan>();

            while (dataGassKan.Read())
            {
                #region Read data Menu
                string menu = "SELECT m.id_menu, m.id_tenant, m.nama_menu, m.harga, m.stock, m.rating, photo, description " +
                            "FROM gaskan_order gkd inner join menu m " +
                            "on gkd.id_menu=m.id_menu" +
                            $"where id_transaksi={dataGassKan["id_transaksi"]}" +
                            "group by m.id_menu;";
                List<Menu> listMenu = Menu.BacaData(menu);
                #endregion

                #region Read Data Shop
                string shop = "select id_users, t.id_tenant, t.nama_tenant, t.alamat, t.rating, t.photo" +
                    "from tenant t inner join gaskan_order go" +
                    "on t.id_tenant = go.id_tenant" +
                    $"where go.id_transaksi={dataGassKan["id_transaksi"]}" +
                    "group by t.id_tenant;";
                List<Shop> listShop = Shop.Bacadata(shop);
                #endregion

                GassKan temp = new GassKan(
                    (int)dataGassKan["id_transaksi"],
                    (string)dataGassKan["titik_jemput"],
                    (string)dataGassKan["titik_Antar"],
                    (int)dataGassKan["jarak"],
                    listMenu,
                    listShop);
            }
            return listData;
        }
    }
}
