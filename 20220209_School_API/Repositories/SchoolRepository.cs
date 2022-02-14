using _20220209_School_API.Repositories;
using _20220209_School_API.Data;
using _20220209_School_API.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace _20220209_School_API.Repositories
{
    public class SchoolRepository : NamedRepositoryBase<School>
    {
        public SchoolRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public async Task<School> GetIncludedAsync(int id)
        {
            return await _dbSet.Include(x => x.Students).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
