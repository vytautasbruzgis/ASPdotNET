namespace _20211215_EF_ShopApp.Models
{
    public class ItemTagModel
    {
        public int TagId { get; set; }
        public TagModel Tag { get; set; }
        public int ShopItemId { get; set; }
        public ShopItemModel ShopItem { get; set; }
    }
}
