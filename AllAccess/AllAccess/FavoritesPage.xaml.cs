using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using AllAccess.Controls;
using MvvmHelpers;
using System.Collections.ObjectModel;
using AllAccess.ViewModels;
using AllAccess.Data;

namespace AllAccess
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesPage : GradientPage
	{
        public static BusinessData faveData;

        ObservableCollection<string> getList = new ObservableCollection<string>();

        public FavoritesPage ()
        {
			InitializeComponent ();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            var gesTapRec = new TapGestureRecognizer();

            gesTapRec.Tapped += OnBack;
            back.GestureRecognizers.Add(gesTapRec);

            this.BindingContext = this;

            listView.ItemsSource = FaveViewModel.FaveList;
		}

        //This is the click method that identifies which business is being clicked on
        private async void OnTapped(object s, ItemTappedEventArgs e)
        {

            var getList = e.Item;
            Debug.WriteLine("Checking the selected item!!!! " + getList.ToString());

            for (int i = 0; i < FaveViewModel.FaveList.Count; i++)
            {
                if (getList.ToString() == FaveViewModel.FaveList[i].BusinessName.ToString())
                {


                    faveData = FaveViewModel.FaveList[i];

                    await Navigation.PushAsync(new DetailsPage("fave"));
                }
            }
        }
        void OnBack(Object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
	}
}