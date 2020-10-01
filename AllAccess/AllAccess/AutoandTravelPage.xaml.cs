using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AllAccess.Controls;
using AllAccess.ViewModels;

namespace AllAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //This is the auto and travel page that lists all of the auto and travel businesses

    //Auto and Travel, Food and Drink, Wedding, Shopping, and Health Services pages all function the same way
    public partial class AutoandTravelPage : GradientPage
	{
        Binding binder = new Binding("MySearchText");
        SearchViewModel sm = new SearchViewModel();
        
        string query = "";
        //Registers each button to its own click method that does the search command
        #region TapRecognizersList
        TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer3 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer4 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer5 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer6 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer7 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer8 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer9 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer10 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer11 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer12 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer13 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer14= new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer15 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer16 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer17 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer18 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer19 = new TapGestureRecognizer();
        TapGestureRecognizer backGesture = new TapGestureRecognizer();
        TapGestureRecognizer helpGesture = new TapGestureRecognizer();

        #endregion

        public AutoandTravelPage ()
		{
			InitializeComponent ();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            binder.Source = sm;

            #region TapRecognizers
            //var tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "GetSearchCommand2");
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "GetSearchCommand2");
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            tapGestureRecognizer2.Tapped += TapGestureRecognizer_Tapped2;
            tapGestureRecognizer3.Tapped += TapGestureRecognizer_Tapped3;
            tapGestureRecognizer4.Tapped += TapGestureRecognizer_Tapped4;
            tapGestureRecognizer5.Tapped += TapGestureRecognizer_Tapped5;
            tapGestureRecognizer6.Tapped += TapGestureRecognizer_Tapped6;
            tapGestureRecognizer7.Tapped += TapGestureRecognizer_Tapped7;
            tapGestureRecognizer8.Tapped += TapGestureRecognizer_Tapped8;
            tapGestureRecognizer9.Tapped += TapGestureRecognizer_Tapped9;
            tapGestureRecognizer10.Tapped += TapGestureRecognizer_Tapped10;
            tapGestureRecognizer11.Tapped += TapGestureRecognizer_Tapped11;
            tapGestureRecognizer12.Tapped += TapGestureRecognizer_Tapped12;
            tapGestureRecognizer13.Tapped += TapGestureRecognizer_Tapped13;
            tapGestureRecognizer14.Tapped += TapGestureRecognizer_Tapped14;
            tapGestureRecognizer15.Tapped += TapGestureRecognizer_Tapped15;
            tapGestureRecognizer16.Tapped += TapGestureRecognizer_Tapped16;
            tapGestureRecognizer17.Tapped += TapGestureRecognizer_Tapped17;
            tapGestureRecognizer18.Tapped += TapGestureRecognizer_Tapped18;
            tapGestureRecognizer19.Tapped += TapGestureRecognizer_Tapped19;
            backGesture.Tapped += OnBack;
            helpGesture.Tapped += HelpGesture_Tapped;


            autoShopBtn.GestureRecognizers.Add(tapGestureRecognizer);
            bedBreakBtn.GestureRecognizers.Add(tapGestureRecognizer2); // USE BUTTONS
            bikingBtn.GestureRecognizers.Add(tapGestureRecognizer3);
            boatingBtn.GestureRecognizers.Add(tapGestureRecognizer4);
            busBtn.GestureRecognizers.Add(tapGestureRecognizer5);
            back.GestureRecognizers.Add(backGesture);
            campBtn.GestureRecognizers.Add(tapGestureRecognizer6);
            carDealerBtn.GestureRecognizers.Add(tapGestureRecognizer7);
            carRentalBtn.GestureRecognizers.Add(tapGestureRecognizer8);
            carWashBtn.GestureRecognizers.Add(tapGestureRecognizer9);
            gasBtn.GestureRecognizers.Add(tapGestureRecognizer10);
            hotelBtn.GestureRecognizers.Add(tapGestureRecognizer11);
            lockBtn.GestureRecognizers.Add(tapGestureRecognizer12);
            motorcycleBtn.GestureRecognizers.Add(tapGestureRecognizer13);
            parkingBtn.GestureRecognizers.Add(tapGestureRecognizer14);
            realEstateBtn.GestureRecognizers.Add(tapGestureRecognizer15);
            subwayBtn.GestureRecognizers.Add(tapGestureRecognizer16);
            taxiBtn.GestureRecognizers.Add(tapGestureRecognizer17);
            trainBtn.GestureRecognizers.Add(tapGestureRecognizer18);
            travelBtn.GestureRecognizers.Add(tapGestureRecognizer19);
            help.GestureRecognizers.Add(helpGesture);
            #endregion
        }

        private void HelpGesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }






        #region TapMethods
        private void OnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        //This is the click method that does the search command using the name of the button
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) // Auto Shop
        {
            autoShopLabel.SetBinding(Label.TextProperty, binder); // USE LABELS
            autoShopLabel.Text = "Auto Shop";

            //This method does the search command with Auto Shop as an text
            await sm.ExecuteGetSearchCommand(autoShopLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(autoShopLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e) // Bed and Breakfast
        {
            //bedLabel.SetBinding(Label.TextProperty, binder);
            bedLabel.Text = "Bed and Breakfast";
            await sm.ExecuteGetSearchCommand(bedLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bedLabel.Text));
        }
        private async void TapGestureRecognizer_Tapped3(object sender, EventArgs e) // Biking
        {
            //bikingLabel.SetBinding(Label.TextProperty, binder);
            bikingLabel.Text = "Biking";
            await sm.ExecuteGetSearchCommand(bikingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bikingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped4(object sender, EventArgs e) // Boating
        {
            //boatingLabel.SetBinding(Label.TextProperty, binder);
            boatingLabel.Text = "Boating";
            await sm.ExecuteGetSearchCommand(boatingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(boatingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped5(object sender, EventArgs e) // Bus
        {
            //busLabel.SetBinding(Label.TextProperty, binder);
            busLabel.Text = "Bus";
            await sm.ExecuteGetSearchCommand(busLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(busLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped6(object sender, EventArgs e) // camp
        {
            //campLabel.SetBinding(Label.TextProperty, binder);
            campLabel.Text = "Campground";
            await sm.ExecuteGetSearchCommand(campLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(campLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped7(object sender, EventArgs e) // car dealer
        {
            //carDealerLabel.SetBinding(Label.TextProperty, binder);
            carDealerLabel.Text = "Car Dealer";
            await sm.ExecuteGetSearchCommand(carDealerLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(carDealerLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped8(object sender, EventArgs e) // car rental
        {
            //carRentalLabel.SetBinding(Label.TextProperty, binder);
            carRentalLabel.Text = "Car Rental";
            await sm.ExecuteGetSearchCommand(carRentalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(carRentalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped9(object sender, EventArgs e) // car wash
        {
            //carWashLabel.SetBinding(Label.TextProperty, binder);
            carWashLabel.Text = "Car Wash";
            await sm.ExecuteGetSearchCommand(carWashLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(carWashLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped10(object sender, EventArgs e) // gas
        {
            //gasLabel.SetBinding(Label.TextProperty, binder);
            gasLabel.Text = "Gas";
            await sm.ExecuteGetSearchCommand(gasLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(gasLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped11(object sender, EventArgs e) // hotel
        {
            //hotelLabel.SetBinding(Label.TextProperty, binder);
            hotelLabel.Text = "Hotel";
            await sm.ExecuteGetSearchCommand(hotelLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(hotelLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped12(object sender, EventArgs e) // locksmoth
        {
            //lockLabel.SetBinding(Label.TextProperty, binder);
            lockLabel.Text = "Locksmith";
            await sm.ExecuteGetSearchCommand(lockLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped13(object sender, EventArgs e) // motorcycle
        {
            //motorcycleLabel.SetBinding(Label.TextProperty, binder);
            motorcycleLabel.Text = "Motorcycle";
            await sm.ExecuteGetSearchCommand(motorcycleLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped14(object sender, EventArgs e) // parking
        {
            //parkingLabel.SetBinding(Label.TextProperty, binder);
            parkingLabel.Text = "Parking";
            await sm.ExecuteGetSearchCommand(parkingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped15(object sender, EventArgs e) // real estate
        {
            //realEstateLabel.SetBinding(Label.TextProperty, binder);
            realEstateLabel.Text = "Real Estate";
            await sm.ExecuteGetSearchCommand(realEstateLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped16(object sender, EventArgs e) // subway
        {
            //subwayLabel.SetBinding(Label.TextProperty, binder);
            subwayLabel.Text = "Subway";
            await sm.ExecuteGetSearchCommand(subwayLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped17(object sender, EventArgs e) // taxi
        {
            //taxiLabel.SetBinding(Label.TextProperty, binder);
            taxiLabel.Text = "Taxi and Limo";
            await sm.ExecuteGetSearchCommand(taxiLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped18(object sender, EventArgs e) // train
        {
            //trainLabel.SetBinding(Label.TextProperty, binder);
            trainLabel.Text = "Train";
            await sm.ExecuteGetSearchCommand(trainLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped19(object sender, EventArgs e) // travel agency
        {
            //travelLabel.SetBinding(Label.TextProperty, binder);
            travelLabel.Text = "Travel Agency";
            await sm.ExecuteGetSearchCommand(travelLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lockLabel.Text));
        }



        #endregion

    }
}