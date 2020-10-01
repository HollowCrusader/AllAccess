using System;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AllAccess.Controls;

namespace AllAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //This is the access by category page that lists out all of the categories

    public partial class AccessByCategoryPage : GradientPage
	{
		public AccessByCategoryPage ()
		{
			InitializeComponent ();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            //Registers each button to its own click method that does the search command depending on which buttons you pressed
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            back.GestureRecognizers.Add(tapGestureRecognizer);

            var tGR = new TapGestureRecognizer();
            tGR.Tapped += TGR_Tapped;
            autoTravelBtn.GestureRecognizers.Add(tGR);

            var tGR2 = new TapGestureRecognizer();
            tGR2.Tapped += TGR2_Tapped;
            foodBtn.GestureRecognizers.Add(tGR2);

            var tGR3 = new TapGestureRecognizer();
            tGR3.Tapped += TGR3_Tapped;
            funBtn.GestureRecognizers.Add(tGR3);

            var tGR4 = new TapGestureRecognizer();
            tGR4.Tapped += TGR4_Tapped;
            healthBtn.GestureRecognizers.Add(tGR4);

            var tGR5 = new TapGestureRecognizer();
            tGR5.Tapped += TGR5_Tapped;
            wedding.GestureRecognizers.Add(tGR5);

            var tGR6 = new TapGestureRecognizer();
            tGR6.Tapped += TGR6_Tapped;
            shopping.GestureRecognizers.Add(tGR6);

            var fbGesture = new TapGestureRecognizer();
            fbGesture.Tapped += OnFacebook;
            facebookButton.GestureRecognizers.Add(fbGesture);

            var twitterGesture = new TapGestureRecognizer();
            twitterGesture.Tapped += OnTwitter;
            twitterButton.GestureRecognizers.Add(twitterGesture);

            var helpGesture = new TapGestureRecognizer();
            helpGesture.Tapped += HelpGesture_Tapped;
        }

        private void HelpGesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }

        protected void OnFacebook(object sender, EventArgs e)
        {
            Uri uri = new Uri(("http://www.facebook.com/AllAccessMenus"));
            Device.OpenUri(uri);
        }

        protected void OnTwitter(object sender, EventArgs e)
        {
            Uri uri = new Uri(("http://www.twitter.com/AllAccessMenus"));
            Device.OpenUri(uri);
        }

        protected void OnReview(object sender, EventArgs e)
        {
            Uri uri = new Uri(("http://www.twitter.com/AllAccessMenus"));
            Device.OpenUri(uri);
        }


        //This is one of the click method.  This clicks to the auto and travel page
        private void TGR_Tapped(object sender, EventArgs e) // auto and travel
        {
            Navigation.PushAsync(new AutoandTravelPage());
        }

        private void TGR2_Tapped(object sender, EventArgs e) // food and drink
        {
            Navigation.PushAsync(new FoodandDrinkPage());
        }

        private void TGR3_Tapped(object sender, EventArgs e) // fun and nightlife
        {
            Navigation.PushAsync(new FunNightPage());
        }

        private void TGR4_Tapped(object sender, EventArgs e) // health and services
        {
            Navigation.PushAsync(new HealthServicePage());
        }

        private void TGR5_Tapped(object sender, EventArgs e) // wedding page
        {
            Navigation.PushAsync(new WeddingPage());
        }

        private void TGR6_Tapped(object sender, EventArgs e) // shopping
        {
            Navigation.PushAsync(new ShoppingPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}