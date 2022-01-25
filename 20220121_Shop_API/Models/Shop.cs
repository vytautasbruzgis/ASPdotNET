using _20210121_Shop_API.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _20220121_Shop_API.Models
{
    public class Shop : NamedEntity
    {
        public List<ShopItem> ShopItems { get; set; }

    }
}
