using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AllAccess.Controls;
using Acr.UserDialogs;
using AllAccess.ViewModels;

namespace AllAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //This is the settings page which sets up the radius and detects your current location
    
    public partial class SettingPage : GradientPage
	{
        public int numOfMiles = LocationViewModel.Counter;
        LocationViewModel lm = new LocationViewModel();
		public SettingPage ()
		{
			InitializeComponent ();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            //Registers the buttons to its own click method
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            back.GestureRecognizers.Add(tapGestureRecognizer);

            var tapGestureGPS = new TapGestureRecognizer();
            tapGestureGPS.Tapped += GPSTapped;
            gps.GestureRecognizers.Add(tapGestureGPS);

            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += AccessButton_Clicked;
            help.GestureRecognizers.Add(tapGestureRecognizer2);

            var tp = new TapGestureRecognizer();
            tp.Tapped += BigButton_Clicked;
            biggerRadius.GestureRecognizers.Add(tp);

            var tp2 = new TapGestureRecognizer();
            tp2.Tapped += SmallButton_Clicked;
            smallRadius.GestureRecognizers.Add(tp2);

            var tp3 = new TapGestureRecognizer();
            tp3.Tapped += Address_Click;
            address.GestureRecognizers.Add(tp3);

            var helpGesture = new TapGestureRecognizer();
            helpGesture.Tapped += HelpGesture_Tapped;
            help.GestureRecognizers.Add(helpGesture);
            //TalkingOff.Clicked += OnTalkingOff;

            //TalkingOn.Clicked += OnTalkingOn;

		}

        private void HelpGesture_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("ALL ACCESS HELP", "Access menus and more form greate businesses in your area.\n\nWith our resturant partners, you can place order" +
                "s by showing your order page to the waitstaff and touching the 'Speak' button.\n\nAsk your favorite businesses to add their info to this app\nYou can also request" +
                "that a business be added (or updated) by contacting us at info@AllAccessMenus.com.  Thanks!", "Continue");
        }

        private void Address_Click(object sender, EventArgs e)
        {
            //var results = await UserDialogs.Instance.PromptAsync(new PromptConfig().SetTitle("Enter your zip code").SetPlaceholder("Enter zip code").SetInputMode(InputType.Number).SetMaxLength(5));

            //if (results.Text == null || results.Text == "" || !results.Text.Contains(" "))
            //{
            //    radiusLabel.Text = "Search " + numOfMiles + " miles around " + results.Text;
            //    SearchViewModel.Zipcode = results.Text;
            //}
            
            //radiusLabel.Text = "Search " + numOfMiles + " miles around " + SearchViewModel.Zipcode;
        }

        //This method detects your current location
        private void GPSTapped(object sender, EventArgs e)
        {
            radiusLabel.Text = "";
            ICommand cm = lm.GetLocationCommand;
            radiusLabel.Text = "Search " +numOfMiles+" miles around "+ lm.Display;
           

            cm.Execute(lm.ExecuteGetLocationCommand());
        }

        //This method decreases the radius distance
        private void SmallButton_Clicked(object sender, EventArgs e)
        {
            numOfMiles = numOfMiles - 2;
            LocationViewModel.Counter = numOfMiles;
            LocationViewModel.Radius = numOfMiles * 1609.344;
            radiusLabel.Text = "";
            radiusLabel.Text = "Search " + numOfMiles + " miles around "+ lm.Display;
        }


        //This method increases the radius distance
        private void BigButton_Clicked(object sender, EventArgs e)
        {
            numOfMiles = numOfMiles + 2;
            LocationViewModel.Counter = numOfMiles;
            LocationViewModel.Radius = numOfMiles * 1609.344;
            radiusLabel.Text = "";
            radiusLabel.Text = "Search " + numOfMiles + " miles around "+ lm.Display;
        }

        private void AccessButton_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new BusinessListPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        //Disables the voice speaking
        private void OnTalkingOff(object sender, EventArgs e)
        {
            LocationViewModel.OnOrOff = false;
        }

        //Enables the voice speaking
        private void OnTalkingOn(object sender, EventArgs e)
        {
            LocationViewModel.OnOrOff = true;
        }

    }
}