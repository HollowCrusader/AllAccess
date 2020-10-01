using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using AllAccess.Controls;
using AllAccess.ViewModels;

namespace AllAccess
{
    //This is the main page of this app
    public partial class MainPage : GradientPage
	{
        string[] imageUrls = { "AutoTravelBtn.png", "FoodDrinkBtn.png", "Fun.png", "HealthServicesBtn.png", "SHOP.png", "WeddingBtn.png" };
        LocationViewModel lw = new LocationViewModel();

        public MainPage()
        {

            InitializeComponent();
          // CallingInputBox();
            //accessButton.Clicked += AccessButton_Clicked;

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            //Registers each buttons to its own click method
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            firstImage.GestureRecognizers.Add(tapGestureRecognizer);
            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += AccessButton_Clicked;
            secondImage.GestureRecognizers.Add(tapGestureRecognizer2);
            var tapGestureRecognizer4 = new TapGestureRecognizer();
            tapGestureRecognizer4.Tapped += OnScan;
            scan.GestureRecognizers.Add(tapGestureRecognizer4);

            //facebook
            var fbGesture = new TapGestureRecognizer();
            fbGesture.Tapped += OnFacebook;
            facebookButton.GestureRecognizers.Add(fbGesture);

            var tapGestureRecognizer3 = new TapGestureRecognizer();
            tapGestureRecognizer3.Tapped += Ontapped;
            location.GestureRecognizers.Add(tapGestureRecognizer3);

            var tapGestureRecognizer5 = new TapGestureRecognizer();
            tapGestureRecognizer5.Tapped += OnScan;
            logo.GestureRecognizers.Add(tapGestureRecognizer5);

            var tapGestureRecognizer6 = new TapGestureRecognizer();
            tapGestureRecognizer6.Tapped += OnFavorite;
            favorite.GestureRecognizers.Add(tapGestureRecognizer6);

            //twitter
            var twitterGesture = new TapGestureRecognizer();
            twitterGesture.Tapped += OnTwitter;
            twitterButton.GestureRecognizers.Add(twitterGesture);

            //review
            var reviewGesture = new TapGestureRecognizer();
            reviewGesture.Tapped += OnReview;
            reviewButton.GestureRecognizers.Add(reviewGesture);

            //This rotates the green circle of the scan icon
            MainThread.BeginInvokeOnMainThread(async () => RotateImageContinously());

        }

        async Task RotateImageContinously()
        {
            while (true) 
            {
                for (int i = 1; i < 7; i++)
                {
                    if (scan.Rotation >= 360f) scan.Rotation = 0;

                    await scan.RotateTo(i * (360 / 6), 3500, Easing.Linear);
                 
                }
            }
        }

        async Task ChangeImage()
        {
          while(true)
            {
                for (int i = 0; i < imageUrls.Length; i++)
                {
                    if(i == 6)
                    {
                        firstImage.Source = imageUrls[i];
                        i = 0;
                    }
                    firstImage.Source = imageUrls[i];
                }
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            LocationViewModel.OnSpeech("Entering the Category");
            await Navigation.PushAsync(new AccessByCategoryPage());
        }

        //This method leads to access by name page after clicking on that button
        private async void AccessButton_Clicked(object sender, EventArgs e)
        {

            LocationViewModel.OnSpeech("Entering the Access by name");
           await Navigation.PushAsync(new AccessByNamePage());
        }

        private void Ontapped(object sender, EventArgs e)
        {
            LocationViewModel.OnSpeech("Entering the settings");
            Navigation.PushAsync(new SettingPage());
        }

        private async void OnScan(object sender, EventArgs e)
        {
            LocationViewModel.OnSpeech("Entering the scan logo");
            await Navigation.PushAsync(new ScanLogoPage());
        }

        private async void OnFavorite(object sender, EventArgs e)
        {
            LocationViewModel.OnSpeech("Entering the Favorite");
            await Navigation.PushAsync(new FavoritesPage());
        }

        protected async void OnFacebook(object sender, EventArgs e)
        {
            await OpenBrowser("https://m.facebook.com/AllAccessMenus?refsrc=https%3A%2F%2Fm.facebook.com%2Flogin%2Fdevice-based%2Fpassword%2F&_rdr");
        }

        protected async void OnTwitter(object sender, EventArgs e)
        {
            await OpenBrowser("https://mobile.twitter.com/AllAccessMenus");
        }

        protected void OnReview(object sender, EventArgs e)
        {
            if (Device.OS == TargetPlatform.Android)
            {
                Uri uri = new Uri(("https://play.google.com/store/apps/details?id=com.allaccessmenus&hl=en"));
                Device.OpenUri(uri);
            }
            else if (Device.OS == TargetPlatform.iOS)
            {
                Uri uri = new Uri(("https://itunes.apple.com/us/app/all-access-scan-logos-photos-qr-codes-to-access-menus/id633106012?mt=8"));
                Device.OpenUri(uri);
            }
        }

        private async Task OpenBrowser(string uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        //public static Task<string> InputBox(INavigation navigation)
        //{
        //    // wait in this proc, until user did his input 
        //    var tcs = new TaskCompletionSource<string>();

        //    var lblTitle = new Label { Text = "Title", HorizontalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold };
        //    var lblMessage = new Label { Text = "Enter new text:" };
        //    var txtInput = new Xamarin.Forms.Entry { Text = "" };

        //    var btnOk = new Button
        //    {
        //        Text = "Ok",
        //        WidthRequest = 100,
        //        BackgroundColor = Color.FromRgb(0.8, 0.8, 0.8),
        //    };
        //    btnOk.Clicked += async (s, e) =>
        //    {
        //        // close page
        //        var result = txtInput.Text;
        //        await navigation.PopModalAsync();
        //        // pass result
        //        tcs.SetResult(result);
        //    };

        //    var btnCancel = new Button
        //    {
        //        Text = "Cancel",
        //        WidthRequest = 100,
        //        BackgroundColor = Color.FromRgb(0.8, 0.8, 0.8)
        //    };
        //    btnCancel.Clicked += async (s, e) =>
        //    {
        //        // close page
        //        await navigation.PopModalAsync();
        //        // pass empty result
        //        tcs.SetResult(null);
        //    };

        //    var slButtons = new StackLayout
        //    {
        //        Orientation = StackOrientation.Horizontal,
        //        Children = { btnOk, btnCancel },
        //    };

        //    var layout = new StackLayout
        //    {
        //        Padding = new Thickness(0, 40, 0, 0),
        //        VerticalOptions = LayoutOptions.StartAndExpand,
        //        HorizontalOptions = LayoutOptions.CenterAndExpand,
        //        Orientation = StackOrientation.Vertical,
        //        Children = { lblTitle, lblMessage, txtInput, slButtons },
        //    };

        //    // create and show page
        //    var page = new ContentPage();
        //    page.Content = layout;
        //    navigation.PushModalAsync(page);
        //    // open keyboard
        //    txtInput.Focus();

        //    // code is waiting her, until result is passed with tcs.SetResult() in btn-Clicked
        //    // then proc returns the result
        //    return tcs.Task;
        //}

        //public async Task<String> CallingInputBox()
        //{
        //    string input = await InputBox(this.Navigation);
        //    return input;
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ICommand cm = lw.GetLocationCommand;

            

            cm.Execute(lw.ExecuteGetLocationCommand());
        }
    }
}
