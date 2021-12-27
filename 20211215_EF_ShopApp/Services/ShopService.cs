using _20211215_EF_ShopApp.Models;
using _20211215_FirstEFApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace _20211215_EF_ShopApp.Services
{
    public class ShopService
    {
        private DataContext _dataContext;
        private List<ShopModel> shops { get; set; }
        public ShopService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ShopModel> GetAllNotDeleted()
        {
            var shops = new List<ShopModel>();
            shops = _dataContext.Shops.Where(x => x.IsDeleted == false).ToList();
            return shops;
        }
        public List<ShopModel> GetSelectedAndAllNotDeleted(int id)
        {
            var shops = new List<ShopModel>();
            shops = GetAllNotDeleted();
            if (shops.Where(x => x.Id == id).Count() == 0)
            {
                var selectedShop = GetById(id);
                if(selectedShop != null)
                {
                    shops.Add(selectedShop);
                }
            }
            return shops;
        }
        public ShopModel GetById(int id)
        {
            return _dataContext.Shops.FirstOrDefault(x => x.Id == id);
        }
        public void Add(ShopModel m)
        {
            if (m == null)
            {

            } else {
                _dataContext.Shops.Add(m);
                _dataContext.SaveChanges();
            }
        }
        public void Update(ShopModel model)
        {
            var shop = _dataContext.Shops.FirstOrDefault(x => x.Id == model.Id);
            if (shop != null)
            {
                shop.Name = model.Name;
                _dataContext.Shops.Update(shop);
                _dataContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var shop = _dataContext.Shops.FirstOrDefault(x => x.Id == id);
            if (shop != null)
            {
                shop.IsDeleted = true;
                _dataContext.Shops.Update(shop);
                _dataContext.SaveChanges();
            }
        }
    }
}
