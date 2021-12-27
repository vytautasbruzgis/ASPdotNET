using System.Collections.Generic;

namespace _20211215_EF_ShopApp.Models
{
    public class TagModel : Entity
    {
        public List<ItemTagModel> ItemTags { get; set; }
    }
}
