using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AllAccess.Helper;
using AllAccess.Models;
using Newtonsoft.Json.Linq;
using MvvmHelpers;
using System.Diagnostics;
using Xamarin.Forms;
using AllAccess.Services;
using System.Windows.Input;
using Xamarin.Essentials;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.Geolocator.Abstractions;
using AllAccess.Data;


namespace AllAccess.ViewModels
{
    //This class holds the list of favorites
    public class FaveViewModel:BaseViewModel
    {

        public static ObservableCollection<BusinessData> FaveList = new ObservableCollection<BusinessData>();
        public FaveViewModel()
        {
        }
    }
}
