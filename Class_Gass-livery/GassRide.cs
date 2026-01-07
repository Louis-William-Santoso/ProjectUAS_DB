using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Gass_livery
{
    public class GassRide
    {
        private int id;
        private string titikJemput;
        private string titikAntar;
        private int jarak;
        private int totalBayar;
        private int ratingDriver;
        private bool driverWanita;
        private bool kendaraanBaru;
        private bool verifikasi;

        public GassRide(int id, string titikJemput, string titikAntar, int jarak, int totalBayar)
        {
            Id = id;
            TitikJemput = titikJemput;
            TitikAntar = titikAntar;
            Jarak = jarak;
            TotalBayar = totalBayar;
        }

        public int Id { get => id; set => id = value; }
        public string TitikJemput { get => titikJemput; set => titikJemput = value; }
        public string TitikAntar { get => titikAntar; set => titikAntar = value; }
        public int Jarak { get => jarak; set => jarak = value; }
        public int TotalBayar { get => totalBayar; set => totalBayar = value; }
        public int RatingDriver { get => ratingDriver; set => ratingDriver = value; }
        public bool Verifikasi { get => verifikasi; set => verifikasi = value; }
        public bool DriverWanita { get => driverWanita; set => driverWanita = value; }
        public bool KendaraanBaru { get => kendaraanBaru; set => kendaraanBaru = value; }
    }
}
