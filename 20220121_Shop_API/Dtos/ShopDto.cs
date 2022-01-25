using System.Collections.Generic;

namespace _20220121_Shop_API.Dtos
{
    public class ShopDto : DtoBase
    {
        public string Name { get; set; }
        public List<ShopItemDto> ShopItems { get; set;}
    }
}
