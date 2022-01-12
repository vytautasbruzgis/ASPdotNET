using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class VisitorRepository: RepositoryBase<Visitor>
    {
        public VisitorRepository(DataContext dataContext) : base(dataContext)
        {

        }
        public List<Visitor> GetAllNotDeletedIncluded()
        {
            return _dbSet.Where(x => x.IsDeleted == false).Include(x => x.Person).ToList();
        }
    }
}
