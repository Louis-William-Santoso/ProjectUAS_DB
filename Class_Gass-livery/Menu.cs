using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class_Gass_livery
{
    public class Menu
    {
        private int idMenu;
        private int idTenant;
        private string name;
        private string photo;
        private string description;
        private int harga;
        private int stock;
        private float rating;

        public Menu(int idMenu, int idTenant, string name,int stock=0, string photo="", int harga=0, string description="")
        {
            IdMenu = idMenu;
            IdTenant = idTenant;
            Name = name;
            Photo = photo;
            Description = description;
            Harga = harga;
            Stock = stock;
        }


        public int IdMenu { get => idMenu; set => idMenu = value; }
        public int IdTenant { get => idTenant; set => idTenant = value; }
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
                Menu temp = new Menu(
                    (int)data["id_menu"],
                    (int)data["id_tenant"],
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
                Menu temp = new Menu(
                    (int)data["id_menu"],
                    (int)data["id_tenant"],
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
    }
}
