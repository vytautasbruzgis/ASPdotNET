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
        public ShopItemModel GetById(int id)
        {
            //ToDo: validacija pagal Id nerastą
            return _dataContext.ShopItems.FirstOrDefault(x => x.Id == id);
        }        
        public void Delete(int itemId)
        {
            var item = _dataContext.ShopItems.FirstOrDefault(x => x.Id == itemId);
            if(item != null)
            {
                item.IsDeleted = 1;
                _dataContext.ShopItems.Update(item);
                _dataContext.SaveChanges();
            }   
        }
        public void Create(ShopItemWithShopListModel model)
        {
            if (model != null)
            {
                _dataContext.ShopItems.Add(
                    new ShopItemModel()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        ShopId = model.ShopId,
                        ExpiryDate = model.ExpiryDate
                    }
                );
                _dataContext.SaveChanges();
            }
        }
        public void Update(ShopItemWithShopListModel model)
        {
            var shopItem = _dataContext.ShopItems.FirstOrDefault(x => x.Id == model.Id);
            if (shopItem != null)
            {
                shopItem.Name = model.Name;
                shopItem.ExpiryDate = model.ExpiryDate;
                shopItem.ShopId = model.ShopId;
                _dataContext.ShopItems.Update(shopItem);
                _dataContext.SaveChanges();
            }
        }
    }
}
