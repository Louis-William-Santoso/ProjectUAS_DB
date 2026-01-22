using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Class_Gass_livery
{
    public class Address
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [JsonConstructor]
        public Address(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public static string GetStringAddress(Address addr)
        {
            string str = $"Lat:{Math.Round(addr.Latitude,3)},Long:{Math.Round(addr.Longitude,3)}";
            return str;
        }
    }
}
