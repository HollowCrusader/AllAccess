using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Text;
//using AllAccess.ViewModels;
//using AllAccess.Helper;

//namespace AllAccess.Data
//{
//    public static class DetailsData
//    {
//        public static ObservableCollection<Detail> detailsList { get; private set; }
        

//        static DetailsData()
//        {
//            var data = new ObservableCollection<Detail>();

//            AddData(data);
//            detailsList = data;
//        }
        
//        public static void AddData(ObservableCollection<Detail> lists)
//        {
//            if (BusinessListPage.dvm.Phone != null || BusinessListPage.dvm.Phone != "")
//            {
//                lists.Add(new Detail()
//                {
//                    Name = "Phone",
//                    Icon = "PHONE.png"
//                });
//            }

//            if (BusinessListPage.dvm.Hours != null || BusinessListPage.dvm.Hours != "")
//            {
//                lists.Add(new Detail()
//                {
//                    Name = "Hours",
//                    Icon = "HOURS.png"
//                });
//            }

//            if (BusinessListPage.dvm.Web != null || BusinessListPage.dvm.Web != "")
//            {
//                lists.Add(new Detail()
//                {
//                    Name = "Website",
//                    Icon = "WEBSITE.png"
//                });
//            }

//            if (BusinessListPage.dvm.FourSquare != null || BusinessListPage.dvm.FourSquare != "")
//            {
//                lists.Add(new Detail()
//                {
//                    Name = "Foursquare",
//                    Icon = "FOURSQUARE.png"
//                });
//            }

//            if (BusinessListPage.dvm.Menu != null || BusinessListPage.dvm.Menu != "")
//            {
//                lists.Add(new Detail()
//                {
//                    Name = "Menu",
//                    Icon = "MENU.png"
//                });
//            }
//        }
//    }
//}
