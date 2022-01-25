using _20210118_School_API.Repositories;
using _20220118_School_API.Data;
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
