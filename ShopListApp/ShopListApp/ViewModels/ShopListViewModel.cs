using Reactive.Bindings;
using ShopListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListApp.ViewModels
{
    public class ShopListViewModel
    {
        public ReadOnlyReactiveCollection<ShopDetailViewModel> Shops { get; set; }

        public ShopListViewModel()
        {
            var catalog = new ShopCatalog();
            Shops = catalog.Shops.ToReadOnlyReactiveCollection((
                shop => new ShopDetailViewModel(shop)));
        }
    }
}
