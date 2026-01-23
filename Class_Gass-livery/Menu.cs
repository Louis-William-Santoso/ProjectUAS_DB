using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class_Gass_livery
{
    public class Menu
    {
        private int idMenu;
        private Shop tenant;
        private string name;
        private string photo;
        private string description;
        private int harga;
        private int stock;
        private float rating;

        public Menu(int idMenu, Shop tenant, string name,int stock=0, string photo="", int harga=0, string description="")
        {
            IdMenu = idMenu;
            Tenant = tenant;
            Name = name;
            Photo = photo;
            Description = description;
            Harga = harga;
            Stock = stock;
        }


        public int IdMenu { get => idMenu; set => idMenu = value; }
        public Shop Tenant { get => tenant; set => tenant = value; }
        public string Name { get => name; set => name = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Description { get => description; set => description = value; }
        public int Harga { get => harga; set => harga = value; }
        public float Rating { get => rating; set => rating = value; }
        public int Stock { get => stock; set => stock = value; }

        public static List<Menu> Bacadata()
        {
            string select = "select * from menu;";
            MySqlDataReader data = ConnectDB.Select(select);
            List<Menu> list = new List<Menu>();

            while (data.Read() == true) {
                string selectShop = $"SELECT* FROM tenant where id_tenant ={data["id_tenant"]} limit 1;";
                MySqlDataReader dataShop = ConnectDB.Select(selectShop);
                Shop tenant = (Shop)dataShop[0];

                Menu temp = new Menu(
                    (int)data["id_menu"],
                    tenant,
                    (string)data["nama_menu"],
                    (int)data["stock"],
                    (string)data["photo"],
                    (int)data["harga"],
                    (string)data["description"]);
                temp.Rating = (float)data["rating"];
                list.Add(temp);
            }
            return list;
        }

        public static List<Menu> BacaData(string perintah)
        {
            MySqlDataReader data = ConnectDB.Select(perintah);
            List<Menu> list = new List<Menu>();

            while (data.Read() == true)
            {
                string selectShop = $"SELECT* FROM tenant where id_tenant ={data["id_tenant"]} limit 1;";
                MySqlDataReader dataShop = ConnectDB.Select(selectShop);
                Shop tenant = (Shop)dataShop[0];

                Menu temp = new Menu(
                    (int)data["id_menu"],
                    tenant,
                    (string)data["nama_menu"],
                    (int)data["stock"],
                    (string)data["photo"],
                    (int)data["harga"],
                    (string)data["description"]);
                temp.Rating = (float)data["rating"];
                list.Add(temp);
            }
            return list;
        }

        public static void MasukData(Menu menu)
        {
            string insert = $"INSERT INTO `menu` (`id_menu`, `id_tenant`, `nama_menu`, `stock`, `harga`, `rating`, `photo`, `description`) " +
                            $"VALUES ('{menu.IdMenu}', '{menu.Tenant.IdTenant}', '{menu.Name}', '{menu.Stock}', '{menu.Harga}', '{menu.Rating}', '{menu.Photo}', '{menu.Description}');";
            ConnectDB.InputData(insert);
        }

        public static int CreateID()
        {
            int noID = 0;
            string select = $"SELECT id_menu FROM menu WHERE id_menu LIKE '{DateTime.Now.ToString("yyMMdd")}%' ORDER BY id_menu DESC LIMIT 1; ";
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
