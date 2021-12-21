using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20211215_EF_ShopApp.Models
{
    public class ShopItemModel: Entity
    {
        public int ShopId { get; set; }
        public ShopModel Shop { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

    public class ShopItemWithShopListModel : ShopItemModel
    {
        [NotMapped]
        public List<ShopModel> ShopList { get; set; }
    }
}
