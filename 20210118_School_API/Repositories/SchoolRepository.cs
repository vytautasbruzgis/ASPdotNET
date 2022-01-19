using _20210118_School_API.Models;
using _20220118_School_API.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace _20210118_School_API.Repositories
{
    public class SchoolRepository : RepositoryBase<School>
    {
        public SchoolRepository(DataContext dataContext) : base(dataContext){
        }
        public School GetIncluded(int id)
        {
            return _dbSet.Include(x => x.Students).FirstOrDefault();
        }

    }
}
