using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public class Transfer : GassMon
    {
        private int id_transfer;
        private long jumlah_transfer;
        private DateTime tanggal;
        private int id_sender;
        private int id_receiver;

        public Transfer(GassMon gassMon, int id, long jumlah, DateTime tanggal, int id_sender, int id_receiver) : base(gassMon)
        {
            Id_transfer = id;
            jumlah_transfer = jumlah;
            Tanggal = tanggal;
            this.Id_sender = id_sender;
            this.Id_receiver = id_receiver;
        }

        public int Id_transfer { get => id_transfer; set => id_transfer = value; }
        public long Jumlah_transfer { get => jumlah_transfer; set => jumlah_transfer = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int Id_sender { get => id_sender; set => id_sender = value; }
        public int Id_receiver { get => id_receiver; set => id_receiver = value; }

        public static void MasukData(Transfer tf)
        {
            string perintah = 
                $"INSERT INTO `transfer` (`id_transfer`, `id_gassmon`, `jumlah_transfer`, `tanggal`, `id_sender`, `id_receiver`)" +
                $"VALUES ('{tf.Id_transfer}', '{tf.Id_gassmon}', '{tf.Jumlah_transfer}', '{tf.Tanggal.ToString("yyMMdd HH:mm:dd")}', '{tf.Id_sender}', '{tf.Id_receiver}');";
            ConnectDB.InputData(perintah);
        }
    }
}