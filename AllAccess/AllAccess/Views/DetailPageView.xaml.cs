using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace AllAccess.Views
{
    public partial class DetailPageView : ContentView
    {
        public static ObservableCollection<DetailPageView> stacks = new ObservableCollection<DetailPageView>();

        public DetailPageView()
        {
            InitializeComponent();


            if (ViewModels.DetailViewModel.GetJ.SelectToken("response.venue.url") != null)
            {
                image.Source = "WEBSITE.png";
                text.Text = "WEBSITE";

            }
            if (ViewModels.DetailViewModel.GetJ.SelectToken("response.venue.shortUrl") != null)
            {
                image.Source = "";
            }
            if (ViewModels.DetailViewModel.GetJ.SelectToken("response.venue.hours.timeframes[0].days") == null)
            {
               
            }
            if (ViewModels.DetailViewModel.GetJ.SelectToken("response.venue.menu.mobileUrl") == null)
            {

            }
        }
    }
}
