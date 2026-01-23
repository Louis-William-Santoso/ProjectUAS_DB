using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public class Topup : GassMon
    {
        private int id_topup;
        private long jumlah_topup;
        private DateTime tanggal;

        public Topup(GassMon gassMon, int id, long jumlah, DateTime tanggal): base(gassMon)
        {
            Id_topup = id;
            jumlah_topup = jumlah;
            Tanggal = tanggal;
        }

        public int Id_topup { get => id_topup; set => id_topup = value; }
        public long Jumlah_topup { get => jumlah_topup; set => jumlah_topup = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }

        public static void MasukData(Topup tp)
        {
            string perintah =
                $"INSERT INTO `topup` (`id_topup`, `id_gassmon`, `jumlah_topup`, `tanggal`)" +
                $"VALUES ('{tp.Id_topup}', '{tp.Id_gassmon}', '{tp.Jumlah_topup}', '{tp.Tanggal.ToString("yyMMdd HH:mm:dd")}');";
            ConnectDB.InputData(perintah);
        }
    }
}
