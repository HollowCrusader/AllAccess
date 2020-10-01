using System;
using AllAccess.Models;
using System.IO;
using System.Threading.Tasks;
using Foursquare.Response;
using Foursquare.Api;
using System.Diagnostics;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using static Newtonsoft.Json.JsonConvert;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using AllAccess.ViewModels;


namespace AllAccess.Services
{

    public class SearchService
    {
        #region Api Key
        private string clientId = "NVKK3FAJSJT4TS4KOLUKFUDM5QRQX2FQ2KSWL31K4YFVIDR2";
        private string clientSecret = "P5OHVFSDL3LDKUUERCQBCYQ1WWYF5BMWZIEE4F4CEJ3R5WXM";
        #endregion  

        // URL with no address or zipcode
        string SearchCoordinateUri = "https://api.foursquare.com/v2/venues/search?query={0}&intent=checkin&ll={1},{2}&radius=8046.72&client_id={3}&client_secret={4}&v=20180919";
        string DetailPageUri = "https://api.foursquare.com/v2/venues/{0}?&client_id={1}&client_secret={2}&v=20180919";

        //https://api.foursquare.com/v2/venues/4c7a9dd8794e224b30136928?&client_id=NVKK3FAJSJT4TS4KOLUKFUDM5QRQX2FQ2KSWL31K4YFVIDR2&client_secret=P5OHVFSDL3LDKUUERCQBCYQ1WWYF5BMWZIEE4F4CEJ3R5WXM&v=20180919

        string street = "504 - 506 Mount Hope Avenue";

        // URL with the full address in it
        //string SearchCoordinateUriWithZIPCODE = "https://api.foursquare.com/v2/venues/search?query={0}&limit=10&intent=checkin&ll={1},{2}&zip={3}&addess={4}&city={5}&state={6}&radius=8046.72&client_id={7}&client_secret={8}&v=20180919";

        string SearchCoordinateUriWithZIPCODE = "https://api.foursquare.com/v2/venues/search?query={0}&intent=checkin&ll={1},{2}&zip={3}&addess={4}&city={5}&state={6}&radius={7}&client_id={8}&client_secret={9}&v=20180919";

        public async Task<JObject> GetVenue(string query, double lats, double longs, double radius)
        {

            using (var client = new HttpClient())
            {
                var url = string.Format(SearchCoordinateUriWithZIPCODE, query, lats, longs, LocationViewModel.ZipCode, LocationViewModel.StreetAddress, LocationViewModel.City, LocationViewModel.State, radius, clientId, clientSecret);

                var response = await client.GetAsync(url);

                var json = await response.Content.ReadAsStringAsync();

             

                return JObject.Parse(json);
            }
        }

        public async Task<Empty> GetDetail(string id)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(DetailPageUri, id, clientId, clientSecret);
                var json = await client.GetStringAsync(url);

                //var response = await client.GetAsync(url);

                //var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                Debug.WriteLine("TESTING!!!!!!!" + json);

                return DeserializeObject<Empty>(json);

            }
                
        }

        public async Task<JObject> JGetDetail(string id)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(DetailPageUri, id, clientId, clientSecret);
                var json = await client.GetStringAsync(url);

                //var response = await client.GetAsync(url);

                //var json = await response.Content.ReadAsStringAsync();

                //if (string.IsNullOrWhiteSpace(json))
                //    return null;

                Debug.WriteLine("TESTING!!!!!!!" + json);

                return JObject.Parse(json);

            }

        }

    }
}
