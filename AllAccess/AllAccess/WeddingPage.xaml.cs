using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAccess.ViewModels;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class WeddingPage : ContentPage
    {
        #region TapList
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
        TapGestureRecognizer helpGesture = new TapGestureRecognizer();


        #endregion

        Binding binder = new Binding("MySearchText");
        SearchViewModel sm = new SearchViewModel();
        TapGestureRecognizer tap = new TapGestureRecognizer();
        public WeddingPage()
        {
            InitializeComponent();



            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            #region tapped
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
            tapGestureRecognizer28.Tapped += TapGestureRecognizer_Tapped28;
            tapGestureRecognizer29.Tapped += TapGestureRecognizer_Tapped29;
            tapGestureRecognizer30.Tapped += TapGestureRecognizer_Tapped30;
            tapGestureRecognizer31.Tapped += TapGestureRecognizer_Tapped31;
            tapGestureRecognizer32.Tapped += TapGestureRecognizer_Tapped32;
            tapGestureRecognizer33.Tapped += TapGestureRecognizer_Tapped33;
            tapGestureRecognizer34.Tapped += TapGestureRecognizer_Tapped34;
            helpGesture.Tapped += HelpGesture_Tapped;

            #endregion

            #region tap adds
            tap.Tapped += OnBack;
            bake.GestureRecognizers.Add(tapGestureRecognizer);
            bed.GestureRecognizers.Add(tapGestureRecognizer2);
            boat.GestureRecognizers.Add(tapGestureRecognizer3);
            boutique.GestureRecognizers.Add(tapGestureRecognizer4);
            bridal.GestureRecognizers.Add(tapGestureRecognizer5);
            carRental.GestureRecognizers.Add(tapGestureRecognizer6);
            catering.GestureRecognizers.Add(tapGestureRecognizer7);
            clothing.GestureRecognizers.Add(tapGestureRecognizer8);
            cosign.GestureRecognizers.Add(tapGestureRecognizer9);
            cosmetic.GestureRecognizers.Add(tapGestureRecognizer10);
            dental.GestureRecognizers.Add(tapGestureRecognizer11);
            dryCleaner.GestureRecognizers.Add(tapGestureRecognizer12);
            space.GestureRecognizers.Add(tapGestureRecognizer13);
            florist.GestureRecognizers.Add(tapGestureRecognizer14);
            gift.GestureRecognizers.Add(tapGestureRecognizer15);
            hotel.GestureRecognizers.Add(tapGestureRecognizer16);
            jewelry.GestureRecognizers.Add(tapGestureRecognizer17);
            legal.GestureRecognizers.Add(tapGestureRecognizer18);
            linger.GestureRecognizers.Add(tapGestureRecognizer19);
            liquor.GestureRecognizers.Add(tapGestureRecognizer20);
            men.GestureRecognizers.Add(tapGestureRecognizer21);
            music.GestureRecognizers.Add(tapGestureRecognizer22);
            photo.GestureRecognizers.Add(tapGestureRecognizer23);
            salon.GestureRecognizers.Add(tapGestureRecognizer24);
            shoes.GestureRecognizers.Add(tapGestureRecognizer25);
            spa.GestureRecognizers.Add(tapGestureRecognizer26);
            spiritual.GestureRecognizers.Add(tapGestureRecognizer28);
            tailor.GestureRecognizers.Add(tapGestureRecognizer29);
            tanning.GestureRecognizers.Add(tapGestureRecognizer30);
            taxi.GestureRecognizers.Add(tapGestureRecognizer31);
            travel.GestureRecognizers.Add(tapGestureRecognizer32);
            wine.GestureRecognizers.Add(tapGestureRecognizer33);
            women.GestureRecognizers.Add(tapGestureRecognizer34);
            #endregion

            back.GestureRecognizers.Add(tap);
        }

        private void HelpGesture_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }

        #region tap methods
        private void OnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(bakeLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bakeLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(bedLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bedLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped3(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(boatLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(boatLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped4(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(boutiqueLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(boutiqueLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped5(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(bridalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bridalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped6(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(carLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(carLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped7(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(caterLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(caterLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped8(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(clothLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(clothLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped9(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(cosignLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cosignLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped10(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(cosignLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cosmeticLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped11(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(dentalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(dentalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped12(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(dryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(dryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped13(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(spaceLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(spaceLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped14(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(floristLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(floristLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped15(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(giftLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(giftLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped16(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(hotelLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(hotelLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped17(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(jewelryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(jewelryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped18(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(legalLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(legalLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped19(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(lingerLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(lingerLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped20(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(liquorLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(liquorLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped21(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(menLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(menLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped22(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(musicLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(musicLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped23(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(photoLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(photoLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped24(object sender, EventArgs e) // travel agency
        {
           await sm.ExecuteGetSearchCommand(salonLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(salonLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped25(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(shoesLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(shoesLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped26(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(spaLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(spaLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped28(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(spiritualLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(spiritualLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped29(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(tailorLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(tailorLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped30(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(tanningLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(tanningLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped31(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(taxiLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(taxiLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped32(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(travelLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(travelLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped33(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(wineLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(wineLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped34(object sender, EventArgs e) // travel agency
        {
            await sm.ExecuteGetSearchCommand(womenLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(womenLabel.Text));
        }
#endregion
    }
}