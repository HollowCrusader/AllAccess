using System;
using System.Diagnostics;
using Xamarin.Forms;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Essentials;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using MvvmHelpers;
using System.Linq;
using System.Windows.Input;

namespace AllAccess.ViewModels
{
    //This class holds all of the information about your current location
    public class LocationViewModel:BaseViewModel
    {

        bool useGPS = true;
        public bool UseGPS
        {
            get { return useGPS; }
            set
            {

                SetProperty(ref useGPS, value);
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
            set {streetAddress = value; }
        }

        static bool onOrOff = false;

        public static bool OnOrOff
        {
            get { return OnOrOff; }
            set { onOrOff = value; }
        }

        static string lats = "";

        public static string Lats
        {
            get { return lats; }

            set { lats = value; }
        }



        static string display = String.Empty;

        public string Display
        {
            get { return display; }
            set { display = value; }
        }

        static string lons = String.Empty;

        public static string Lons
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


        static double radius = 6*1609.344;

        public static double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        static int counter = 6;

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        string address = String.Empty;

        public string Addresses
        {
            get { return address; }

            set { SetProperty(ref address, value); }
        }

        public async static void OnSpeech(string input)
        {
            //if(OnOrOff == true)
            //{
               await TextToSpeech.SpeakAsync(input);
            //}
        }

        ICommand getLocation;
        public ICommand GetLocationCommand => getLocation ?? (getLocation = new Command(async () => await ExecuteGetLocationCommand()));
        //public ICommand GetSearchCommand2 => getSearch ?? (getSearch = new Command(async () => await ExecuteGetSearchCommand(MySearchText)));

       //This method uses the GPS and gets the current location
        public async Task ExecuteGetLocationCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            //Display = "Loading Address from GPS";
            try
            {
                if (UseGPS)
                {
                    //var hasPermission = await CheckPermissions();
                    //if (!hasPermission)
                        //return;


                    var request = new GeolocationRequest(GeolocationAccuracy.Best);
                    var location = await Geolocation.GetLocationAsync(request);


                    //var geolocator = CrossGeolocator.Current;
                    //geolocator.DesiredAccuracy = 100;

                    //var gps = await geolocator.GetPositionAsync();

                    //Lats = gps.Latitude;

                    //Lons = gps.Longitude;

                    var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);

                    var placemark = placemarks?.FirstOrDefault();

                    if(placemark != null)
                    {
                        var geoAddress =
                            $"AdminArea:       {placemark.AdminArea}\n" +
                            $"CountryCode:     {placemark.CountryCode}\n" +
                            $"CountryName:     {placemark.CountryName}\n" +
                            $"FeatureName:     {placemark.FeatureName}\n" +
                            $"Locality:        {placemark.Locality}\n" +
                            $"PostalCode:      {placemark.PostalCode}\n" +
                            $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                            $"SubLocality:     {placemark.SubLocality}\n" +
                            $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                            $"Thoroughfare:    {placemark.Thoroughfare}\n";

                        if(Device.RuntimePlatform == Device.iOS)
                        {
                            StreetAddress = placemark.FeatureName;
                        }
                        else
                        {
                            StreetAddress = $"{placemark.FeatureName} {placemark.Thoroughfare}";
                        }

                        City = placemark.Locality;
                        ZipCode = placemark.PostalCode;
                        State = placemark.AdminArea;


                        Debug.WriteLine($"Here the address:\n{StreetAddress}\n{City}\n{ZipCode}\n{State}\n{location.Latitude}\n");

                        Display = $"{StreetAddress}\n{City}\n{ZipCode}\n{State}";

                        Debug.WriteLine("GEOADDRESS!!!: " + geoAddress);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("WHAT WRONG??  " + e);

                    Addresses = "check your wifi or data";
            }
            finally
            {
                IsBusy = false;

                Debug.WriteLine(IsBusy);
                //await Application.Current.MainPage.Navigation.PushAsync(new BusinessListPage());
            }
        }

        //This method checks for if accessing the phone's location has permission
        async Task<bool> CheckPermissions()
        {
            var permissionStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);

            bool request = false;

            if (permissionStatus == PermissionStatus.Denied)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    var title = "Location Permission";
                    var question = "To get your city the location permission is required. Please go into Settings and turn on Location for the app.";
                    var positive = "Settings";
                    var negative = "Maybe later";
                    var task = Application.Current?.MainPage?.DisplayAlert(title, question, positive, negative);
                    if (task == null)
                        return false;

                    var result = await task;
                    if (result)
                    {
                        CrossPermissions.Current.OpenAppSettings();
                    }

                    return false;
                }

                request = true;
            }

            if (request || permissionStatus != PermissionStatus.Granted)
            {
                var newStatus = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                if (newStatus.ContainsKey(Permission.Location) && newStatus[Permission.Location] != PermissionStatus.Granted)
                {
                    var title = "Location Permission";
                    var question = "To get your city the location permission is required. Please go into Settings and turn on Location for the app.";
                    var positive = "Settings";
                    var negative = "Maybe later";
                    var task = Application.Current?.MainPage?.DisplayAlert(title, question, positive, negative);
                    if (task == null)
                        return false;

                    var result = await task;
                    if (result)
                    {
                        CrossPermissions.Current.OpenAppSettings();
                    }

                    return false;
                }
            }
            return true;
        }
    }
}
