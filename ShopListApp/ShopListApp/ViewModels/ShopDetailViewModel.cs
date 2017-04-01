using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using ShopListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListApp.ViewModels
{
    public class ShopDetailViewModel
    {
        public ReactiveProperty<string> ImageUrl { get; set; }
        public ReactiveProperty<string> Name { get; set; }
        public ReactiveProperty<string> Address { get; set; }
        public ReactiveProperty<string> Tel { get; set; }
        public ReactiveProperty<double> Longitude { get; set; }
        public ReactiveProperty<double> Latitude { get; set; }

        public ReactiveCommand CommandPhoneCall { get; set; }

        public ShopDetailViewModel(Shop shop)
        {
            ImageUrl = shop.ObserveProperty(s => s.ImageUrl).ToReactiveProperty();
            Name = shop.ObserveProperty(s => s.Name).ToReactiveProperty();
            Address = shop.ObserveProperty(s => s.Address).ToReactiveProperty();
            Tel = shop.ObserveProperty(s => s.Tel).ToReactiveProperty();
            Longitude = shop.ObserveProperty(s => s.Longitude).ToReactiveProperty();
            Latitude = shop.ObserveProperty(s => s.Latitude).ToReactiveProperty();

            CommandPhoneCall = Tel.Select(tel => !string.IsNullOrEmpty(tel)).ToReactiveCommand();
            CommandPhoneCall.Subscribe(_ => shop.PhoneCall());
        }
    }
}
