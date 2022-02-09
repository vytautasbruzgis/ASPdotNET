using _20220121_Shop_API.Data;
using _20220121_Shop_API.Models;

namespace _20220121_Shop_API.Repositories
{
    public class ItemRepository : RepositoryBase<Item>
    {
        public ItemRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
