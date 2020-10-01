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
    public partial class FunNightPage : GradientPage
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
        TapGestureRecognizer backTap = new TapGestureRecognizer();
        #endregion
        public FunNightPage()
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

            backTap.Tapped += OnBack;

            arcadeBtn.GestureRecognizers.Add(tapGestureRecognizer);
            artBtn.GestureRecognizers.Add(tapGestureRecognizer2);
            barsBtn.GestureRecognizers.Add(tapGestureRecognizer3);
            bowlingBtn.GestureRecognizers.Add(tapGestureRecognizer4);
            casinoBtn.GestureRecognizers.Add(tapGestureRecognizer5);
            comedyBtn.GestureRecognizers.Add(tapGestureRecognizer6);
            concertBtn.GestureRecognizers.Add(tapGestureRecognizer7);
            danceBtn.GestureRecognizers.Add(tapGestureRecognizer8);
            distilleryBtn.GestureRecognizers.Add(tapGestureRecognizer9);
            golfBtn.GestureRecognizers.Add(tapGestureRecognizer10);
            marioKartBtn.GestureRecognizers.Add(tapGestureRecognizer11);
            minigolfBtn.GestureRecognizers.Add(tapGestureRecognizer12);
            movieBtn.GestureRecognizers.Add(tapGestureRecognizer13);
            musicBtn.GestureRecognizers.Add(tapGestureRecognizer14);
            clubBtn.GestureRecognizers.Add(tapGestureRecognizer15);
            playgroundBtn.GestureRecognizers.Add(tapGestureRecognizer16);
            racingBtn.GestureRecognizers.Add(tapGestureRecognizer17);
            skatingBtn.GestureRecognizers.Add(tapGestureRecognizer18);
            skiingBtn.GestureRecognizers.Add(tapGestureRecognizer19);
            sportsBtn.GestureRecognizers.Add(tapGestureRecognizer20);
            themeParkBtn.GestureRecognizers.Add(tapGestureRecognizer21);
            wineBtn.GestureRecognizers.Add(tapGestureRecognizer22);
            zooBtn.GestureRecognizers.Add(tapGestureRecognizer23);
            back.GestureRecognizers.Add(backTap);



            #endregion
        }

        #region TapMethods
        private async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) // Arcade
        {
            await sm.ExecuteGetSearchCommand(arcadeLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(arcadeLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e) // Art and Museums
        {
            await sm.ExecuteGetSearchCommand(artLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(artLabel.Text));
        }
        private async void TapGestureRecognizer_Tapped3(object sender, EventArgs e) // Bars
        {
            //barsLabel.SetBinding(Label.TextProperty, binder);
            //barsLabel.Text = "Bars";
            await sm.ExecuteGetSearchCommand(barsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(barsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped4(object sender, EventArgs e) // Bowling
        {
            await sm.ExecuteGetSearchCommand(bowlingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bowlingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped5(object sender, EventArgs e) // Casino
        {
            await sm.ExecuteGetSearchCommand(casinoLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(casinoLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped6(object sender, EventArgs e) // Comedy
        {
            await sm.ExecuteGetSearchCommand(comedyLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(comedyLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped7(object sender, EventArgs e) // Concerts
        {
            await sm.ExecuteGetSearchCommand(concertLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(concertLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped8(object sender, EventArgs e) // Dance
        {
            await sm.ExecuteGetSearchCommand(danceLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(danceLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped9(object sender, EventArgs e) // Distillery
        {
            await sm.ExecuteGetSearchCommand(distilleryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(distilleryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped10(object sender, EventArgs e) // Golf
        {
            await sm.ExecuteGetSearchCommand(golfLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(golfLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped11(object sender, EventArgs e) // Mario Kart
        {
           
            await sm.ExecuteGetSearchCommand(marioKartLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(marioKartLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped12(object sender, EventArgs e) // Mini Golf
        {
            await sm.ExecuteGetSearchCommand(minigolfLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(minigolfLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped13(object sender, EventArgs e) // Movie
        {
            await sm.ExecuteGetSearchCommand(movieLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(movieLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped14(object sender, EventArgs e) // Music
        {
            await sm.ExecuteGetSearchCommand(musicLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(musicLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped15(object sender, EventArgs e) // Night club
        {
            await sm.ExecuteGetSearchCommand(clubLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(clubLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped16(object sender, EventArgs e) // Playground
        {
            await sm.ExecuteGetSearchCommand(playgroundLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(playgroundLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped17(object sender, EventArgs e) // Racing
        {
            await sm.ExecuteGetSearchCommand(racingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(racingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped18(object sender, EventArgs e) // Skating
        {
            await sm.ExecuteGetSearchCommand(skatingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(skatingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped19(object sender, EventArgs e) // Skiing
        {
            await sm.ExecuteGetSearchCommand(skiingLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(skiingLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped20(object sender, EventArgs e) // Sports
        {
            await sm.ExecuteGetSearchCommand(sportsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(sportsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped21(object sender, EventArgs e) // Theme Park
        {
            themeParkLabel.SetBinding(Label.TextProperty, binder);
            themeParkLabel.Text = "Theme Park";
            await sm.ExecuteGetSearchCommand("Theme Park");
            await Navigation.PushAsync(new BusinessListPage(themeParkLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped22(object sender, EventArgs e) // Wine
        {
            await sm.ExecuteGetSearchCommand(wineLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(wineLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped23(object sender, EventArgs e) // Zoo
        {
            await sm.ExecuteGetSearchCommand(zooLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(zooLabel.Text));
        }



        #endregion




    }

}
