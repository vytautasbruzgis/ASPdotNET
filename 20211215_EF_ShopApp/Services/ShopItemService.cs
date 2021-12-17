using _20211215_EF_ShopApp.Models;
using _20211215_FirstEFApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20211215_EF_ShopApp.Services
{
    public class ShopItemService
    {
        private DataContext _dataContext;
        private List<ShopItemModel> shopItems { get; set; }
        public ShopItemService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<ShopItemModel> GetAllNotDeleted()
        {
            return _dataContext.ShopItems.Include(x => x.Shop).Where(x => x.IsDeleted == 0).ToList();
        }

        public List<ShopItemModel> GetShopItems(int shopId)
        {
            return GetAllNotDeleted().Where(x => x.ShopId == shopId).ToList();
        }

    }
}
