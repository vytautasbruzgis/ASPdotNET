using _20211215_EF_ShopApp.Models;
using _20211215_FirstEFApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace _20211215_EF_ShopApp.Services
{
    public class ItemTagService
    {
        private DataContext _dataContext;
        public ItemTagService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(ItemTagModel model)
        {
            if(model != null)
            {
                _dataContext.Add(model);
                _dataContext.SaveChanges();
            }
        }
        public List<int> GetTagsByItemId(int id)
        {
            List<int> tags = new List<int>();
            tags = _dataContext.ItemTags.Where(x => x.ShopItemId == id).Select(x => x.TagId).ToList();
            return tags == null ? null : tags;
        }
        public void Delete(ItemTagModel itemTag)
        {
            _dataContext.ItemTags.Remove(itemTag);
        }
    }
}
