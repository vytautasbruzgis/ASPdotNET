using _20211215_EF_ShopApp.Models;
using _20211215_FirstEFApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace _20211215_EF_ShopApp.Services
{
    public class TagService
    {
        private DataContext _dataContext;
        public TagService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<TagModel> GetAllNotDeleted()
        {
            return _dataContext.Tags.Where(x => x.IsDeleted == false).ToList();
        }
        public List<TagModel> GetSelectedIds(List<int> ids)
        {
            return _dataContext.Tags.Where(x => ids.Contains(x.Id)).ToList();
        }
        public List<TagModel> GetAllNotDeletedUnionSelected(List<int> ids)
        {
            return GetAllNotDeleted().Union(GetSelectedIds(ids).ToList()).ToList();
        }
    }
}
