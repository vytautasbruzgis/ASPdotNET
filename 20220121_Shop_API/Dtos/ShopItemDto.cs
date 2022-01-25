namespace _20220121_Shop_API.Dtos
{
    public class ShopItemDto :DtoBase
    {
        public int ShopId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
    }
}
