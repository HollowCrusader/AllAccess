using System;
using System.Collections.Generic;
using System.Text;

namespace AllAccess.Data
{
    public class SearchData
    {
        private string address;

        public string Address { get { return address; } set { address = value; } }

        public SearchData()
        {

        }

        public SearchData(string _address)
        {
            Address = _address;
        }
    }
}
