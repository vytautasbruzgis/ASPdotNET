using _20210118_School_API.Repositories;
using _20220118_School_API.Data;
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
