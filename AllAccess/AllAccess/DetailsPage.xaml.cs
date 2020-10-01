using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using AllAccess.Controls;
using System.Diagnostics;
using System.Threading.Tasks;
using AllAccess.ViewModels;
using AllAccess.Data;

namespace AllAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //This page holds all of the details of the business you selected from the listview
    public partial class DetailsPage : GradientPage
    {
        //public DetailsPage() { }
        public DetailsPage(String pages)
        {

            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            if (pages == "business")
            {
                pageTitle.Text = DetailViewModel.dvm.Name;

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
                back.GestureRecognizers.Add(tapGestureRecognizer);
                var tapGestureRecognizer3 = new TapGestureRecognizer();
                tapGestureRecognizer3.Tapped += TapWeb;
                web.GestureRecognizers.Add(tapGestureRecognizer3);
                var tapGestureRecognizer4 = new TapGestureRecognizer();
                tapGestureRecognizer4.Tapped += TapFour;
                four.GestureRecognizers.Add(tapGestureRecognizer4);

                var tapGestureRecognizer5 = new TapGestureRecognizer();
                tapGestureRecognizer5.Tapped += TapHours;
                hours.GestureRecognizers.Add(tapGestureRecognizer5);

                var tapGestureRecognizer6 = new TapGestureRecognizer();
                tapGestureRecognizer6.Tapped += TapMenu;
                menu.GestureRecognizers.Add(tapGestureRecognizer6);

                var tapGestureRecognizer7 = new TapGestureRecognizer();
                tapGestureRecognizer7.Tapped += TapPhone;
                phone.GestureRecognizers.Add(tapGestureRecognizer7);

                var tapGestureRecognizer8 = new TapGestureRecognizer();
                tapGestureRecognizer8.Tapped += TapFave;
                fave.GestureRecognizers.Add(tapGestureRecognizer8);
                var tapGestureRecognizer9 = new TapGestureRecognizer();
                tapGestureRecognizer9.Tapped += TapMap;
                map.GestureRecognizers.Add(tapGestureRecognizer9);


                if (ViewModels.DetailViewModel.dvm.Web == null)
                {
                    web.IsVisible = false;
                    webText.IsVisible = false;
                }
                if (ViewModels.DetailViewModel.dvm.FourSquare == null)
                {
                    four.IsVisible = false;
                    fourText.IsVisible = false;
                }
                if (ViewModels.DetailViewModel.dvm.Hours == null)
                {
                    hours.IsVisible = false;
                    hoursText.IsVisible = false;
                }
                if (ViewModels.DetailViewModel.dvm.Menu == null)
                {
                    menu.IsVisible = false;
                    menuText.IsVisible = false;
                }
                if(ViewModels.DetailViewModel.dvm.Phone == null)
                {
                    phone.IsVisible = false;
                    phoneText.IsVisible = false;
                }

            }
            else if (pages == "fave")
            {

                pageTitle.Text = FavoritesPage.faveData.BusinessName;
                fave.IsVisible = false;
                favor.IsVisible = false;

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
                back.GestureRecognizers.Add(tapGestureRecognizer);
                var tapGestureRecognizer3 = new TapGestureRecognizer();
                tapGestureRecognizer3.Tapped += FaveTapWeb;
                web.GestureRecognizers.Add(tapGestureRecognizer3);
                var tapGestureRecognizer4 = new TapGestureRecognizer();
                tapGestureRecognizer4.Tapped += FaveTapFour;
                four.GestureRecognizers.Add(tapGestureRecognizer4);

                var tapGestureRecognizer5 = new TapGestureRecognizer();
                tapGestureRecognizer5.Tapped += FaveTapHours;
                hours.GestureRecognizers.Add(tapGestureRecognizer5);

                var tapGestureRecognizer6 = new TapGestureRecognizer();
                tapGestureRecognizer6.Tapped += FaveTapMenu;
                menu.GestureRecognizers.Add(tapGestureRecognizer6);

                var tapGestureRecognizer7 = new TapGestureRecognizer();
                tapGestureRecognizer7.Tapped += FaveTapPhone;
                phone.GestureRecognizers.Add(tapGestureRecognizer7);

                var tapGestureRecognier8 = new TapGestureRecognizer();
                tapGestureRecognier8.Tapped += TapTwitter;
                twit.GestureRecognizers.Add(tapGestureRecognier8);
                var tapGestureRecognizer9 = new TapGestureRecognizer();
                tapGestureRecognizer9.Tapped += FaveMap;
                map.GestureRecognizers.Add(tapGestureRecognizer9);

                if (FavoritesPage.faveData.Web == null)
                {
                    web.IsVisible = false;
                    webText.IsVisible = false;
                }
                if (FavoritesPage.faveData.FourSquares == null)
                {
                    four.IsVisible = false;
                    fourText.IsVisible = false;
                }
                if (FavoritesPage.faveData.Hours == null)
                {
                    hours.IsVisible = false;
                    hoursText.IsVisible = false;
                }
                if (FavoritesPage.faveData.Menu == null)
                {
                    menu.IsVisible = false;
                    menuText.IsVisible = false;
                }
                if(FavoritesPage.faveData.Phone == null)
                {
                    phone.IsVisible = false;
                    phoneText.IsVisible = false;
                }
            }


        }



        private async void TapPhone(object sender, EventArgs e)
        {
            var call = await DisplayAlert("Phone Number: ", $"{DetailViewModel.dvm.Phone}", "Call", "Cancel");
            string phone = DetailViewModel.dvm.Phone;

            if(call == true)
            {
                await PlacePhoneCall(phone);
            }
        }

        private void TapWeb(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebPage("Web"));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void TapFour(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebPage("Four"));
        }

        private void TapTwitter(object sender, EventArgs e)
        {
            DisplayAlert("Twitter", $"{DetailViewModel.dvm.Twitter}", "Ok");
        }

        private async void TapMap(object sender, EventArgs e)
        {
            await NavigateToPlace(DetailViewModel.dvm.Lats, DetailViewModel.dvm.Longs);
        }


        private void TapHours(object sender, EventArgs e)
        {
            DisplayAlert("Hours", $"{DetailViewModel.dvm.Hours}", "Continue");
        }

        private void TapMenu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebPage("Mobile"));
        }

        private void TapFave(Object sender, EventArgs e)
        {
            FaveViewModel.FaveList.Add(DetailViewModel.dvm.Business);
            DisplayAlert("Favorite", $"{DetailViewModel.dvm.Name} have been added", "Ok");
        }


        private async void FaveTapPhone(object sender, EventArgs e)
        {
            var call = await DisplayAlert("Phone Number: ", $"{FavoritesPage.faveData.Phone}", "Call", "Cancel");
            string phone = FavoritesPage.faveData.Phone;

            if(call == true)
            {
                await PlacePhoneCall(phone);
            }

            //Debug.WriteLine("Checking the DISPLAY ALERT!!!! " + call);
        }

        private void FaveTapWeb(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebPage("FaveWeb"));
        }

        private void FaveTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void FaveTapFour(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebPage("FaveFour"));
        }

        private void FaveTapHours(object sender, EventArgs e)
        {
            DisplayAlert("Hours", $"{FavoritesPage.faveData.Hours}", "Continue");
        }

        private async void FaveMap(object sender, EventArgs e)
        {
            await NavigateToPlace(FavoritesPage.faveData.Lats, FavoritesPage.faveData.Longs);
        }

        private void FaveTapMenu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebPage("FaveMobile"));
        }

        public async Task PlacePhoneCall(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        public async Task NavigateToPlace(string lats, string longs)
        {
            var location = new Location(double.Parse(lats), double.Parse(longs));

            MapLaunchOptions options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            await Map.OpenAsync(location, options);
        }
    }
}
