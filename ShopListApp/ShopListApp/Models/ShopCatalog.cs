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
            Shops.Add(new Shop
            {
                Name = "Odori Park",
                Address = "Hokkaidō, Sapporo-shi, Chūō-ku, Ōdōrinishi, 7丁目",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Odori_Park_Sapporo.JPG/220px-Odori_Park_Sapporo.JPG",
                Latitude = 43.060747,
                Longitude = 141.347775,
                Tel = "080-9999-9999"
            });
            Shops.Add(new Shop
            {
                Name = "Sapporo TV Tower",
                Address = "1 Chome Ōdōrinishi, Chūō-ku, Sapporo-shi, Hokkaidō ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/Sapporo_television_tower_01.jpg/200px-Sapporo_television_tower_01.jpg",
                Latitude = 43.062158,
                Longitude = 141.356401,
                Tel = "080-9999-9999"
            });
        }
    }
}
