using System.Collections.Generic;

namespace _20211215_EF_ShopApp.Models
{
    public class ShopModel: Entity
    {
        public List<ShopItemModel> ShopItems { get; set; }
    }
}
