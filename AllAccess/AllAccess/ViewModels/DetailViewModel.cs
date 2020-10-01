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
using Xamarin.Essentials;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.Geolocator.Abstractions;
using AllAccess.Data;


namespace AllAccess.ViewModels
{
    //This class holds all of the detail information for one specific business
    //All of the information on here is being displayed in the details page

    public class DetailViewModel:BaseViewModel
    {
        Page page = new Page();
        public static JObject GetJ;
        //public static BusinessData business = new BusinessData();

        //Response GetR;
        public static DetailViewModel dvm;
        Services.SearchService sm = new SearchService();
        //public DetailViewModel(string getId)
        //{
        //    MyId = getId;
        //}

        public DetailViewModel()
        {

        }

        public BusinessData business = null;
        public BusinessData Business
        { 
            get { return business; }
            set
            {
                SetProperty(ref business, value);
            }
        }


        bool useGPS = true;
        public bool UseGPS
        {
            get { return useGPS; }
            set
            {

                SetProperty(ref useGPS, value);
            }
        }

        string web = String.Empty;

        public string Web
        {
            get { return web; }
            set
            {
                SetProperty(ref web, value);
            }
        }

        string fourSquare = String.Empty;

        public string FourSquare
        {
            get { return fourSquare; }
            set
            {
                SetProperty(ref fourSquare, value);
            }
        }

        string hours = String.Empty;

        public string Hours
        {
            get { return hours; }

            set
            {
                SetProperty(ref hours, value);
            }
        }

        string lats = String.Empty;

        public string Lats
        {
            get { return lats; }
            set
            {
                SetProperty(ref lats, value);
            }
        }

        string longs = String.Empty;

        public string Longs
        {
            get { return longs; }
            set
            {
                SetProperty(ref longs, value);
            }
        }

        string twitter = String.Empty;

        public string Twitter
        {
            get { return twitter; }

            set
            {
                SetProperty(ref twitter, value);
            }
        }

        string phone = String.Empty;

        public string Phone
        {
            get { return phone; }
            set
            {
                SetProperty(ref phone, value);
            }
        }

        string menu = String.Empty;

        public string Menu
        {
            get { return menu; }

            set
            {
                SetProperty(ref menu, value);
            }
        }

        string myId = String.Empty;
        public string MyId
        {
            get { return myId; }
            set
            {
                SetProperty(ref myId, value);
            }
        }

        string name = String.Empty;

        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
            }
        }

        static Empty response;

        public static Empty Response
        {
            get { return response; }
            set { response = value;}
        }

        ICommand getDetails;
        public ICommand GetDetailCommand => getDetails ?? (getDetails = new Command(async () => await ExecuteDetailsCommand(MyId)));

        public async Task ExecuteDetailsCommand(string id)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            Name = null;


            try
            {

                GetJ = await sm.JGetDetail(id);

                Name = (string)GetJ.SelectToken("response.venue.name");

                Web = (string)GetJ.SelectToken("response.venue.url");

                FourSquare = (string)GetJ.SelectToken("response.venue.canonicalUrl");
                Twitter = (string)GetJ.SelectToken("response.venue.contact.twitter");
                Lats = (string)GetJ.SelectToken("response.venue.location.lat");
                Longs = (string)GetJ.SelectToken("response.venue.location.lng");

                //string dayOne;
                //string dayTwo;
                //string dayThree;
                //string dayFour;
                //string timeRendered;
                //string timeRenderedTwo;
                //string timeRenderedThree;

                //if((string)GetJ.SelectToken("response.venue.hours.timeframes[0].days") != "")
                //{
                //    dayOne = (string)GetJ.SelectToken("response.venue.hours.timeframes[0].days");
                //}
                //if((string)GetJ.SelectToken("response.venue.hours.timeframes[1].days") != "")
                //{
                //    dayTwo = (string)GetJ.SelectToken("response.venue.hours.timeframes[1].days");
                //}
                //if((string)GetJ.SelectToken("response.venue.hours.timeframes[0].open[0].renderedTime") != "")
                //{
                //    timeRendered = (string)GetJ.SelectToken("response.venue.hours.timeframes[0].open[0].renderedTime");
                //}
                //if((string)GetJ.SelectToken("response.venue.hours.timeframes[2].days") != "")
                //{
                //    dayThree = (string)GetJ.SelectToken("response.venue.hours.timeframes[2].days");
                //}
                //if((string)GetJ.SelectToken("response.venue.hours.timeframes[2].open[0].renderedTime") != "")
                //{
                //    timeRenderedTwo = (string)GetJ.SelectToken("response.venue.hours.timeframes[2].open[0].renderedTime");
                //}
                //if((string)GetJ.SelectToken("response.venue.hours.timeframes[3].days") != "")
                //{
                //    dayFour = (string)GetJ.SelectToken("response.venue.hours.timeframes[3].days");
                //}
                //if((string) GetJ.SelectToken("response.venue.hours.timeframes[3].open[0].renderedTime") != "")
                //{
                //    timeRenderedThree = (string)GetJ.SelectToken("response.venue.hours.timeframes[3].open[0].renderedTime");
                //}

                Hours = String.Format((string)GetJ.SelectToken("response.venue.hours.timeframes[0].days") + "-" + (string)GetJ.SelectToken("response.venue.hours.timeframes[1].days") + ": " + (string)GetJ.SelectToken("response.venue.hours.timeframes[0].open[0].renderedTime") + "\n" + (string)GetJ.SelectToken("response.venue.hours.timeframes[2].days") + ": " + (string)GetJ.SelectToken("response.venue.hours.timeframes[2].open[0].renderedTime") + "\n" + (string)GetJ.SelectToken("response.venue.hours.timeframes[3].days") + ": " + (string)GetJ.SelectToken("response.venue.hours.timeframes[3].open[0].renderedTime"));


                Menu = (string)GetJ.SelectToken("response.venue.menu.mobileUrl");

                Phone = (string)GetJ.SelectToken("response.venue.contact.formattedPhone");

                Business = new BusinessData(Name, Web, FourSquare, Twitter, Hours, Lats, Longs, Menu, Phone, id);


                Debug.WriteLine("Checking Hours" + Hours);

                Debug.WriteLine("CHECKING MOBILE WEB!!!!! " + Name);

                Debug.WriteLine("CHECKING FOURSQUARE!!!! " + FourSquare);

                Debug.WriteLine("CHECKING TWITTER!!!!! " + Twitter);

                Debug.WriteLine("GEtting the WEBBB!!!!" + Web);
                dvm = this;


            }
            catch(Exception e)
            {

            }
            finally
            {
                IsBusy = false;
                //await Application.Current.MainPage.Navigation.PushAsync(new BusinessListPage());
            }
        }
    }
}
