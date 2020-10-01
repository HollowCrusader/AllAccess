namespace AllAccess.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Empty
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("code")]
        public long Code2 { get; set; }

        [JsonProperty("requestId")]
        public string RequestId2 { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("venue")]
        public Venue Venue { get; set; }
    }

    public partial class Venue
    {
        [JsonProperty("id")]
        public string Id2 { get; set; }

        [JsonProperty("name")]
        public string Name2 { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("location")]
        public Location Location2 { get; set; }

        [JsonProperty("canonicalUrl")]
        public Uri CanonicalUrl { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories2 { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        [JsonProperty("dislike")]
        public bool Dislike { get; set; }

        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("allowMenuUrlEdit")]
        public bool AllowMenuUrlEdit { get; set; }

        [JsonProperty("beenHere")]
        public BeenHere BeenHere { get; set; }

        [JsonProperty("specials")]
        public Inbox Specials { get; set; }

        [JsonProperty("photos")]
        public HereNow Photos { get; set; }

        [JsonProperty("reasons")]
        public Inbox Reasons { get; set; }

        [JsonProperty("hereNow")]
        public HereNow HereNow { get; set; }

        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("tips")]
        public Likes Tips { get; set; }

        [JsonProperty("shortUrl")]
        public Uri ShortUrl { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("listed")]
        public Likes Listed { get; set; }

        [JsonProperty("pageUpdates")]
        public Inbox PageUpdates { get; set; }

        [JsonProperty("inbox")]
        public Inbox Inbox { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonIgnore]
        public string DisplayWeb => $"{ShortUrl.ToString()}";
    }

    public partial class Attributes
    {
        [JsonProperty("groups")]
        public Group[] Groups { get; set; }
    }

    public partial class Group
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("priceTier")]
        public long PriceTier { get; set; }
    }

    public partial class BeenHere
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("unconfirmedCount")]
        public long UnconfirmedCount { get; set; }

        [JsonProperty("marked")]
        public bool Marked { get; set; }

        [JsonProperty("lastCheckinExpiredAt")]
        public long LastCheckinExpiredAt { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("id")]
        public string Id2 { get; set; }

        [JsonProperty("name")]
        public string Name2 { get; set; }

        [JsonProperty("pluralName")]
        public string PluralName2 { get; set; }

        [JsonProperty("shortName")]
        public string ShortName2 { get; set; }

        [JsonProperty("icon")]
        public Icon Icon2 { get; set; }

        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary2 { get; set; }
    }

    public partial class Icon
    {
        [JsonProperty("prefix")]
        public Uri Prefix2 { get; set; }

        [JsonProperty("suffix")]
        public string Suffix2 { get; set; }
    }

    public partial class Contact
    {
    }

    public partial class HereNow
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("groups")]
        public Group[] Groups { get; set; }
    }

    public partial class Inbox
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public object[] Items { get; set; }
    }

    public partial class Likes
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("groups")]
        public Group[] Groups { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("address")]
        public string Address2 { get; set; }

        [JsonProperty("crossStreet")]
        public string CrossStreet2 { get; set; }

        [JsonProperty("lat")]
        public double Lat2 { get; set; }

        [JsonProperty("lng")]
        public double Lng2 { get; set; }

        [JsonProperty("labeledLatLngs")]
        public LabeledLatLng[] LabeledLatLngs2 { get; set; }

        [JsonProperty("postalCode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PostalCode2 { get; set; }

        [JsonProperty("cc")]
        public string Cc2 { get; set; }

        [JsonProperty("city")]
        public string City2 { get; set; }

        [JsonProperty("state")]
        public string State2 { get; set; }

        [JsonProperty("country")]
        public string Country2 { get; set; }

        [JsonProperty("formattedAddress")]
        public string[] FormattedAddress2 { get; set; }
    }

    public partial class LabeledLatLng
    {
        [JsonProperty("label")]
        public string Label2 { get; set; }

        [JsonProperty("lat")]
        public double Lat2 { get; set; }

        [JsonProperty("lng")]
        public double Lng2 { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("tipCount")]
        public long TipCount { get; set; }
    }
}
