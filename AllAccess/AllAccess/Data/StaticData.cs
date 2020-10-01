using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AllAccess.Data
{
    public static class StaticData
    {
        public static ObservableCollection<SearchData> list { get; private set; }

        static StaticData()
        {
            var data = new ObservableCollection<SearchData>();

            AddData(data);
            list = data;
        }

        public static void AddData(ObservableCollection<SearchData> lists)
        {
            lists.Add(new SearchData()
            {
                Address = "Cheese"
            });
        }
    }
}
