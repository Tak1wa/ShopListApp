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
        private string _ImageUrl;
        public string ImageUrl
        {
            get { return _ImageUrl; }
            set { SetProperty(ref _ImageUrl, value); }
        }

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

        private double _Longitude;
        public double Longitude
        {
            get { return _Longitude; }
            set { SetProperty(ref _Longitude, value); }
        }

        private double _Latitude;
        public double Latitude
        {
            get { return _Latitude; }
            set { SetProperty(ref _Latitude, value); }
        }

        public void PhoneCall()
        {
            var phoneDialer = Plugin.Messaging.CrossMessaging.Current.PhoneDialer;
            if(phoneDialer.CanMakePhoneCall)
            {
                phoneDialer.MakePhoneCall(Tel);
            }
        }
    }
}
