using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class HotelRepository : RepositoryBase<Hotel>
    {
        public HotelRepository(DataContext dataContext): base(dataContext)
        {

        }

        public List<Hotel> GetAllIncluded()
        {
            return _dbSet.Include(x => x.City).Include(y => y.Rooms).ToList();
        }

        public Hotel GetIncluded(int id)
        {
            return _dbSet.Include(x => x.City).FirstOrDefault(x => x.Id == id);
        }

        public List<Hotel> GetAllNotDeletedIncluded()
        {
            return GetAllIncluded().Where(x => x.IsDeleted == false).ToList();
        }

    }
}
