using System.Collections.Generic;

namespace _20220121_Shop_API.Models
{
    public class Shop : NamedEntity
    {
        public List<ShopItem> ShopItems { get; set; }

    }
}
