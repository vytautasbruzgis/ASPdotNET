using _20220121_Shop_API.Data;
using _20220121_Shop_API.Models;

namespace _20220121_Shop_API.Repositories
{
    public class ShopItemRepository : RepositoryBase<ShopItem>
    {
        public ShopItemRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
