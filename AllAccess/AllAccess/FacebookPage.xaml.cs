using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AllAccess.Controls;

namespace AllAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookPage : GradientPage
	{
		public FacebookPage ()
		{
			InitializeComponent ();
		}
	}
}