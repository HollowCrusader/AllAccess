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
    public partial class HealthServicePage : GradientPage
	{
        Binding binder = new Binding("MySearchText");
        SearchViewModel sm = new SearchViewModel();

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
        TapGestureRecognizer tapGestureRecognizer14 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer15 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer16 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer17 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer18 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer19 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer20 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer21 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer22 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer23 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer24 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer25 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer26 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer27 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer28 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer29 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer30 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer31 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer32 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer33 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer34 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer35 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer36 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer37 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer38 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer39 = new TapGestureRecognizer();
        TapGestureRecognizer tapGestureRecognizer40 = new TapGestureRecognizer();
        TapGestureRecognizer tap = new TapGestureRecognizer();
        TapGestureRecognizer helpGesture = new TapGestureRecognizer();
        #endregion
        public HealthServicePage ()
		{
			InitializeComponent ();


            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
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
            tapGestureRecognizer20.Tapped += TapGestureRecognizer_Tapped20;
            tapGestureRecognizer21.Tapped += TapGestureRecognizer_Tapped21;
            tapGestureRecognizer22.Tapped += TapGestureRecognizer_Tapped22;
            tapGestureRecognizer23.Tapped += TapGestureRecognizer_Tapped23;
            tapGestureRecognizer24.Tapped += TapGestureRecognizer_Tapped24;
            tapGestureRecognizer25.Tapped += TapGestureRecognizer_Tapped25;
            tapGestureRecognizer26.Tapped += TapGestureRecognizer_Tapped26;
            tapGestureRecognizer27.Tapped += TapGestureRecognizer_Tapped27;
            tapGestureRecognizer28.Tapped += TapGestureRecognizer_Tapped28;
            tapGestureRecognizer29.Tapped += TapGestureRecognizer_Tapped29;
            tapGestureRecognizer30.Tapped += TapGestureRecognizer_Tapped30;
            tap.Tapped += OnBack;
            helpGesture.Tapped += HelpGesture_Tapped;

            atmBtn.GestureRecognizers.Add(tapGestureRecognizer);
            cateringBtn.GestureRecognizers.Add(tapGestureRecognizer2);
            collegeBtn.GestureRecognizers.Add(tapGestureRecognizer3);
            cosmeticsBtn.GestureRecognizers.Add(tapGestureRecognizer4);
            dentalBtn.GestureRecognizers.Add(tapGestureRecognizer5);
            doctorBtn.GestureRecognizers.Add(tapGestureRecognizer6);
            dryCleanerBtn.GestureRecognizers.Add(tapGestureRecognizer7);
            eventBtn.GestureRecognizers.Add(tapGestureRecognizer8);
            fitnessBtn.GestureRecognizers.Add(tapGestureRecognizer9);
            heatBtn.GestureRecognizers.Add(tapGestureRecognizer10);
            homeBtn.GestureRecognizers.Add(tapGestureRecognizer11);
            hospitalBtn.GestureRecognizers.Add(tapGestureRecognizer12);
            kBtn.GestureRecognizers.Add(tapGestureRecognizer13);
            legalBtn.GestureRecognizers.Add(tapGestureRecognizer14);
            locksmithBtn.GestureRecognizers.Add(tapGestureRecognizer15);
            medicalBtn.GestureRecognizers.Add(tapGestureRecognizer16);
            opticalBtn.GestureRecognizers.Add(tapGestureRecognizer17);
            photoBtn.GestureRecognizers.Add(tapGestureRecognizer18);
            petsBtn.GestureRecognizers.Add(tapGestureRecognizer19);
            plumbingBtn.GestureRecognizers.Add(tapGestureRecognizer20);
            pharmacyBtn.GestureRecognizers.Add(tapGestureRecognizer21);
            printShopBtn.GestureRecognizers.Add(tapGestureRecognizer22);
            realEstateBtn.GestureRecognizers.Add(tapGestureRecognizer23);
            salonBtn.GestureRecognizers.Add(tapGestureRecognizer24);
            spaBtn.GestureRecognizers.Add(tapGestureRecognizer25);
            spiritBtn.GestureRecognizers.Add(tapGestureRecognizer26);
            tailorBtn.GestureRecognizers.Add(tapGestureRecognizer27);
            tanningBtn.GestureRecognizers.Add(tapGestureRecognizer28);
            tattoBtn.GestureRecognizers.Add(tapGestureRecognizer29);
            tutorBtn.GestureRecognizers.Add(tapGestureRecognizer30);
            back.GestureRecognizers.Add(tap);
            help.GestureRecognizers.Add(helpGesture);



            #endregion
        }

        private void HelpGesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }

        #region TapMethods
        private async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) // Atm and Banking
        {
            await sm.ExecuteGetSearchCommand(atmLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(atmLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e) // Catering
        {
            await sm.ExecuteGetSearchCommand(cateringLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cateringLabel.Text));
        }
        private async void TapGestureRecognizer_Tapped3(object sender, EventArgs e) // COllege
        {
            await sm.ExecuteGetSearchCommand(collegeLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(collegeLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped4(object sender, EventArgs e) // Cosmetics
        {
            await sm.ExecuteGetSearchCommand(cosmeticsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cosmeticsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped5(object sender, EventArgs e) // Dental
        {
            await sm.ExecuteGetSearchCommand(dentalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(dentalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped6(object sender, EventArgs e) // Doctor
        {
            await sm.ExecuteGetSearchCommand(doctorLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(doctorLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped7(object sender, EventArgs e) // Dry Cleaners
        {
            await sm.ExecuteGetSearchCommand(dryCleaningLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(dryCleaningLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped8(object sender, EventArgs e) // Event Space
        {
            await sm.ExecuteGetSearchCommand(eventLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(eventLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped9(object sender, EventArgs e) // Fitness
        {
            fitnessLabel.SetBinding(Label.TextProperty, binder);
            fitnessLabel.Text = "Fitness";
            await sm.ExecuteGetSearchCommand("Fitness");
            await Navigation.PushAsync(new BusinessListPage(fitnessLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped10(object sender, EventArgs e) // Heating and AC
        {
            heatLabel.SetBinding(Label.TextProperty, binder);
            heatLabel.Text = "Heating and AC";
            await sm.ExecuteGetSearchCommand("Heating and AC");
            await Navigation.PushAsync(new BusinessListPage(heatLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped11(object sender, EventArgs e) // Home Services
        {
            homeLabel.SetBinding(Label.TextProperty, binder);
            homeLabel.Text = "Home Services";
            await sm.ExecuteGetSearchCommand("Home Services");
            await Navigation.PushAsync(new BusinessListPage(homeLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped12(object sender, EventArgs e) // Hospital
        {
            hospitalLabel.SetBinding(Label.TextProperty, binder);
            hospitalLabel.Text = "Hospital";
            await sm.ExecuteGetSearchCommand("Hospital");
            await Navigation.PushAsync(new BusinessListPage(hospitalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped13(object sender, EventArgs e) // K-12
        {
            kLabel.SetBinding(Label.TextProperty, binder);
            kLabel.Text = "K - 12";
            await sm.ExecuteGetSearchCommand("K - 12");
            await Navigation.PushAsync(new BusinessListPage(kLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped14(object sender, EventArgs e) // Legal and Financial
        {
            legalLabel.SetBinding(Label.TextProperty, binder);
            legalLabel.Text = "Legal and Financial";
            await sm.ExecuteGetSearchCommand("Legal and Financial");
            await Navigation.PushAsync(new BusinessListPage(legalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped15(object sender, EventArgs e) // Locksmith
        {
            locksmithLabel.SetBinding(Label.TextProperty, binder);
            locksmithLabel.Text = "Locksmith";
            await sm.ExecuteGetSearchCommand("Locksmith");
            await Navigation.PushAsync(new BusinessListPage(locksmithLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped16(object sender, EventArgs e) // Medical Supply and Center
        {
            medicalLabel.SetBinding(Label.TextProperty, binder);
            medicalLabel.Text = "Medical Supply and Center";
            await sm.ExecuteGetSearchCommand("Medical Supply and Center");
            await Navigation.PushAsync(new BusinessListPage(medicalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped17(object sender, EventArgs e) // Optical
        {
            opticalLabel.SetBinding(Label.TextProperty, binder);
            opticalLabel.Text = "Optical";
            await sm.ExecuteGetSearchCommand("Optical");
            await Navigation.PushAsync(new BusinessListPage(opticalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped18(object sender, EventArgs e) // Photo
        {
            photoLabel.SetBinding(Label.TextProperty, binder);
            photoLabel.Text = "Photo";
            await sm.ExecuteGetSearchCommand("Photo");
            await Navigation.PushAsync(new BusinessListPage(photoLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped19(object sender, EventArgs e) // Pets
        {
            petsLabel.SetBinding(Label.TextProperty, binder);
            petsLabel.Text = "Pets";
            await sm.ExecuteGetSearchCommand("Pets");
            await Navigation.PushAsync(new BusinessListPage(petsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped20(object sender, EventArgs e) // Plumbing
        {
            plumbingLabel.SetBinding(Label.TextProperty, binder);
            plumbingLabel.Text = "Plumbing";
            await sm.ExecuteGetSearchCommand("Plumbing");
            await Navigation.PushAsync(new BusinessListPage(plumbingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped21(object sender, EventArgs e) // Pharmacy
        {
            pharmacyLabel.SetBinding(Label.TextProperty, binder);
            pharmacyLabel.Text = "Pharmacy";
            await sm.ExecuteGetSearchCommand("Pharmacy");
            await Navigation.PushAsync(new BusinessListPage(pharmacyLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped22(object sender, EventArgs e) // Print Shop
        {
            printShopLabel.SetBinding(Label.TextProperty, binder);
            printShopLabel.Text = "Print Shop";
            await sm.ExecuteGetSearchCommand("Print Shop");
            await Navigation.PushAsync(new BusinessListPage(printShopLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped23(object sender, EventArgs e) // Real Estate
        {
            realEstateLabel.SetBinding(Label.TextProperty, binder);
            realEstateLabel.Text = "Real Estate";
            await sm.ExecuteGetSearchCommand("Real Estate");
            await Navigation.PushAsync(new BusinessListPage(realEstateLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped24(object sender, EventArgs e) // Salon
        {
            salonLabel.SetBinding(Label.TextProperty, binder);
            salonLabel.Text = "Salon";
            await sm.ExecuteGetSearchCommand("Salon");
            await Navigation.PushAsync(new BusinessListPage(salonLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped25(object sender, EventArgs e) // Spa
        {
            spaLabel.SetBinding(Label.TextProperty, binder);
            spaLabel.Text = "Spa";
            await sm.ExecuteGetSearchCommand("Spa");
            await Navigation.PushAsync(new BusinessListPage(spaLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped26(object sender, EventArgs e) // Spiritual
        {
            spiritLabel.SetBinding(Label.TextProperty, binder);
            spiritLabel.Text = "Spiritual";
            await sm.ExecuteGetSearchCommand("Spiritual");
            await Navigation.PushAsync(new BusinessListPage(spiritLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped27(object sender, EventArgs e) // Tailor
        {
            tailorLabel.SetBinding(Label.TextProperty, binder);
            tailorLabel.Text = "Tailor";
            await sm.ExecuteGetSearchCommand("Tailor");
            await Navigation.PushAsync(new BusinessListPage(tailorLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped28(object sender, EventArgs e) // Tanning
        {
            tanningLabel.SetBinding(Label.TextProperty, binder);
            tanningLabel.Text = "Tanning";
            await sm.ExecuteGetSearchCommand("Tanning");
            await Navigation.PushAsync(new BusinessListPage(tanningLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped29(object sender, EventArgs e) // Tatto & Piercing
        {
            tattoLabel.SetBinding(Label.TextProperty, binder);
            tattoLabel.Text = "Tattoo and Piercing";
            await sm.ExecuteGetSearchCommand("Tattoo and Piercing");
            await Navigation.PushAsync(new BusinessListPage(tattoLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped30(object sender, EventArgs e) // Tutor & Trade School
        {
            tutorLabel.SetBinding(Label.TextProperty, binder);
            tutorLabel.Text = "Tutor and Trade School";
            await sm.ExecuteGetSearchCommand("Tutor and Trade School");
            await Navigation.PushAsync(new BusinessListPage(tutorLabel.Text));
        }



        #endregion
    }
}