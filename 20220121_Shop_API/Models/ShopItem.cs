using _20210121_Shop_API.Models;

namespace _20220121_Shop_API.Models
{
    public class ShopItem : Entity
    {
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public decimal Price { get; set; }
    }
}
