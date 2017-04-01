using ShopListApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace ShopListApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopDetailPage : ContentPage
    {
        public ShopDetailPage()
        {
            InitializeComponent();
        }

        public ShopDetailPage(ShopDetailViewModel viewModel) : this()
        {
            BindingContext = viewModel;

            var shopPosition =
                    new Position(viewModel.Latitude.Value, viewModel.Longitude.Value);
            mapArea.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    shopPosition,
                    Distance.FromKilometers(4)
                    )
                );
            mapArea.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = shopPosition,
                Label = viewModel.Name.Value,
                Address = viewModel.Address.Value
            });
        }
    }
}
