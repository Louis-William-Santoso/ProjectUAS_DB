using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class_Gass_livery
{
    public class Shop
    {
        private int idTenant;
        private int idUser;
        private string namaToko;
        private string alamat;
        private string photo;
        private float rating;
        private List<Menu> menuList;

        public Shop(int idTenant, int idUser, string name, string alamat, List<Menu> menuList, string photo="")
        {
            IdTenant = idTenant;
            IdUser = idUser;
            NamaToko = name;
            Alamat = alamat;
            Photo = photo;
            MenuList = menuList;
        }

        public int IdTenant { get => idTenant; set => idTenant = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string NamaToko { get => namaToko; set => namaToko = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Photo { get => photo; set => photo = value; }
        public float Rating { get => rating; set => rating = value; }
        public List<Menu> MenuList { get => menuList; set => menuList = value; }

        public static List<Shop> Bacadata()
        {
            string select = "select * from tenant;";
            MySqlDataReader data = ConnectDB.Select(select);
            List<Shop> list = new List<Shop>();

            while (data.Read() == true)
            {
                string menu = "select m.id_menu, m.id_tenant, nama_menu, stock, harga, m.rating, m.photo, description" +
                    "from tenant t inner join menu m" +
                    "on t.id_tenant=m.id_tenant" +
                    $"where m.id_tenant={data["id_tenant"]}" +
                    "group by m.id_menu;";
                MySqlDataReader dataMenu = ConnectDB.Select(menu);
                List<Menu> listMenu = new List<Menu>();

                while (dataMenu.Read() == true)
                {
                    Menu tempMenu = new Menu(
                        (int)dataMenu["id_menu"],
                        (int)dataMenu["id_tenant"],
                        (string)dataMenu["nama_menu"],
                        (int)dataMenu["stock"],
                        (string)dataMenu["photo"],
                        (int)dataMenu["harga"],
                        (string)dataMenu["description"]);
                    tempMenu.Rating = (float)dataMenu["rating"];
                    listMenu.Add(tempMenu);
                }

                Shop temp = new Shop(
                    (int)data["id_tenant"],
                    (int)data["id_user"],
                    (string)data["nama_tenant"],
                    (string)data["alamat"],
                    listMenu,
                    (string)data["photo"]);
                temp.Rating = (float)data["rating"];
                list.Add(temp);
            }
            return list;
        }

        public static List<Shop> Bacadata(string perintah)
        {
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<Shop> list = new List<Shop>();

            while (data.Read() == true)
            {
                string menu = "select m.id_menu, m.id_tenant, nama_menu, stock, harga, m.rating, m.photo, description" +
                    "from tenant t inner join menu m" +
                    "on t.id_tenant=m.id_tenant" +
                    $"where m.id_tenant={data["id_tenant"]}" +
                    "group by m.id_menu;";
                MySqlDataReader dataMenu = ConnectDB.Select(menu);
                List<Menu> listMenu = new List<Menu>();

                while (dataMenu.Read() == true)
                {
                    Menu tempMenu = new Menu(
                        (int)dataMenu["id_menu"],
                        (int)dataMenu["id_tenant"],
                        (string)dataMenu["nama_menu"],
                        (int)dataMenu["stock"],
                        (string)dataMenu["photo"],
                        (int)dataMenu["harga"],
                        (string)dataMenu["description"]);
                    tempMenu.Rating = (float)dataMenu["rating"];
                    listMenu.Add(tempMenu);
                }

                Shop temp = new Shop(
                    (int)data["id_tenant"],
                    (int)data["id_user"],
                    (string)data["nama_tenant"],
                    (string)data["alamat"],
                    listMenu,
                    (string)data["photo"]);
                temp.Rating = (float)data["rating"];
                list.Add(temp);
            }
            return list;
        }
    }
}
