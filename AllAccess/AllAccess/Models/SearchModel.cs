//To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AllAccess.Models;
//
//  var searchModel = SearchModel.FromJson(jsonString);
using System.Runtime.InteropServices;

namespace AllAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;



    public partial class SearchModel
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("venues")]
        public List<Venue> Venues { get; set; }

        [JsonProperty("confident")]
        public bool Confident { get; set; }
    }

    public partial class Venue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("referralId")]
        public ReferralId ReferralId { get; set; }

        [JsonProperty("hasPerk")]
        public bool HasPerk { get; set; }

        [JsonProperty("venuePage", NullValueHandling = NullValueHandling.Ignore)]
        public VenuePage VenuePage { get; set; }

    }

    public partial class Category
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pluralName")]
        public string PluralName { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }

    public partial class Icon
    {
        [JsonProperty("prefix")]
        public Uri Prefix { get; set; }

        [JsonProperty("suffix")]
        public Suffix Suffix { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("crossStreet", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossStreet { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("labeledLatLngs")]
        public List<LabeledLatLng> LabeledLatLngs { get; set; }

        [JsonProperty("distance")]
        public long Distance { get; set; }

        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? PostalCode { get; set; }

        [JsonProperty("cc")]
        public Cc Cc { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public City? City { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("formattedAddress")]
        public List<string> FormattedAddress { get; set; }
    }

    public partial class LabeledLatLng
    {
        [JsonProperty("label")]
        public Label Label { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public partial class VenuePage
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }
    }

    public enum Suffix { Png };

    public enum Cc { Us };

    public enum City { Brooklyn, NewYork, Rochester };

    public enum Country { UnitedStates };

    public enum Label { Display };

    public enum State { NewYork, Ny };

    public enum ReferralId { V1537115228, V1537711861, V1537712297};

    public partial class SearchModel
    {
        public static SearchModel FromJson(string json) => JsonConvert.DeserializeObject<SearchModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SearchModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                SuffixConverter.Singleton,
                CcConverter.Singleton,
                CityConverter.Singleton,
                CountryConverter.Singleton,
                LabelConverter.Singleton,
                StateConverter.Singleton,
                ReferralIdConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class SuffixConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Suffix) || t == typeof(Suffix?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == ".png")
            {
                return Suffix.Png;
            }
            throw new Exception("Cannot unmarshal type Suffix");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Suffix)untypedValue;
            if (value == Suffix.Png)
            {
                serializer.Serialize(writer, ".png");
                return;
            }
            throw new Exception("Cannot marshal type Suffix");
        }

        public static readonly SuffixConverter Singleton = new SuffixConverter();
    }

    internal class CcConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Cc) || t == typeof(Cc?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "US")
            {
                return Cc.Us;
            }
            throw new Exception("Cannot unmarshal type Cc");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Cc)untypedValue;
            if (value == Cc.Us)
            {
                serializer.Serialize(writer, "US");
                return;
            }
            throw new Exception("Cannot marshal type Cc");
        }

        public static readonly CcConverter Singleton = new CcConverter();
    }

    internal class CityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(City) || t == typeof(City?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Brooklyn":
                    return City.Brooklyn;
                case "New York":
                    return City.NewYork;
                case "Rochester":
                    return City.Rochester;
            }
            throw new Exception("Cannot unmarshal type City");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (City)untypedValue;
            switch (value)
            {
                case City.Brooklyn:
                    serializer.Serialize(writer, "Brooklyn");
                    return;
                case City.NewYork:
                    serializer.Serialize(writer, "New York");
                    return;
                
            }
            throw new Exception("Cannot marshal type City");
        }

        public static readonly CityConverter Singleton = new CityConverter();
    }

    internal class CountryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Country) || t == typeof(Country?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "United States")
            {
                return Country.UnitedStates;
            }
            throw new Exception("Cannot unmarshal type Country");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Country)untypedValue;
            if (value == Country.UnitedStates)
            {
                serializer.Serialize(writer, "United States");
                return;
            }
            throw new Exception("Cannot marshal type Country");
        }

        public static readonly CountryConverter Singleton = new CountryConverter();
    }

    internal class LabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Label) || t == typeof(Label?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "display")
            {
                return Label.Display;
            }
            throw new Exception("Cannot unmarshal type Label");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Label)untypedValue;
            if (value == Label.Display)
            {
                serializer.Serialize(writer, "display");
                return;
            }
            throw new Exception("Cannot marshal type Label");
        }

        public static readonly LabelConverter Singleton = new LabelConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class StateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(State) || t == typeof(State?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "NY":
                    return State.Ny;
                case "New York":
                    return State.NewYork;
            }
            throw new Exception("Cannot unmarshal type State");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (State)untypedValue;
            switch (value)
            {
                case State.Ny:
                    serializer.Serialize(writer, "NY");
                    return;
                case State.NewYork:
                    serializer.Serialize(writer, "New York");
                    return;
            }
            throw new Exception("Cannot marshal type State");
        }

        public static readonly StateConverter Singleton = new StateConverter();
    }

    internal class ReferralIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ReferralId) || t == typeof(ReferralId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            String value = serializer.Deserialize<string>(reader);
            Debug.WriteLine("Checking the TYPE!!!! "+value);
            if (value == "v-1537115228")
            {
                return ReferralId.V1537115228;
            }
            else if(value == "v-1537712297")
            {
                return ReferralId.V1537712297;
            }
            else
            {
                return ReferralId.V1537711861;           
            }
            throw new Exception("Cannot unmarshal type ReferralId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            
            var value = (ReferralId)untypedValue;
            if (value == ReferralId.V1537115228)
            {
                serializer.Serialize(writer, "v-1537115228");
                return;
            }
            else if (value == ReferralId.V1537711861)
            {
                serializer.Serialize(writer, "v-1537711861");
                return;
            }
            else if (value == ReferralId.V1537712297)
            {
                serializer.Serialize(writer, "v-1537712297");
            }
            else
            {

                serializer.Serialize(writer, untypedValue.ToString());
            }
            throw new Exception("Cannot marshal type ReferralId");
        }

        public static readonly ReferralIdConverter Singleton = new ReferralIdConverter();
    }
}
