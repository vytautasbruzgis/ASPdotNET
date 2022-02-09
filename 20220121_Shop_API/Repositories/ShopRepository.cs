using _20220121_Shop_API.Data;
using _20220121_Shop_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace _20220121_Shop_API.Repositories
{
    public class ShopRepository : NamedRepositoryBase<Shop>
    {
        public ShopRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public Shop GetByIdIncluded(int shopId)
        {
            return _dbSet.Include(x => x.ShopItems).FirstOrDefault(x => x.Id == shopId);
        }
    }
}
