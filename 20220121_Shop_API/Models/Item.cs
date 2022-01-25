using _20210121_Shop_API.Models;
using System.Collections.Generic;

namespace _20220121_Shop_API.Models
{
    public class Item : NamedEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ShopItem> ShopItems { get; set; }
    }
}
