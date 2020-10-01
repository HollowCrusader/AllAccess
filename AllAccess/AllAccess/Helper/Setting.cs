using System;
using Plugin.Connectivity.Abstractions;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Plugin.Geolocator.Abstractions;

namespace AllAccess.Helper
{
    public class Setting
    {
        static bool firstTime;
        public static bool FirstTimeOpen
        {
            get { return firstTime; }
            set { firstTime = value; }

        }

        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        static string city = String.Empty;

        public static string City
        {
            get { return city; }

            set { city = value; }
        }

        static string streetAddress = String.Empty;

        public static string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        static double lats;

        public static double Lats
        {
            get { return lats; }

            set { lats = value; }
        }



        static double lons;

        public static double Lons
        {
            get { return Lons; }

            set { lons = value; }
        }

        static string zipCode = String.Empty;

        public static string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        static string state = String.Empty;

        public static string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
