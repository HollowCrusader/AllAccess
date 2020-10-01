using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using AllAccess.Controls;

namespace AllAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanLogoPage : GradientPage
	{
		public ScanLogoPage ()
		{
			InitializeComponent ();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            var tap = new TapGestureRecognizer();
            tap.Tapped += OnBack;

            back.GestureRecognizers.Add(tap);

        }

        private void OnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
	}
}