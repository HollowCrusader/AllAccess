using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AllAccess.ViewModels;
using System.Diagnostics;
namespace AllAccess.Models
{
    public class SearchModels
    {


        public class Meta
        {
            [JsonProperty("code")]
            public int code { get; set; } 
            [JsonProperty("requestId")]
            public string requestId { get; set; }
        }

        public class LabeledLatLng
        {
            [JsonProperty("label")]
            public string label { get; set; }
            [JsonProperty("lat")]
            public double lat { get; set; }
            [JsonProperty("lng")]
            public double lng { get; set; }
        }

        public class Location
        {
            [JsonProperty("lat")]
            public double lat { get; set; }
            [JsonProperty("lng")]
            public double lng { get; set; }
            [JsonProperty("labeledLatLngs")]
            public List<LabeledLatLng> labeledLatLngs { get; set; }
            [JsonProperty("distance")]
            public int distance { get; set; }
            [JsonProperty("postalCode")]
            public string postalCode { get; set; }
            [JsonProperty("cc")]
            public string cc { get; set; }
            [JsonProperty("state")]
            public string state { get; set; }
            [JsonProperty("country")]
            public string country { get; set; }
            [JsonProperty("formattedAddress")]
            public List<string> formattedAddress { get; set; }
            [JsonProperty("address")]
            public string address { get; set; }
            [JsonIgnore]
            public string neighborhood { get; set; }
            [JsonProperty("city")]
            public string city { get; set; }
            [JsonProperty("crossStreet")]
            public string crossStreet { get; set; }
        }

        public class Icon
        {
            [JsonProperty("prefix")]
            public string prefix { get; set; }
            [JsonProperty("suffix")]
            public string suffix { get; set; }
        }

        public class Category
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("pluralName")]
            public string pluralName { get; set; }
            [JsonProperty("shortName")]
            public string shortName { get; set; }
            [JsonProperty("icon")]
            public Icon icon { get; set; }
            [JsonProperty("primary")]
            public bool primary { get; set; }
        }

        public class VenuePage
        {
            [JsonProperty("id")]
            public string id { get; set; }
        }

        public class Venue
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("location")]
            public Location location { get; set; }
            [JsonProperty("categories")]
            public List<Category> categories { get; set; }
            [JsonIgnore]
            public string referralId { get; set; }
            [JsonProperty("hasPerk")]
            public bool hasPerk { get; set; }
            [JsonProperty("referralId")]
            public VenuePage venuePage { get; set; }
            //[JsonIgnore]
            //public static ObservableCollection<Venue> ShowVenues = new ObservableCollection<Venue>();
            //[JsonIgnore]
            //public string ShowAddress => $"{name}\n {location}";

            //public Venue()
            //{
            //    Debug.WriteLine($"Checking to see if it show address:\n {ShowAddress}");
            //}
        }



        public class Response
        {
            [JsonProperty("venues")]
            public static ObservableCollection<Venue> venues { get; set; } = new ObservableCollection<Venue>();
            
        }

        public class SearchRoot
        {
            [JsonProperty("meta")]
            public Meta meta { get; set; }
            [JsonProperty("response")]
            public Response response { get; set; }
            //[JsonIgnore]
            //public static ObservableCollection<SearchModels> Roots { get; set; } = SearchViewModel.SearchList;
        }
    }
}
