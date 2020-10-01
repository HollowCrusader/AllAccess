using AllAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAccess.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using AllAccess.Controls;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Xamarin.Forms.Internals;
using System.Runtime.CompilerServices;

namespace AllAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //This page lists out all of the businesses after doing a search
    //This page is a listview that shows the name of the businesses and address
    public partial class BusinessListPage : GradientPage
	{


        //Binding bind = new Binding("GetDetailCommand");
        DetailViewModel dvvm = new DetailViewModel();

		public BusinessListPage (string name)
		{

            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            
            title.Text = name;

            listView.ItemsSource = SearchViewModel.sLV;
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            back.GestureRecognizers.Add(tapGestureRecognizer);

            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += TapGestureRecognizer_Tapped1;
            help.GestureRecognizers.Add(tapGestureRecognizer2);



        }

        private async void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
           var res = await DisplayAlert("ALL ACCESS HELP", 
                "Access menus and more from great businesses in your area.  " +
                "With our resturants partners, you can place orders by showing " +
                "your order page to waitstaff and touching the 'Speak' button.  " +
                "Ask your favorite businesses to add their into to this app.  " +
                "You can also request that a business be added (or updated) by contacting us at info@AllAccess.US.  " +
                "Thanks!", "Settings", "Continue");
            

            if(res == true) // when you click on settings
            {
                await Navigation.PushAsync(new SettingPage());
            }
        }

        //


        private void OnSelected(object s2, SelectedItemChangedEventArgs e2)
        {
            if (e2.SelectedItem != null)
                ((Xamarin.Forms.ListView)s2).SelectedItem = false;
             e2 = null;
        }

       

        private async void OnTapped(object s, ItemTappedEventArgs e)
        {

            var getList = e.Item;
            Debug.WriteLine("Checking the selected item!!!! " + getList.ToString());

            for (int i = 0; i < SearchViewModel.sLV.Count; i++)
            {
                if (getList.ToString() == SearchViewModel.sLV[i].ToString())
                {

                    string selectedID = SearchViewModel.venueId[i];

                    await dvvm.ExecuteDetailsCommand(selectedID);
                    await Navigation.PushAsync(new DetailsPage("business"));
                }
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            listView.
            Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }
    }
}