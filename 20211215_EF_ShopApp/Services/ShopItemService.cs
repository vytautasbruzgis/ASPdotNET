using _20211215_EF_ShopApp.Models;
using _20211215_EF_ShopApp.Models.Dtos;
using _20211215_FirstEFApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20211215_EF_ShopApp.Services
{
    public class ShopItemService
    {
        private DataContext _dataContext;
        private ItemTagService _itemTagService;
        private List<ShopItemModel> shopItems { get; set; }
        public ShopItemService(DataContext dataContext, ItemTagService itemTagService)
        {
            _dataContext = dataContext;
            _itemTagService = itemTagService;
        }

        public List<ShopItemModel> GetAllNotDeleted()
        {
            return _dataContext.ShopItems.Include(x => x.Shop).Where(x => x.IsDeleted == false).ToList();
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
                item.IsDeleted = true;
                _dataContext.ShopItems.Update(item);
                _dataContext.SaveChanges();
            }   
        }
        public int Create(ShopItemModel model)
        {
            if (model != null)
            {
                _dataContext.ShopItems.Add(model);
                _dataContext.SaveChanges();
                return model.Id;
            }
            return -1;
        }
        public void Update(ShopItemDto model)
        {
            var shopItem = _dataContext.ShopItems.FirstOrDefault(x => x.Id == model.Id);
            if (shopItem != null)
            {
                shopItem.Name = model.Name;
                shopItem.ExpiryDate = model.ExpiryDate;
                shopItem.ShopId = model.ShopId;
                _dataContext.ShopItems.Update(shopItem);
                UpdateTagList(shopItem.Id, model.SelectedTagIds);
                _dataContext.SaveChanges();
            }
        }

        private void UpdateTagList(int itemId, List<int> selectedIds)
        {
            var currentTagIds = _itemTagService.GetTagsByItemId(itemId);
            foreach (var currentTagId in currentTagIds)
            {
                if (!selectedIds.Contains(currentTagId))
                {
                    _itemTagService.Delete(new ItemTagModel() { ShopItemId = itemId, TagId = currentTagId});
                }
            }
            foreach (var selectedId in selectedIds)
            {
                if (!currentTagIds.Contains(selectedId))
                {
                    _itemTagService.Create(new ItemTagModel() { ShopItemId = itemId, TagId = selectedId});
                }
            }
        }
    }
}
