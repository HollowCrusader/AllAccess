using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AllAccess.Helper
{
    public class Detail
    {
        static string name = String.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        static string icon = null;
        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public Detail(string name, string icon)
        {
            Name = name;
            Icon = icon;
        }

        public Detail() { }


    }
}
