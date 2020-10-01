using System;
using System.Runtime.CompilerServices;
namespace AllAccess.Data
{
    public class BusinessData
    {
        private string businessName;
        private string web;
        private string fourSquare;
        private string twitter;
        private string hours;
        private string lats;
        private string longs;
        private string menu;
        private string phone;
        private string venueID;
        public BusinessData() { }
        public BusinessData(string _businessName, string _web, string _foursquare, string twitter, string _hours, string _lats, string _longs, string _menu, string _phone, string _id)
        {
            BusinessName = _businessName;
            Web = _web;
            FourSquares = _foursquare;
            Twitter = twitter;
            Hours = _hours;
            Lats = _lats;
            Longs = _longs;
            Menu = _menu;
            Phone = _phone;
            VenueID = _id;

        }

        public string BusinessName { get => businessName; set => businessName = value; }
        public string Web { get => web; set => web = value; }
        public string FourSquares { get => fourSquare; set => fourSquare = value; }
        public string Hours { get => hours; set => hours = value; }
        public string Menu { get => menu; set => menu = value; }
        public string Phone { get => phone; set => phone = value; }
        public string VenueID { get => venueID; set => venueID = value; }
        public string Lats { get => lats; set => lats = value; }
        public string Longs { get => longs; set => longs = value; }
        public string Twitter { get => twitter; set => twitter = value; }

        public override string ToString()
        {
            return $"{BusinessName}";
        }
    }
}
