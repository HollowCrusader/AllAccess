using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAccess.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using AllAccess.Models;
using AllAccess.Controls;

namespace AllAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //This is the access by name page
    public partial class AccessByNamePage : GradientPage
    {
        string name;
        public AccessByNamePage()
        {


            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            //listView.ItemsSource = Data.StaticData.list;


            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            back.GestureRecognizers.Add(tapGestureRecognizer);
            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += AccessButton_Clicked;
            help.GestureRecognizers.Add(tapGestureRecognizer2);

            accessButton.Clicked += AccessButton_Clicked;

        }

        //This method takes the text from the text box and uses it for the search command
        private void AccessButton_Clicked(object sender, EventArgs e)
        {
            name = entryName.Text;
            Navigation.PushAsync(new BusinessListPage(name));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}