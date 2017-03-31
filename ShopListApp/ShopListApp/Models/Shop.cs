using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListApp.Models
{
    public class Shop : BindableBase
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { SetProperty(ref _Address, value); }
        }

        private string _Tel;
        public string Tel
        {
            get { return _Tel; }
            set { SetProperty(ref _Tel, value); }
        }

        private int _Longitude;
        public int Longitude
        {
            get { return _Longitude; }
            set { SetProperty(ref _Longitude, value); }
        }

        private int _Latitude;
        public int Latitude
        {
            get { return _Latitude; }
            set { SetProperty(ref _Latitude, value); }
        }
    }
}
