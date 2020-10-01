using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AllAccess.Helper;
using AllAccess.Models;
using Newtonsoft.Json.Linq;
using MvvmHelpers;
using System.Diagnostics;
using Xamarin.Forms;
using AllAccess.Services;
using System.Windows.Input;
using Plugin.Geolocator;
using Xamarin.Essentials;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.Geolocator.Abstractions;

namespace AllAccess.ViewModels
{
    //This class holds all of the information about the search such as a list of businesses you searched for
    public class SearchViewModel : BaseViewModel
    {
       
        public static JObject sm;

        public static readonly ObservableCollection<String> sLV = new ObservableCollection<String>();

        public static readonly ObservableCollection<String> venueId = new ObservableCollection<String>();

        SearchService searchService = new SearchService();


        string location = String.Empty;

        public string Location
        {
            get { return location; }
            set
            {
                SetProperty(ref location, value);
                location = value;
            }
        }
        public static string Zipcode { get; set; } = "14620";

        bool useGPS = true;
        public bool UseGPS
        {
            get { return useGPS; }
            set
            {

                SetProperty(ref useGPS, value);
            }
        }

        public string mySearchText = String.Empty;

        public string MySearchText
        {
            get { return mySearchText; }

            set { SetProperty(ref mySearchText, value);
            }
        }

        string titleName = String.Empty;
        public string TitleName
        {
            get { return titleName; }

            set { SetProperty(ref titleName, value); }
        }

        string lats = String.Empty;

        public string Lats
        {
            get { return lats; }

            set { SetProperty(ref lats, value); }
        }

        string lons = String.Empty;

        public string Lons
        {
            get { return Lons; }

            set { SetProperty(ref lons, value); }
        }

        string address = String.Empty;

        public string Addresses
        {
            get { return address; }

            set { SetProperty(ref address, value); }
        }



        ICommand getSearch;
        public ICommand GetSearchCommand => getSearch ?? (getSearch = new Command(async () => await ExecuteGetSearchCommand()));
        public ICommand GetSearchCommand2 => getSearch ?? (getSearch = new Command(async () => await ExecuteGetSearchCommand("JustCause")));

        //This method executes the search command and sets up the list of businesses in the listview page
        //This method is for access by name
        public async Task ExecuteGetSearchCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {


                if (UseGPS)
                {
                    var location = await Geolocation.GetLastKnownLocationAsync();

                    //if(location == null)
                    //{

                    //}

                    //TitleName = MySearchText;

                    sm = await searchService.GetVenue(MySearchText, location.Latitude, location.Longitude, LocationViewModel.Radius);

                    sLV.Clear();
                    venueId.Clear();
               


                    foreach (JToken f in sm.SelectToken("response.venues"))
                    {
                        if ((string)f.SelectToken("location.address") != "" || (string)f.SelectToken("location.address") != " ")
                        {
                            Addresses = (string)f.SelectToken("name") + "\n" + (string)f.SelectToken("location.address") +"\n"+(string)f.SelectToken("location.city")+(string)f.SelectToken("location.state")+(string)f.SelectToken("location.zipcode");
                 
                            string apiId = (string)f.SelectToken("id");
                    

                            sLV.Add(Addresses);

                            venueId.Add(apiId);

                            Debug.WriteLine("CHEEESEEE!!!!" + f.SelectToken("location.distance"));

                            Debug.WriteLine(Addresses + "\n");

                            Debug.WriteLine("Show me the MOney!!!!!" + apiId);
                        }

                    }
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine("WHAT WRONG??  " + e);
                if(sLV.Count == 0)
                {
                    Addresses = "Something went wrong";
                }
                else
                {
                    Addresses = "check your wifi or data";
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

        //This method acts the same functionality as the method above but this is for access by category
        public async Task ExecuteGetSearchCommand(string query)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                if (UseGPS)
                {
                    var location = await Geolocation.GetLastKnownLocationAsync();


                    sm = await searchService.GetVenue(MySearchText, location.Latitude, location.Longitude, LocationViewModel.Radius);

                    sLV.Clear();
                    venueId.Clear();



                    foreach (JToken f in sm.SelectToken("response.venues"))
                    {
                        if ((string)f.SelectToken("location.address") != "" || (string)f.SelectToken("location.address") != " ")
                        {
                            Addresses = (string)f.SelectToken("name") + "\n" + (string)f.SelectToken("location.address") + "\n" + (string)f.SelectToken("location.city") + (string)f.SelectToken("location.state") + (string)f.SelectToken("location.zipcode");

                            string apiId = (string)f.SelectToken("id");


                            sLV.Add(Addresses);

                            venueId.Add(apiId);

                            Debug.WriteLine("CHEEESEEE!!!!" + f.SelectToken("location.distance"));

                            Debug.WriteLine(Addresses + "\n");

                            Debug.WriteLine("Show me the MOney!!!!!" + apiId);
                        }

                    }
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("WHAT WRONG??  " + e);
                if (sLV.Count == 0)
                {
                    Addresses = "Something went wrong";
                }
                else
                {
                    Addresses = "check your wifi or data";
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
