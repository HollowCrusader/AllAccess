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
    //This is the food and drink page that lists all of the food and drink businesses
    public partial class FoodandDrinkPage : GradientPage
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
        TapGestureRecognizer helpGesture = new TapGestureRecognizer();
        #endregion
        public FoodandDrinkPage ()
		{
            

			InitializeComponent ();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            //Registers each button to its own click method that does the search command
            #region TapRecognizers
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
            backTap.Tapped += OnBack;
            helpGesture.Tapped += HelpGesture_Tapped;

            americanBtn.GestureRecognizers.Add(tapGestureRecognizer);
            asianBtn.GestureRecognizers.Add(tapGestureRecognizer2);
            bagelBtn.GestureRecognizers.Add(tapGestureRecognizer3);
            bakeryBtn.GestureRecognizers.Add(tapGestureRecognizer4);
            barsBtn.GestureRecognizers.Add(tapGestureRecognizer5);
            bbqBtn.GestureRecognizers.Add(tapGestureRecognizer6);
            buffetsBtn.GestureRecognizers.Add(tapGestureRecognizer7);
            hotDogBtn.GestureRecognizers.Add(tapGestureRecognizer8);
            cafeBtn.GestureRecognizers.Add(tapGestureRecognizer9);
            cajunBtn.GestureRecognizers.Add(tapGestureRecognizer10);
            cateringBtn.GestureRecognizers.Add(tapGestureRecognizer11);
            chineseBtn.GestureRecognizers.Add(tapGestureRecognizer12);
            coffeeTeaBtn.GestureRecognizers.Add(tapGestureRecognizer13);
            dessertsBtn.GestureRecognizers.Add(tapGestureRecognizer14);
            back.GestureRecognizers.Add(backTap);

            distilleryBtn.GestureRecognizers.Add(tapGestureRecognizer15);
            dinerBtn.GestureRecognizers.Add(tapGestureRecognizer16);
            foodTruckBtn.GestureRecognizers.Add(tapGestureRecognizer17);
            frenchBtn.GestureRecognizers.Add(tapGestureRecognizer18);
            greekBtn.GestureRecognizers.Add(tapGestureRecognizer19);
            greekMeditBtn.GestureRecognizers.Add(tapGestureRecognizer20);
            healthBtn.GestureRecognizers.Add(tapGestureRecognizer21);
            indianBtn.GestureRecognizers.Add(tapGestureRecognizer22);
            italianBtn.GestureRecognizers.Add(tapGestureRecognizer23);
            japanBtn.GestureRecognizers.Add(tapGestureRecognizer24);
            juiceBarBtn.GestureRecognizers.Add(tapGestureRecognizer25);
            kosherBtn.GestureRecognizers.Add(tapGestureRecognizer26);
            koreanBtn.GestureRecognizers.Add(tapGestureRecognizer27);
            mexicanBtn.GestureRecognizers.Add(tapGestureRecognizer28);
            pizzaBtn.GestureRecognizers.Add(tapGestureRecognizer29);

            saladBtn.GestureRecognizers.Add(tapGestureRecognizer30);
            sandwicheBtn.GestureRecognizers.Add(tapGestureRecognizer31);
            seafoodBtn.GestureRecognizers.Add(tapGestureRecognizer32);
            soupBtn.GestureRecognizers.Add(tapGestureRecognizer33);
            southBtn.GestureRecognizers.Add(tapGestureRecognizer34);
            steakBtn.GestureRecognizers.Add(tapGestureRecognizer35);
            thaiBtn.GestureRecognizers.Add(tapGestureRecognizer36);
            vegetarianBtn.GestureRecognizers.Add(tapGestureRecognizer37);
            vietnameseBtn.GestureRecognizers.Add(tapGestureRecognizer38);
            wineBtn.GestureRecognizers.Add(tapGestureRecognizer39);
            wingsBtn.GestureRecognizers.Add(tapGestureRecognizer40);
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
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) // American
        {
            await sm.ExecuteGetSearchCommand(americanLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(americanLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e) // Asian
        {
           
            await sm.ExecuteGetSearchCommand(asianLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(asianLabel.Text));
        }
        private async void TapGestureRecognizer_Tapped3(object sender, EventArgs e) // Bagel
        {
            await sm.ExecuteGetSearchCommand(bagelLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bagelLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped4(object sender, EventArgs e) // Bakery
        {
            await sm.ExecuteGetSearchCommand(bakeryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bakeryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped5(object sender, EventArgs e) // Bars
        {
            await sm.ExecuteGetSearchCommand(barsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(barsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped6(object sender, EventArgs e) // BBQ
        {
            await sm.ExecuteGetSearchCommand(bbqLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(bbqLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped7(object sender, EventArgs e) // Buffets
        {
            await sm.ExecuteGetSearchCommand(buffetsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(buffetsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped8(object sender, EventArgs e) // Burgers and Hot Dogs
        {
            await sm.ExecuteGetSearchCommand(hotDogLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(hotDogLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped9(object sender, EventArgs e) // Cafe
        {
            await sm.ExecuteGetSearchCommand(cafeLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cafeLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped10(object sender, EventArgs e) // Cajun
        {
            await sm.ExecuteGetSearchCommand(cajunLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cajunLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped11(object sender, EventArgs e) // Catering
        {
            await sm.ExecuteGetSearchCommand(cateringLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(cateringLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped12(object sender, EventArgs e) // Chinese
        {
            await sm.ExecuteGetSearchCommand(chineseLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(chineseLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped13(object sender, EventArgs e) // Coffee Tea
        {
            await sm.ExecuteGetSearchCommand(coffeeTeaLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(coffeeTeaLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped14(object sender, EventArgs e) // Desserts
        {
            await sm.ExecuteGetSearchCommand(dessertsLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(dessertsLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped15(object sender, EventArgs e) // Distillery
        {
            await sm.ExecuteGetSearchCommand(distilleryLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(distilleryLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped16(object sender, EventArgs e) // Diner
        {
            await sm.ExecuteGetSearchCommand(dinerLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(dinerLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped17(object sender, EventArgs e) // Food Truck
        {
            await sm.ExecuteGetSearchCommand(foodTruckLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(foodTruckLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped18(object sender, EventArgs e) // French
        {
            await sm.ExecuteGetSearchCommand(frenchLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(frenchLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped19(object sender, EventArgs e) // Greek
        {
            await sm.ExecuteGetSearchCommand(greekLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(greekLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped20(object sender, EventArgs e) // Greek Mediterranean
        {
            await sm.ExecuteGetSearchCommand(greekMeditLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(greekMeditLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped21(object sender, EventArgs e) // Health Food
        {
            await sm.ExecuteGetSearchCommand(healthLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(healthLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped22(object sender, EventArgs e) // Indian
        {
            await sm.ExecuteGetSearchCommand(indianLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(indianLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped23(object sender, EventArgs e) // Italian
        {
            await sm.ExecuteGetSearchCommand(italianLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(italianLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped24(object sender, EventArgs e) // Japanese
        {
            await sm.ExecuteGetSearchCommand(japanLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(japanLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped25(object sender, EventArgs e) // Juice Bar
        {

            await sm.ExecuteGetSearchCommand(juiceBarLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(juiceBarLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped26(object sender, EventArgs e) // Kosher
        {
           
            await sm.ExecuteGetSearchCommand(kosherLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(kosherLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped27(object sender, EventArgs e) // Korean
        {

            await sm.ExecuteGetSearchCommand(koreanLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(koreanLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped28(object sender, EventArgs e) // Mexican
        {
            await sm.ExecuteGetSearchCommand(mexicanLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(mexicanLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped29(object sender, EventArgs e) // Pizza
        {
            await sm.ExecuteGetSearchCommand(pizzaLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(pizzaLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped30(object sender, EventArgs e) // Salad
        {
            await sm.ExecuteGetSearchCommand(saladLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(saladLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped31(object sender, EventArgs e) // Sandwich
        {
            await sm.ExecuteGetSearchCommand(sandwichLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(sandwichLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped32(object sender, EventArgs e) // Seafood
        {
            await sm.ExecuteGetSearchCommand(seafoodLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(seafoodLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped33(object sender, EventArgs e) // Soup
        {
            await sm.ExecuteGetSearchCommand(soupLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(soupLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped34(object sender, EventArgs e) // Southern
        {
            await sm.ExecuteGetSearchCommand(southLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(southLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped35(object sender, EventArgs e) // Steak
        {
            await sm.ExecuteGetSearchCommand(steakLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(steakLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped36(object sender, EventArgs e) // Thai
        {
            await sm.ExecuteGetSearchCommand(thaiLabel.Text);
            await Navigation.PushAsync(new BusinessListPage(thaiLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped37(object sender, EventArgs e) // Vegetarian
        {
            vegetarianLabel.SetBinding(Label.TextProperty, binder);
            vegetarianLabel.Text = "Vegetarian";
            await sm.ExecuteGetSearchCommand("Vegetarian");
            await Navigation.PushAsync(new BusinessListPage(vegetarianLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped38(object sender, EventArgs e) // Vietnamese
        {
            vietnameseLabel.SetBinding(Label.TextProperty, binder);
            vietnameseLabel.Text = "Vietnamese";
            await sm.ExecuteGetSearchCommand("Vietnamese");
            await Navigation.PushAsync(new BusinessListPage(vietnameseLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped39(object sender, EventArgs e) // Wine
        {
            wineLabel.SetBinding(Label.TextProperty, binder);
            wineLabel.Text = "Wine";
            await sm.ExecuteGetSearchCommand("Wine");
            await Navigation.PushAsync(new BusinessListPage(wineLabel.Text));
        }

        private async void TapGestureRecognizer_Tapped40(object sender, EventArgs e) // Wings
        {
            wingsLabel.SetBinding(Label.TextProperty, binder);
            wingsLabel.Text = "Wings";
            await sm.ExecuteGetSearchCommand("Wings");
            await Navigation.PushAsync(new BusinessListPage(wingsLabel.Text));
        }

        #endregion
    }
}