using System;

namespace _20211215_EF_ShopApp.Models
{
    public class ShopItemModel: Entity
    {
        public int ShopId { get; set; }
        public ShopModel Shop { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
