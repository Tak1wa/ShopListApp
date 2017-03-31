using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListApp.Models
{
    public class ShopCatalog : BindableBase
    {
        public ObservableCollection<Shop> Shops { get; set; } =
            new ObservableCollection<Shop>();
        public ShopCatalog()
        {
            Shops.Add(new Shop());
            Shops.Add(new Shop());
            Shops.Add(new Shop());
            Shops.Add(new Shop());
            Shops.Add(new Shop());
            Shops.Add(new Shop());
            Shops.Add(new Shop());
        }
    }
}
