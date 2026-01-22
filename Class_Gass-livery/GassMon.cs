using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Class_Gass_livery
{
    public class GassMon
    {
        private string id_gassmon;
        private User user;
        private long saldo;
        private int point;

        public GassMon(string id_gassmon, User user, long saldo, int point)
        {
            Id_gassmon = id_gassmon;
            User = user;
            Saldo = saldo;
            Point = point;
        }

        public GassMon(GassMon gassMon)
        {
            this.Id_gassmon = gassMon.Id_gassmon;
            this.User = gassMon.User;
            this.Saldo = gassMon.Saldo;
            this.Point = gassMon.Point;
        }

        public string Id_gassmon { get => id_gassmon; set => id_gassmon = value; }
        public User User { get => user; set => user = value; }
        public long Saldo { get => saldo; set => saldo = value; }
        public int Point { get => point; set => point = value; }

        #region Methods
        public static List<GassMon> BacaData()
        {
            string select = "select * from gass_mon;";
            MySqlDataReader mon = ConnectDB.Select(select);
            List<GassMon> listData = new List<GassMon>();

            while (mon.Read())
            {
                GassMon temp = new GassMon(
                    mon["id_gassmon"].ToString(),
                    (User)mon["id_users"],
                    (long)mon["saldo"],
                    (int)mon["point"]
                    );
                listData.Add(temp);
            }

            return listData;
        }

        public static List<GassMon> BacaData(string perintah)
        {
            MySqlDataReader mon = ConnectDB.Select(perintah);
            List<GassMon> listData = new List<GassMon>();

            while (mon.Read())
            {
                GassMon temp = new GassMon(
                    mon["id_gassmon"].ToString(),
                    (User)mon["id_users"],
                    (long)mon["saldo"],
                    (int)mon["point"]
                    );
                listData.Add(temp);
            }

            return listData;
        }


        #endregion
    }
}
