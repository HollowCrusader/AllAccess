using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using AllAccess.ViewModels;


namespace AllAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //This page leads you to the web page of the business
    public partial class WebPage : ContentPage
    {
        string whichWeb;
        TapGestureRecognizer tap = new TapGestureRecognizer();
        public WebPage(string webType)
        {
            InitializeComponent();
            //this.BindingContext = BusinessListPage.dvm;

            if (webType == "Web")
            {
                web.Source = DetailViewModel.dvm.Web;
                whichWeb = DetailViewModel.dvm.Web;
            }
            else if (webType == "Four")
            {
                web.Source = DetailViewModel.dvm.FourSquare;
                whichWeb = DetailViewModel.dvm.FourSquare;
            }
            else if (webType == "Mobile")
            {
                web.Source = DetailViewModel.dvm.Menu;
                whichWeb = DetailViewModel.dvm.Menu;
            }
            else if(webType == "FaveWeb")
            {
                web.Source = FavoritesPage.faveData.Web;
            }
            else if(webType == "FaveFour")
            {
                web.Source = FavoritesPage.faveData.FourSquares;
            }
            else if(webType == "FaveMobile")
            {
                web.Source = FavoritesPage.faveData.Menu;
            }
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            tap.Tapped += TapGestureRecognizer_Tapped;

            var tapGestRec = new TapGestureRecognizer();

            tapGestRec.Tapped += OnBrowser;

            open.GestureRecognizers.Add(tapGestRec);


            //web.Source = "http://xamarin.com"; 
                //"www.tacobell.com";
            

            back.GestureRecognizers.Add(tap);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void OnBrowser(object sender, EventArgs e)
        {
           await OpenBrowser(whichWeb);
        }

        //This method opens up the browser
        private async Task OpenBrowser(string uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}
