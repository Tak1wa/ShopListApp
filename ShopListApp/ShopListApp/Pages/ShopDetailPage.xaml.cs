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
            mapArea.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(viewModel.Latitude.Value, viewModel.Longitude.Value),
                    Distance.FromMiles(1)
                    )
                );
        }
    }
}
