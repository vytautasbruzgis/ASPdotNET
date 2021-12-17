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
            shops = _dataContext.Shops.Where(x => x.IsDeleted == 0).ToList();
            return shops;
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



    }
}
