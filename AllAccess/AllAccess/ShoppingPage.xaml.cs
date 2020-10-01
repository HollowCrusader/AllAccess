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
    public partial class ShoppingPage : GradientPage
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
        public ShoppingPage()
        {
            InitializeComponent();

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
            tapGestureRecognizer31.Tapped += TapGestureRecognizer_Tapped31;
            tapGestureRecognizer32.Tapped += TapGestureRecognizer_Tapped32;
            tapGestureRecognizer33.Tapped += TapGestureRecognizer_Tapped33;
            tapGestureRecognizer34.Tapped += TapGestureRecognizer_Tapped34;
            tapGestureRecognizer35.Tapped += TapGestureRecognizer_Tapped35;
            tapGestureRecognizer36.Tapped += TapGestureRecognizer_Tapped36;
            tapGestureRecognizer37.Tapped += TapGestureRecognizer_Tapped37;
            tapGestureRecognizer38.Tapped += TapGestureRecognizer_Tapped38;
            tapGestureRecognizer39.Tapped += TapGestureRecognizer_Tapped39;
            tapGestureRecognizer40.Tapped += TapGestureRecognizer_Tapped40;
            tap.Tapped += OnBack;
            helpGesture.Tapped += HelpGesture_Tapped;

            antiquesBtn.GestureRecognizers.Add(tapGestureRecognizer);
            atmBtn.GestureRecognizers.Add(tapGestureRecognizer2);
            babyBtn.GestureRecognizers.Add(tapGestureRecognizer3);
            bikingBtn.GestureRecognizers.Add(tapGestureRecognizer4);
            boatingBtn.GestureRecognizers.Add(tapGestureRecognizer5);
            boutiqueBtn.GestureRecognizers.Add(tapGestureRecognizer6);
            bridalBtn.GestureRecognizers.Add(tapGestureRecognizer7);
            clothingBtn.GestureRecognizers.Add(tapGestureRecognizer8);
            consignBtn.GestureRecognizers.Add(tapGestureRecognizer9);
            cosmeticsBtn.GestureRecognizers.Add(tapGestureRecognizer10);
            electronicsBtn.GestureRecognizers.Add(tapGestureRecognizer11);
            floristsBtn.GestureRecognizers.Add(tapGestureRecognizer12);
            gameBtn.GestureRecognizers.Add(tapGestureRecognizer13);
            gasBtn.GestureRecognizers.Add(tapGestureRecognizer14);
            giftsBtn.GestureRecognizers.Add(tapGestureRecognizer15);
            organicBtn.GestureRecognizers.Add(tapGestureRecognizer16);
            groceryBtn.GestureRecognizers.Add(tapGestureRecognizer17);
            hardwareBtn.GestureRecognizers.Add(tapGestureRecognizer18);
            healthBtn.GestureRecognizers.Add(tapGestureRecognizer19);
            homeBtn.GestureRecognizers.Add(tapGestureRecognizer20);
            jewelryBtn.GestureRecognizers.Add(tapGestureRecognizer21);
            legalBtn.GestureRecognizers.Add(tapGestureRecognizer22);
            lingBtn.GestureRecognizers.Add(tapGestureRecognizer23);
            liquorBtn.GestureRecognizers.Add(tapGestureRecognizer24);
            mallBtn.GestureRecognizers.Add(tapGestureRecognizer25);
            medicalBtn.GestureRecognizers.Add(tapGestureRecognizer26);
            menClothingBtn.GestureRecognizers.Add(tapGestureRecognizer27);
            mobileBtn.GestureRecognizers.Add(tapGestureRecognizer28);
            musicBtn.GestureRecognizers.Add(tapGestureRecognizer29);
            opticalBtn.GestureRecognizers.Add(tapGestureRecognizer30);
            pawnBtn.GestureRecognizers.Add(tapGestureRecognizer31);
            petsBtn.GestureRecognizers.Add(tapGestureRecognizer32);
            pharmacyBtn.GestureRecognizers.Add(tapGestureRecognizer33);
            printShopBtn.GestureRecognizers.Add(tapGestureRecognizer34);
            realEstateBtn.GestureRecognizers.Add(tapGestureRecognizer35);
            shoesBtn.GestureRecognizers.Add(tapGestureRecognizer36);
            sportingBtn.GestureRecognizers.Add(tapGestureRecognizer37);
            tailorBtn.GestureRecognizers.Add(tapGestureRecognizer38);
            toysBtn.GestureRecognizers.Add(tapGestureRecognizer39);
            womenClothingBtn.GestureRecognizers.Add(tapGestureRecognizer40);
            backButton.GestureRecognizers.Add(tap);

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

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) // Antiques
        {
            await sm.ExecuteGetSearchCommand(antiquesLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(antiquesLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e) // Atm and Banking
        {
            await sm.ExecuteGetSearchCommand(atmLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(atmLabel.Text));
        }
        private async void TapGestureRecognizer_Tapped3(object sender, EventArgs e) // Baby and Kids
        {
            await sm.ExecuteGetSearchCommand(babyLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(babyLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped4(object sender, EventArgs e) // Biking
        {
            await sm.ExecuteGetSearchCommand(bikingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bikingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped5(object sender, EventArgs e) // Boating
        {
            await sm.ExecuteGetSearchCommand(boatingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(boatingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped6(object sender, EventArgs e) // Boutique
        {
            await sm.ExecuteGetSearchCommand(boutiqueLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(boutiqueLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped7(object sender, EventArgs e) // Bridal
        {
            await sm.ExecuteGetSearchCommand(bridalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bridalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped8(object sender, EventArgs e) // Clothing
        {
            await sm.ExecuteGetSearchCommand(clothingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(clothingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped9(object sender, EventArgs e) // Consignment & Vintage
        {
            await sm.ExecuteGetSearchCommand(consignLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(consignLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped10(object sender, EventArgs e) // Cosmetics
        {
            await sm.ExecuteGetSearchCommand(cosmeticsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cosmeticsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped11(object sender, EventArgs e) // Electronics
        {
            await sm.ExecuteGetSearchCommand(electronicsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(electronicsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped12(object sender, EventArgs e) // Florists
        {
            await sm.ExecuteGetSearchCommand(floristsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(floristsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped13(object sender, EventArgs e) // Games
        {
            await sm.ExecuteGetSearchCommand(gameLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(gameLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped14(object sender, EventArgs e) // Gas
        {
            await sm.ExecuteGetSearchCommand(gasLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(gasLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped15(object sender, EventArgs e) // Gifts
        {
            await sm.ExecuteGetSearchCommand(giftsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(giftsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped16(object sender, EventArgs e) // Gourmet & Organic
        {
           await sm.ExecuteGetSearchCommand(organicLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(organicLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped17(object sender, EventArgs e) // Grocery
        {
            await sm.ExecuteGetSearchCommand(groceryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(groceryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped18(object sender, EventArgs e) // Hardware
        {
            await sm.ExecuteGetSearchCommand(hardwareLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(hardwareLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped19(object sender, EventArgs e) // Health Food
        {
            await sm.ExecuteGetSearchCommand(healthLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(healthLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped20(object sender, EventArgs e) // Home Services
        {
            await sm.ExecuteGetSearchCommand(homeLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(homeLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped21(object sender, EventArgs e) // Jewelery
        {
            await sm.ExecuteGetSearchCommand(jewelryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(jewelryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped22(object sender, EventArgs e) // Legal & Financial
        {
            await sm.ExecuteGetSearchCommand(legalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(legalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped23(object sender, EventArgs e) // Lingerie
        {
            await sm.ExecuteGetSearchCommand(lingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped24(object sender, EventArgs e) // Liquor
        {
            await sm.ExecuteGetSearchCommand(liquorLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(liquorLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped25(object sender, EventArgs e) // Mall
        {
            mallLabel.SetBinding(Label.TextProperty, binder);
            await sm.ExecuteGetSearchCommand(mallLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(mallLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped26(object sender, EventArgs e) // Medical Supply & Center
        {
            await sm.ExecuteGetSearchCommand(medicalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(medicalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped27(object sender, EventArgs e) // Men's Clothing
        {
            await sm.ExecuteGetSearchCommand(menClothingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(menClothingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped28(object sender, EventArgs e) // Mobile
        {
            await sm.ExecuteGetSearchCommand(mobileLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(mobileLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped29(object sender, EventArgs e) // Music Shop
        {
            await sm.ExecuteGetSearchCommand(musicLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(musicLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped30(object sender, EventArgs e) // Optical
        {
            await sm.ExecuteGetSearchCommand(opticalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(opticalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped31(object sender, EventArgs e) // Pawn Shop
        {
            await sm.ExecuteGetSearchCommand(pawnLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(pawnLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped32(object sender, EventArgs e) // Pets
        {
            await sm.ExecuteGetSearchCommand(petsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(petsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped33(object sender, EventArgs e) // Pharmacy
        {
            await sm.ExecuteGetSearchCommand(pharmacyLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(pharmacyLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped34(object sender, EventArgs e) // Print Shop
        {
            await sm.ExecuteGetSearchCommand(printShopLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(printShopLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped35(object sender, EventArgs e) // Real Estate
        {
            await sm.ExecuteGetSearchCommand(realEstateLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(realEstateLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped36(object sender, EventArgs e) // Shoes
        {
            await sm.ExecuteGetSearchCommand(shoesLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(shoesLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped37(object sender, EventArgs e) // Sporting Goods
        {
            await sm.ExecuteGetSearchCommand(sportingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(sportingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped38(object sender, EventArgs e) // Tailor
        {
            await sm.ExecuteGetSearchCommand(tailorLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(tailorLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped39(object sender, EventArgs e) // Toys
        {
            await sm.ExecuteGetSearchCommand(toysLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(toysLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped40(object sender, EventArgs e) // Women's Clothing
        {
            await sm.ExecuteGetSearchCommand(womenClothingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(womenClothingLabel.Text));
        }



        #endregion
    }
}