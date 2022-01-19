using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class WorkerRepository: RepositoryBase<Worker>
    {
        public WorkerRepository(DataContext dataContext) : base(dataContext)
        {

        }
        public List<Worker> GetAllNotDeletedIncluded()
        {
            return _dbSet.Where(x => x.IsDeleted == false).Include(x => x.Person).Include(y => y.JobType).Include(z => z.Tasks).ToList();
        }
    }
}
