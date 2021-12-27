using System;
using System.Collections.Generic;

namespace _20211215_EF_ShopApp.Models.Dtos
{
    public class ShopItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ShopId { get; set; }
        public List<ShopModel> ShopList { get; set; }
        public List<TagModel> TagList { get; set; }
        public List<TagModel> ItemTags { get; set; }
        public List<int> SelectedTagIds { get; set; } 


    }
}
